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
    public partial class frmOccupancyTypes : Form
    {
        public frmOccupancyTypes(string inString)
        {
            InitializeComponent();
            conString = inString;
        }
        string conString = dbConns.dbSource;

        Series Types;



        string OccupancyRoomss = @"Select Count(r.Room_No) AS Amount , Room_No From Room r
                     Where EXISTS
                     (SELECT b.Room_No FROM Booking b
                     WHERE b.Room_No = r.Room_No
                     and strftime('%Y',Start_Date) = @Years
                     and r.Room_Size = @Sizes)
                     GROUP BY Room_No";//Sql code for finding occupancy amount for a specific year and room size

        private void OccupancyTypes_Load(object sender, EventArgs e)
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

                Types = chart1.Series.Add("Occupancy");

                {
                    using (SQLiteConnection Conn = new SQLiteConnection(conString)) //Connection Object for linking the database
                    {

                        Conn.Open();
                        using (SQLiteCommand cmd = new SQLiteCommand(OccupancyRoomss, Conn)) //Creates a connection between the sql code and the database connection
                        {
                            cmd.Parameters.AddWithValue("Years", tbtYear.Text);
                            cmd.Parameters.AddWithValue("Sizes", tbtSize.Text);
                            using (SQLiteDataReader DataRead = cmd.ExecuteReader())
                            {
                                int element = 0;
                                while (DataRead.Read())
                                {
                                    Types.Points.AddXY(element, Convert.ToInt32(DataRead[0]));
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
          
                OccupancyTypes_Load(this, new EventArgs());
         
        }

        private void tbtSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OccupancyTypes_Load(this, new EventArgs());
            }
        }

        private void tbtYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OccupancyTypes_Load(this, new EventArgs());
            }
        }
    }
    }

