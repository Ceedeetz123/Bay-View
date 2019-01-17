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
    public partial class Analysis : Form
    {
        public Analysis(string instring)
        {
            InitializeComponent();
            conString = instring;
        }
        string conString = dbConns.dbSource;

        Series occupancy;

        string OccupancyTimes = @"Select Count(strftime('%m',Start_Date)) as Occupancy,
        strftime('%m',Start_Date) as Month From Booking
        WHERE strftime('%Y',Start_Date) = @Years
        Group BY strftime('%m',End_Date),strftime('%m',Start_Date)";

        private void Analysis_Load(object sender, EventArgs e)
        {
            try
            {
                chart1.Titles.Clear();
                chart1.Titles.Add("Room Occupancy");
                chart1.ChartAreas[0].AxisX.IsMarginVisible = false;
                chart1.ChartAreas[0].AxisX.Maximum = 12;
                chart1.ChartAreas[0].AxisX.Minimum = -1;
                chart1.ChartAreas[0].AxisX.Title = "Occupancy";


                chart1.Series.Clear();

                occupancy = chart1.Series.Add("Occupancy");

                {
                    using (SQLiteConnection Conn = new SQLiteConnection(conString)) //Connection Object for linking the database
                    {
                        Conn.Open();
                        using (SQLiteCommand cmd = new SQLiteCommand(OccupancyTimes, Conn)) //Creates a connection between the sql code and the database connection
                        {
                            cmd.Parameters.AddWithValue("Years", tbtYear.Text);
                            using (SQLiteDataReader DataRead = cmd.ExecuteReader())
                            {
                                int element = 0;
                                while (DataRead.Read())
                                {
                                    occupancy.Points.AddXY(element, Convert.ToInt32(DataRead[0]));
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

     

        private void tbtYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Analysis_Load(this, new EventArgs());
            }
        }
    }
}
