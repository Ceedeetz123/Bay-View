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
    public partial class Bookings : Form
    {
        public Bookings(string instring)
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

        string disables;

        int Total;

        int amountdisables;

        int breakfast;

        DataTable dtRooms = new DataTable(); //Datatable for Room reservation
        DataTable dtRoom = new DataTable(); //Datatable for Room Types
        DataTable dtCustomer = new DataTable(); //Datatable for customers

        string avi = @"Select r.Room_No From Room r
                     Where NOT EXISTS
                     (SELECT b.Room_No FROM Booking b
                     WHERE b.Room_No = r.Room_No
                     AND (Start_Date >= @Starts And End_Date <= @Ends))
                     AND Room_Size = @Rooms
                     AND Room_Type = @Disableds";


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
                string Start = dtpStart.Value.Date.ToString("yyyy-MM-dd"); //Converts date picker format to Years-Months-Days
                string End = dtpEnd.Value.Date.ToString("yyyy-MM-dd");
                using (SQLiteConnection Conn = new SQLiteConnection(conString))
                {

                    Conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(avi, Conn))
                    {
                        cmd.Parameters.AddWithValue("Starts", Start);
                        cmd.Parameters.AddWithValue("Ends", End);
                        cmd.Parameters.AddWithValue("Rooms", cbRoomSize.Text);
                        cmd.Parameters.AddWithValue("Disableds", disables);
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
                nudAdults.Maximum = 4;
                nudChildren.Maximum = 4;

                string Start = dtpStart.Value.Date.ToString("yyyy-MM-dd"); //Converts date picker format to Years-Months-Days
                string End = dtpEnd.Value.Date.ToString("yyyy-MM-dd");

                lblStaff.Text = "Staff: " + dbRole.Role;//Displays the Staff's ID from a store variable in a class
                using (SQLiteConnection Conn = new SQLiteConnection(conString))
                {
                    using (SQLiteDataAdapter daRoom = new SQLiteDataAdapter(room, Conn))
                    {
                        daRoom.Fill(dtRoom);
                    }
                    using (SQLiteDataAdapter daCustomer = new SQLiteDataAdapter(ID, Conn))
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
                        daRooms.SelectCommand.Parameters.AddWithValue("Starts", Start);
                        daRooms.SelectCommand.Parameters.AddWithValue("Ends", End);
                        daRooms.SelectCommand.Parameters.AddWithValue("Rooms", cbRoomSize.Text);
                        daRooms.SelectCommand.Parameters.AddWithValue("Disableds", disables);
                        daRooms.Fill(dtRooms);

                    }


                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cbRoomSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbRooms.Items.Clear();
            btnSearch.Enabled = true;
        }

        private void cbDisabled_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDisabled.Checked)
            {
                disables = "Disabled";
                amountdisables = 1;
            }

            else if (!cbDisabled.Checked)
            {
                disables = "Non-disabled";
                amountdisables = 0;
            }

            lbRooms.Items.Clear();
            btnSearch.Enabled = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (chbBreakFast.Checked && cbRoomSize.Text == "Single")//Single Room with breakfast
            {
                Total += 75 * (Convert.ToInt32(tbtDuration.Text));
                lblTotal.Text = Total.ToString();
            }
            else
            if (cbRoomSize.Text == "Single")//Single Room
            {
                Total += 70 * (Convert.ToInt32(tbtDuration.Text));
                lblTotal.Text = Total.ToString();
            }
            else
            if (cbRoomSize.Text == "Double" && nudAdults.Value == 1)//One adult in a double bed
            {
                Total += 90 * (Convert.ToInt32(tbtDuration.Text));
                lblTotal.Text = Total.ToString();
            }
            else
             if (cbRoomSize.Text == "Double" && nudAdults.Value == 1 && chbBreakFast.Checked)//One adult in a double bed with breakfast
            {
                Total += 95 * (Convert.ToInt32(tbtDuration.Text));
                lblTotal.Text = Total.ToString();
            }
            else
            if (cbRoomSize.Text == "Double" && nudAdults.Value == 2 || cbRoomSize.Text == "Double" && nudAdults.Value == 1 && nudChildren.Value == 1)//Two adult or one adult with one children in a double bed
            {
                Total += 110 * (Convert.ToInt32(tbtDuration.Text));
                lblTotal.Text = Total.ToString();
            }
            else
            if (cbRoomSize.Text == "Double" && nudAdults.Value == 2 && chbBreakFast.Checked || cbRoomSize.Text == "Double" && nudAdults.Value == 1 && nudChildren.Value == 1 && chbBreakFast.Checked)//Two adult or one adult with one children in a double bed with breakfast
            {
                Total += 120 * (Convert.ToInt32(tbtDuration.Text));
                lblTotal.Text = Total.ToString();
            }
            else
             if (cbRoomSize.Text == "Family")//Family Room
            {
                Total += 160 * (Convert.ToInt32(tbtDuration.Text));
                lblTotal.Text = Total.ToString();
            }
            else
             if (cbRoomSize.Text == "Family" && chbBreakFast.Checked)//Family Room
            {
                Total += 175 * (Convert.ToInt32(tbtDuration.Text));
                lblTotal.Text = Total.ToString();
            }
            try
            {
                string Start = dtpStart.Value.Date.ToString("yyyy-MM-dd"); //Converts date picker format to Years-Months-Days
                string End = dtpEnd.Value.Date.ToString("yyyy-MM-dd");

                using (SQLiteConnection Conn = new SQLiteConnection(conString))
                {
                    string booking = @"INSERT INTO Booking(Staff_ID, Guest_ID, Room_No, Start_Date, End_Date, Duration, Children, Adults, Disabled, Breakfast, Total_Cost)
                     VALUES (@Staffs, @Guests, @RoomNO, @Starts, @Ends, @Period, @Child, @Adult, @Disableds, @Breakfasts, @Amount)";
                    Conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(booking, Conn))
                    {
                    
                        cmd.Parameters.AddWithValue("Staffs", dbRole.Role);
                        cmd.Parameters.AddWithValue("Guests", cbCustomerID.ValueMember);
                        cmd.Parameters.AddWithValue("RoomNO", cbRoomSize.ValueMember);//
                        cmd.Parameters.AddWithValue("Starts", Start);
                        cmd.Parameters.AddWithValue("Ends", End);
                        cmd.Parameters.AddWithValue("Period", tbtDuration.Text);
                        cmd.Parameters.AddWithValue("Child", nudChildren.Text);
                        cmd.Parameters.AddWithValue("Adult", nudAdults.Text);
                        cmd.Parameters.AddWithValue("Disableds", amountdisables);
                        cmd.Parameters.AddWithValue("Breakfasts", breakfast);
                        cmd.Parameters.AddWithValue("Amount", Total);
                        cmd.ExecuteNonQuery();
                    }
                    Conn.Close();
                    Conn.Dispose();
                    this.Close();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lbRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelectedRoom.Text = "Your selected room: " + Convert.ToInt32(lbRooms.SelectedItem).ToString();

        }

        private void chbBreakFast_CheckedChanged(object sender, EventArgs e)
        {
            if (chbBreakFast.Checked)
            {
                breakfast = 1;
            }
            else
            if (!chbBreakFast.Checked)
            {
                breakfast = 0;
            }
        }

    }
}
