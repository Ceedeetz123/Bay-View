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
using System.Globalization;

namespace Bay_View
{
    public partial class Form6 : Form
    {
        public Form6(string instring)
        {
            InitializeComponent();
            conString = instring;
        }
        string conString = dbConns.dbSource;

        DataTable dtBookingCB = new DataTable(); //For the booking Combobox.
        DataTable dtBooking = new DataTable(); //For editing bookings.

        int disabled;

        int breakfast;

        private void Form6_Load(object sender, EventArgs e)
        {

            try
            {
                lblStaffID.Text = "Your staff ID is: " + dbRole.Role;
                using (SQLiteConnection Conn = new SQLiteConnection(conString))
                {
                    string ID = "SELECT Booking_Ref_No from Booking";
                    string Datas = "SELECT * FROM Booking";

                    using (SQLiteDataAdapter daBookingCB = new SQLiteDataAdapter(ID, Conn))
                    {
                        daBookingCB.Fill(dtBookingCB);
                    }
                    using (SQLiteDataAdapter daBooking = new SQLiteDataAdapter(Datas, Conn))
                    {
                        daBooking.Fill(dtBooking);
                    }
                    chbBooking.DataSource = dtBookingCB;
                    chbBooking.ValueMember = "Booking_Ref_No";
                    chbBooking.DisplayMember = "Booking_Ref_No";
                    chbBooking.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chbBooking_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                DataView dv = dtBooking.DefaultView; //Uses Text

                dv.RowFilter = "CONVERT(Booking_Ref_No, 'System.String') LIKE '%" + chbBooking.SelectedValue.ToString() + "%'";

                tbtBookingNo.Text = dv[0]["Booking_Ref_No"].ToString();
                tbtGuestID.Text = dv[0]["Guest_ID"].ToString();
                tbtRoomNo.Text = dv[0]["Room_No"].ToString();
                dtpStart.Value = (DateTime)dv[0]["Start_Date"];
                dtpEnd.Value = (DateTime)dv[0]["End_Date"];
                tbtDuration.Text = dv[0]["Duration"].ToString();
                tbtChildren.Text = dv[0]["Children"].ToString();
                tbtAdults.Text = dv[0]["Adults"].ToString();
                tbtTotal.Text = dv[0]["Total_Cost"].ToString();

                if (dv[0]["Disabled"].ToString() == "1")
                {
                    cbDisabled.Checked = true;
                }
                else
                {
                    cbDisabled.Checked = false;
                }
                if (dv[0]["Breakfast"].ToString() == "1")
                {
                    cbBreakfast.Checked = true;

                }
                else
                {
                    cbBreakfast.Checked = false;
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbDisabled_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDisabled.Checked)
            {
                disabled = 1;
            }
            if (!cbDisabled.Checked)
            {
                disabled = 0;
            }

        }

        private void cbBreakfast_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (cbBreakfast.Checked)
                {
                    breakfast = 1;
                }
                if (!cbBreakfast.Checked)
                {
                    breakfast = 0;
                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection Conn = new SQLiteConnection(conString))
                {
                    string updates = @"Update Booking SET Staff_ID= @Staffs, Guest_ID = @Guests, Room_No = @RoomNO, Start_Date = @Starts, 
                    End_Date = @Ends, Duration = @Period, Children = @Child, Adults = @Adult, Disabled = @Disableds, Breakfast = @Breakfasts, Total_Cost = @Amount)
                    WHERE Booking_Ref_No = @ID";
                    Conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(updates, Conn))
                    {
                        //cmd.CommandText = "INSERT INTO Guests (Customer_ID, Booking_Ref_No, Name, Address, Postcode, Mobile, Email, Num_of_Guests) VALUES (@id, @ref, @fullname, @addr, @post, @mobilenum, @emails, @guestamount)";
                        cmd.Parameters.AddWithValue("Staffs", dbRole.Role);
                        cmd.Parameters.AddWithValue("Guests", tbtGuestID.Text);
                        cmd.Parameters.AddWithValue("RoomNO", tbtRoomNo.Text);//
                        cmd.Parameters.AddWithValue("Starts", dtpStart.Value.ToString("yyyy-mm-dd"));
                        cmd.Parameters.AddWithValue("Ends", dtpEnd.Value.ToString("yyyy-mm-dd"));
                        cmd.Parameters.AddWithValue("Period", tbtDuration.Text);
                        cmd.Parameters.AddWithValue("Child", tbtChildren.Text);
                        cmd.Parameters.AddWithValue("Adult", tbtAdults.Text);
                        cmd.Parameters.AddWithValue("Disableds", disabled);
                        cmd.Parameters.AddWithValue("Breakfast", breakfast);
                        cmd.Parameters.AddWithValue("Amount", tbtTotal.Text);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection Conn = new SQLiteConnection(conString))
                {
                    string Delete = "DELETE FROM Booking WHERE Booking_Ref_No = @ID";
                    Conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(Delete, Conn))
                    {
                        cmd.Parameters.AddWithValue("Staffs", dbRole.Role);
                        cmd.ExecuteNonQuery();
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
