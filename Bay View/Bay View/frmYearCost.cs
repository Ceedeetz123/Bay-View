using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Windows.Forms.DataVisualization.Charting;



namespace Bay_View
{
    public partial class frmYearCost : Form
    {
        public frmYearCost(string inString)
        {
            InitializeComponent();
            conString = inString;
        }
        string conString = dbConns.dbSource;

        Series Year;

        string YearCosts = @"Select Sum(Total_Cost) as TotalCost, 
        strftime('%Y',Start_Date) as Year from Booking
        group by strftime('%Y',Start_Date) "; //Sql code for calculating the total cost for each year

        private void YearCost_Load_1(object sender, EventArgs e)
        {
            try
            {
                chart1.Titles.Clear();
                chart1.Titles.Add("Total Revenue from each Year");
                chart1.ChartAreas[0].AxisX.IsMarginVisible = false;
                chart1.ChartAreas[0].AxisX.Maximum = 12;
                chart1.ChartAreas[0].AxisX.Minimum = -1;
                chart1.ChartAreas[0].AxisX.Title = "Occupancy";
                chart1.ChartAreas[0].AxisY.Title = "Years";


                chart1.Series.Clear();

                Year = chart1.Series.Add("Years");
                {
                    using (SQLiteConnection Conn = new SQLiteConnection(conString)) //Connection Object for linking the database
                    {

                        Conn.Open();
                        using (SQLiteCommand cmd = new SQLiteCommand(YearCosts, Conn)) //Creates a connection between the sql code and the database connection
                        {

                            using (SQLiteDataReader DataRead = cmd.ExecuteReader())
                            {
                                int element = 0;
                                while (DataRead.Read())
                                {
                                    Year.Points.AddXY(element, Convert.ToInt32(DataRead[0]));
                                    chart1.Series[0].Points[element].AxisLabel = DataRead[1].ToString();
                                    chart1.ResetAutoValues();
                                    chart1.Update();
                                    element++;
                                }
                            }
                            Conn.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            }
    }
}
   
