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
        string conString = dbConns.dbSource;


        DataTable dtRooms = new DataTable(); //Datatable for Room reservation
        DataTable dtRoom = new DataTable(); //Datatable for Room Types
        DataTable dtCustomer = new DataTable(); //Datatable for customers

        //string Rooms = "SELECT Room_No from Room";
        string avi = @"Select r.Room_No From Room r
                     Where NOT EXISTS
                     (SELECT b.Room_No FROM Booking b
                     WHERE b.Room_No = r.Room_No
                     AND (Start_Date >= @Starts And End_Date <= @Ends))
                     AND Room_Size = @Rooms";

        string disabled = @"Select r.Room_No From Room r
                     WHERE NOT EXISTS(
                     SELECT
                     CASE WHEN Room_Type = 'Disabled' THEN (SELECT b.Room_No FROM Booking b
                     WHERE b.Room_No = r.Room_No
                     AND (Start_Date >= '2019-01-01' And End_Date <='2019-01-09' ))
                     AND Room_Type = 'Disabled')
                     ELSE(Select r.Room_No From Room r
                     Where NOT EXISTS
                     (SELECT b.Room_No FROM Booking b
                     WHERE b.Room_No = r.Room_No
                     AND (Start_Date >= '2019-01-01' And End_Date <= '2019-01-09')
                     AND Room_Size = @Rooms)";

        string room = "SELECT Room_Size FROM Room Group By Room_Size";

        string ID = "SELECT Guest_ID, (First_Name ||' '|| Last_Name) as Name from Guests";

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            lbRooms.Items.Clear();
            btnSearch.Enabled = true;

            DateTime Start = dtpStart.Value.Date;
            DateTime End = dtpEnd.Value.Date;
            dtpStart.MaxDate = dtpEnd.Value.Date; //Does not allow the user to choose a start date after the end date
            TimeSpan t = End - Start;
            
            tbtDuration.Text = t.TotalDays.ToString();
            

        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            lbRooms.Items.Clear();
            btnSearch.Enabled = true;

            DateTime Start = dtpStart.Value.Date;
            DateTime End = dtpEnd.Value.Date;
            dtpEnd.MinDate = dtpStart.Value.Date; //Does not allow users to choose a end date before the start date
            TimeSpan t = End - Start;//Calculates the Duration between the start and end dates

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
                        cmd.Parameters.AddWithValue("Starts", dtpStart.Value.ToString("yyyy-mm-dd"));
                        cmd.Parameters.AddWithValue("Ends", dtpEnd.Value.ToString("yyyy-mm-dd"));
                        cmd.Parameters.AddWithValue("Rooms", cbRoomSize.Text);
                        using (SQLiteDataReader DataRead = cmd.ExecuteReader())
                        {
                          
                            while (DataRead.Read())
                            {
                                lbRooms.Items.Add(DataRead["Room_No"]); //Keeps adding records
                                btnSearch.Enabled = false;
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
                lblStaff.Text = "Staff: " + dbRole.Role;//Displays the Staff's ID from a store variable in a class
                using (SQLiteConnection Conn = new SQLiteConnection(conString))
                {
                    using (SQLiteDataAdapter daRoom = new SQLiteDataAdapter(room, Conn))
                    {
                        daRoom.Fill(dtRoom);
                    }
                    using (SQLiteDataAdapter daCustomer= new SQLiteDataAdapter(ID, Conn))
                    {
                        daCustomer.Fill(dtCustomer);
                    }
                    //Customer Combobox
                    cbCustomerID.DataSource = dtCustomer;
                    cbCustomerID.ValueMember = "Guest_ID";
                    cbCustomerID.DisplayMember = "Name";
                    cbCustomerID.SelectedIndex = 0;
                    //Room Combobox
                    cbRoomSize.DataSource = dtRoom;
                    cbRoomSize.ValueMember = "Room_Size";
                    cbRoomSize.DisplayMember = "Room_Size";
                    cbRoomSize.SelectedIndex = 0;

                    Conn.Open();

                    using (SQLiteDataAdapter daRooms = new SQLiteDataAdapter(avi, Conn))
                    {
                       //Preloads the parameters for the room reservation list
                        daRooms.SelectCommand.Parameters.AddWithValue("Starts", dtpStart.Value.ToString("yyyy-mm-dd"));
                        daRooms.SelectCommand.Parameters.AddWithValue("Ends", dtpStart.Value.ToString("yyyy-mm-dd"));
                        daRooms.SelectCommand.Parameters.AddWithValue("Rooms", cbRoomSize.Text);
                        daRooms.Fill(dtRooms);

                    }
                 

                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        private void cbRoomSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbRooms.Items.Clear();
            btnSearch.Enabled = true;
        }
    }
}
