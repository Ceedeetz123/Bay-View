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
    public partial class Form3 : Form
    {
        public Form3(string instring)
        {
            InitializeComponent();
            conString = instring;
        }
        string conString;


        DataTable dtGuestID = new DataTable(); //For the Guest ID Combobox.
        DataTable dtData = new DataTable(); //For the Guest ID Combobox.
        string insert = "INSERT INTO Guests (Guest_ID, First_Name,Last_Name, Address,Post_Code, Mobile, Email, Num_of_Guests) VALUES (@id, @ref, @firstname, @lastname, @addr, @post, @mobilenum, @emails, @guestamount)";
        string edit = "Update Guests SET First_Name = @firstname, Last_Name = @lastname, Address = @addr, Post_Code = @post, Mobile = @mobilenum, Email = @emails, Num_of_Guests = @guestamount WHERE Guest_ID = @id";
        string delete = "DELETE FROM Guests WHERE Guest_ID =";
        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {

                using (SQLiteConnection Conn = new SQLiteConnection(conString))
                {
                    //string ID = "SELECT ltrim(Guest_ID,'CI') as new from Guests order by CAST(new as INT)"; //For the Guest ID Combobox 
                    //string Datas = "SELECT *, ltrim(Guest_ID,'CI') as new from Guests order by CAST(new as INT);";
                    string ID = "SELECT Guest_ID, First_Name, Last_Name from Guests"; //For the Guest ID Combobox
                    string Datas = "SELECT * FROM Guests";


                    //Sets a connection between the SQL code and the Database for the Guest ID combobox.
                    using (SQLiteDataAdapter daGuestID = new SQLiteDataAdapter(ID, Conn))
                    {
                        daGuestID.Fill(dtGuestID);
                    }
                    using (SQLiteDataAdapter daData = new SQLiteDataAdapter(Datas, Conn))
                    {
                        daData.Fill(dtData);
                    }
                            cbCustID.DataSource = dtGuestID;
                            cbCustID.ValueMember = "Guest_ID";//Gets the value of the Guest_ID
                            cbCustID.DisplayMember = "Guest_ID";//Displays Guest ID's only in the combobox 
                            cbCustID.SelectedIndex = 0; //Displays the first record

                            //while(dtData.Rows.Count>0)
                            // {
                            //tbtCustomerID.Text = dtData.Rows[0]["Guest_ID"].ToString();
                            //tbtBookRefNo.Text = dtData.Rows[0]["Booking_Ref_No"].ToString();
                            //tbtName.Text = dtData.Rows[0]["Name"].ToString();
                            //tbtAddress.Text = dtData.Rows[0]["Address"].ToString();
                            //tbtPostCode.Text = dtData.Rows[0]["Postcode"].ToString();
                            //tbtMobile.Text = dtData.Rows[0]["Mobile"].ToString();
                            //tbtEmail.Text = dtData.Rows[0]["Email"].ToString();
                            //tbtNumOfGuests.Text = dtData.Rows[0]["Num_Of_Guests"].ToString();
                            // }
                     

                 }

             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //using (SQLiteConnection Conn = new SQLiteConnection(conString))
                //{
                    DataView dv = dtData.DefaultView; //Uses Text
                    
                        dv.RowFilter = "CONVERT(Guest_ID, 'System.String') LIKE '%" + cbCustID.SelectedValue.ToString() + "%'";
                        //dv.RowFilter = string.Format("Customer_ID = " + cbCustID.SelectedIndex.ToString());
                        tbtGuestID.Text = dv[0]["Guest_ID"].ToString();
                        tbtFirst.Text = dv[0]["First_Name"].ToString();
                        tbtLast.Text = dv[0]["Last_Name"].ToString();
                        tbtAddress.Text = dv[0]["Address"].ToString();
                        tbtPostCode.Text = dv[0]["Post_Code"].ToString();
                        tbtMobile.Text = dv[0]["Mobile"].ToString();
                        tbtEmail.Text = dv[0]["Email"].ToString();
                        tbtNumOfGuests.Text = dv[0]["Num_Of_Guests"].ToString();
                  

                //}
            }
            

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {

            tbtGuestID.Text = String.Empty; //auto fill customer ID field with a new value?
            tbtFirst.Text = String.Empty;
            tbtAddress.Text = String.Empty;
            tbtPostCode.Text = String.Empty;
            tbtMobile.Text = String.Empty;
            tbtEmail.Text = String.Empty;
            tbtNumOfGuests.Text = String.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection Conn = new SQLiteConnection(conString))
                {
                    Conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(insert, Conn))
                    {
                        //cmd.CommandText = "INSERT INTO Guests (Customer_ID, Booking_Ref_No, Name, Address, Postcode, Mobile, Email, Num_of_Guests) VALUES (@id, @ref, @fullname, @addr, @post, @mobilenum, @emails, @guestamount)";
                        cmd.Parameters.AddWithValue("id", tbtGuestID.Text);
                        cmd.Parameters.AddWithValue("firstname", tbtFirst.Text);
                        cmd.Parameters.AddWithValue("lastname", tbtLast.Text);
                        cmd.Parameters.AddWithValue("addr", tbtAddress.Text);
                        cmd.Parameters.AddWithValue("post", tbtPostCode.Text);
                        cmd.Parameters.AddWithValue("mobilenum", tbtMobile.Text);
                        cmd.Parameters.AddWithValue("emails", tbtEmail.Text);
                        cmd.Parameters.AddWithValue("guestamount", tbtNumOfGuests.Text);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection Conn = new SQLiteConnection(conString))
                {
                    Conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(edit, Conn))
                    {
                        cmd.Parameters.AddWithValue("@id", tbtGuestID.Text);
                        cmd.Parameters.AddWithValue("@firstname", tbtFirst.Text);
                        cmd.Parameters.AddWithValue("@lastname", tbtLast.Text);
                        cmd.Parameters.AddWithValue("@addr", tbtAddress.Text);
                        cmd.Parameters.AddWithValue("@post", tbtPostCode.Text);
                        cmd.Parameters.AddWithValue("@mobilenum", tbtMobile.Text);
                        cmd.Parameters.AddWithValue("@emails", tbtEmail.Text);
                        cmd.Parameters.AddWithValue("@guestamount", tbtNumOfGuests.Text);
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
        private void cbCustID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //using (SQLiteConnection Conn = new SQLiteConnection(conString))
                //{
                    DataView dv = dtData.DefaultView;
                    
                        dv.RowFilter = "CONVERT(Guest_ID, 'System.String') LIKE '%" + cbCustID.Text.ToString() + "%'";

                        tbtGuestID.Text = dv[0]["Guest_ID"].ToString();
                        tbtFirst.Text = dv[0]["First_Name"].ToString();
                        tbtLast.Text = dv[0]["Last_Name"].ToString();
                        tbtAddress.Text = dv[0]["Address"].ToString();
                        tbtPostCode.Text = dv[0]["Post_Code"].ToString();
                        tbtMobile.Text = dv[0]["Mobile"].ToString();
                        tbtEmail.Text = dv[0]["Email"].ToString();
                        tbtNumOfGuests.Text = dv[0]["Num_Of_Guests"].ToString();
                    
                //}
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //always triggers when it has found no records
            }
        }

    

     
        //When the user presses the enter key they will be able to fill the customer field depending on what they typed
        private void cbCustID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbCustID_TextChanged(this, new EventArgs());
            }
        }
    }
    }
