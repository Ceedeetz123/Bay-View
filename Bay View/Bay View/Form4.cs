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

namespace Bay_View
{
    public partial class Form4 : Form
    {
        public Form4(string instring)
        {
            InitializeComponent();
            conString = instring;

            dtpStart.MinDate = DateTime.Today;
            dtpEnd.MinDate = DateTime.Today;

            dtpStart.MaxDate = dtpEnd.MinDate;

            DateTime Start = dtpStart.Value.Date;
            DateTime End = dtpEnd.Value.Date;
            TimeSpan t = End - Start;
        }

        DataTable dtRooms = new DataTable();

        string conString = dbConns.dbSource;

        //string Rooms = "SELECT Room_No from Room";
        string avi = @"Select Room_No From Room r 
                     Where NOT EXISTS
                     (SELECT * FROM Booking
                     WHERE  Room_No = R.Room_No
                     AND End_Date >= @Ends
                     AND Start_Date <= @Starts)";


        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {

            DateTime Start = dtpStart.Value.Date;
            DateTime End = dtpEnd.Value.Date;
            dtpStart.MaxDate = dtpEnd.Value.Date; //Does not allow the user to choose a start date after the end date
            TimeSpan t = End - Start;
            
            tbtDuration.Text = t.TotalDays.ToString();


        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {

            DateTime Start = dtpStart.Value.Date;
            DateTime End = dtpEnd.Value.Date;
            dtpEnd.MinDate = dtpStart.Value.Date; //Does not allow users to choose a end date before the start date
            TimeSpan t = End - Start;

            tbtDuration.Text = t.TotalDays.ToString();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {
                using (SQLiteConnection Conn = new SQLiteConnection(conString))
                {   
                    
                    Conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(avi, Conn))
                    {
                        cmd.Parameters.AddWithValue("Starts", dtpStart.Value.ToString("dd-mm-yyyy"));
                        cmd.Parameters.AddWithValue("Ends", dtpEnd.Value.ToString("dd-mm-yyyy"));
                        using (SQLiteDataReader DataRead = cmd.ExecuteReader())
                        {
                          
                            while (DataRead.Read())
                            {
                                lbRooms.Items.Add(DataRead["Room_No"]); //Keeps adding records
                            }

                        }
                        Conn.Close();
                    }
                    Conn.Close();
                }

            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection Conn = new SQLiteConnection(conString))
                {
                    Conn.Open();

                    using (SQLiteDataAdapter daRooms = new SQLiteDataAdapter(avi, Conn))
                    {
                       
                        daRooms.SelectCommand.Parameters.AddWithValue("Starts", dtpStart.Value.ToString("dd-mm-yyyy"));
                        daRooms.SelectCommand.Parameters.AddWithValue("Ends", dtpStart.Value.ToString("dd-mm-yyyy"));
                        daRooms.Fill(dtRooms);

                    }
                 

                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
