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
    public partial class Customers : Form
    {
        public Customers(string instring)
        {
            InitializeComponent();
            conString = instring;
        }
        string conString;


        DataTable dtCustomerID = new DataTable(); //For the customer ID Combobox.
        DataTable dtData = new DataTable(); //For the customer ID Combobox.
        string insert = "INSERT INTO Guests (Customer_ID, Booking_Ref_No, Name, Address, Postcode, Mobile, Email, Num_of_Guests) VALUES (@id, @ref, @fullname, @addr, @post, @mobilenum, @emails, @guestamount)";
        string edit = "Update Guests SET Booking_Ref_No = @ref, Name = @fullname, Address = @addr, Postcode = @post, Mobile = @mobilenum, Email = @emails, Num_of_Guests = @guestamount WHERE Customer_ID = @id";
        string delete = "DELETE FROM Guests WHERE Customer_ID =";
        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {

                using (SQLiteConnection Conn = new SQLiteConnection(conString))
                {
                    //string ID = "SELECT ltrim(Customer_ID,'CI') as new from Guests order by CAST(new as INT)"; //For the customer ID Combobox 
                    //string Datas = "SELECT *, ltrim(Customer_ID,'CI') as new from Guests order by CAST(new as INT);";
                    string ID = "SELECT Customer_ID, Name from Guests"; //For the customer ID Combobox
                    string Datas = "SELECT * FROM Guests";


                    //Sets a connection between the SQL code and the Database for the Customer ID combobox.
                    using (SQLiteDataAdapter daCustomerID = new SQLiteDataAdapter(ID, Conn))
                    {
                        daCustomerID.Fill(dtCustomerID);
                    }
                    using (SQLiteDataAdapter daData = new SQLiteDataAdapter(Datas, Conn))
                    {
                        daData.Fill(dtData);
                    }
                            cbCustID.DataSource = dtCustomerID;
                            cbCustID.ValueMember = "Customer_ID";//Gets the value of the Customer_ID
                            cbCustID.DisplayMember = "Customer_ID";//Displays Customer ID's only in the combobox 
                            cbCustID.SelectedIndex = 0; //Displays the first record

                            //while(dtData.Rows.Count>0)
                            // {
                            //tbtCustomerID.Text = dtData.Rows[0]["Customer_ID"].ToString();
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
                    
                        dv.RowFilter = "CONVERT(Customer_ID, 'System.String') LIKE '%" + cbCustID.SelectedValue.ToString() + "%'";
                        //dv.RowFilter = string.Format("Customer_ID = " + cbCustID.SelectedIndex.ToString());                        
                        tbtName.Text = dv[0]["Name"].ToString();
                        tbtAddress.Text = dv[0]["Address"].ToString();
                        tbtPostCode.Text = dv[0]["Postcode"].ToString();
                        tbtMobile.Text = dv[0]["Mobile"].ToString();
                        tbtEmail.Text = dv[0]["Email"].ToString();
                  

                //}
            }
            

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            
            tbtName.Text = String.Empty;
            tbtAddress.Text = String.Empty;
            tbtPostCode.Text = String.Empty;
            tbtMobile.Text = String.Empty;
            tbtEmail.Text = String.Empty;
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
                        
                        cmd.Parameters.AddWithValue("fullname", tbtName.Text);
                        cmd.Parameters.AddWithValue("addr", tbtAddress.Text);
                        cmd.Parameters.AddWithValue("post", tbtPostCode.Text);
                        cmd.Parameters.AddWithValue("mobilenum", tbtMobile.Text);
                        cmd.Parameters.AddWithValue("emails", tbtEmail.Text);
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
                        cmd.Parameters.AddWithValue("@fullname", tbtName.Text);
                        cmd.Parameters.AddWithValue("@addr", tbtAddress.Text);
                        cmd.Parameters.AddWithValue("@post", tbtPostCode.Text);
                        cmd.Parameters.AddWithValue("@mobilenum", tbtMobile.Text);
                        cmd.Parameters.AddWithValue("@emails", tbtEmail.Text);
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
                    
                        dv.RowFilter = "CONVERT(Customer_ID, 'System.String') LIKE '%" + cbCustID.Text.ToString() + "%'";
                
                        tbtName.Text = dv[0]["Name"].ToString();
                        tbtAddress.Text = dv[0]["Address"].ToString();
                        tbtPostCode.Text = dv[0]["Postcode"].ToString();
                        tbtMobile.Text = dv[0]["Mobile"].ToString();
                        tbtEmail.Text = dv[0]["Email"].ToString();
                    
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
