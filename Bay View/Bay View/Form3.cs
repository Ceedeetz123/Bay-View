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

        SQLiteDataAdapter daCustomerID; //For the customer ID combobox.
        SQLiteDataAdapter daData; //For the Text Field combobox.


        DataTable dtCustomerID = new DataTable(); //For the customer ID Combobox.
        DataTable dtData = new DataTable(); //For the customer ID Combobox.


        private void Form3_Load(object sender, EventArgs e)
        {
                try
                {
                    
                    using (SQLiteConnection Conn = new SQLiteConnection(conString))
                    {
                       string ID = "SELECT Customer_ID, Name from Guests"; //For the customer ID Combobox
                       string Datas = "SELECT * FROM Guests";
                       
                       //Sets a connection between the SQL code and the Database for the Customer ID combobox.
                       daCustomerID = new SQLiteDataAdapter(ID, Conn);

                      daCustomerID.Fill(dtCustomerID);
                      daData = new SQLiteDataAdapter(Datas, Conn);
                      daData.Fill(dtData);
                      cbCustID.DataSource = dtCustomerID;
                      cbCustID.ValueMember = "Customer_ID";//The 
                      cbCustID.DisplayMember = "Customer_ID";//Displays Customer ID's only in the combobox 
                      cbCustID.SelectedIndex = 0; //Displays the first record
                      
                    }
                
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection Conn = new SQLiteConnection(conString))
                {
                    DataView dv = dtData.DefaultView; //Uses Text
                    dv.RowFilter = "CONVERT(Customer_ID, 'System.String') LIKE '%" + cbCustID.SelectedIndex.ToString() + "%'";

                    tbtCustomerID.Text = dv[0]["Customer_ID"].ToString();
                    tbtBookRefNo.Text = dv[0]["Booking_Ref_No"].ToString();
                    tbtName.Text = dv[0]["Name"].ToString();
                    tbtAddress.Text = dv[0]["Address"].ToString();
                    tbtPostCode.Text = dv[0]["Postcode"].ToString();
                    tbtMobile.Text = dv[0]["Mobile"].ToString();
                    tbtEmail.Text = dv[0]["Email"].ToString();
                    tbtNumOfGuests.Text = dv[0]["Num_Of_Guests"].ToString();
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
                using (SQLiteConnection Conn = new SQLiteConnection(conString))
                {
                    DataView dv = dtData.DefaultView; //Uses Text
                    dv.RowFilter = "CONVERT(Customer_ID, 'System.String') LIKE '%" + cbCustID.Text.ToString() + "%'";

                    tbtCustomerID.Text = dv[0]["Customer_ID"].ToString();
                    tbtBookRefNo.Text = dv[0]["Booking_Ref_No"].ToString();
                    tbtName.Text = dv[0]["Name"].ToString();
                    tbtAddress.Text = dv[0]["Address"].ToString();
                    tbtPostCode.Text = dv[0]["Postcode"].ToString();
                    tbtMobile.Text = dv[0]["Mobile"].ToString();
                    tbtEmail.Text = dv[0]["Email"].ToString();
                    tbtNumOfGuests.Text = dv[0]["Num_Of_Guests"].ToString();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //always triggers when it has found no records
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {

            tbtCustomerID.Text = String.Empty; //auto fill customer ID field with a new value?
            tbtBookRefNo.Text = String.Empty;
            tbtName.Text = String.Empty;
            tbtAddress.Text = String.Empty;
            tbtPostCode.Text = String.Empty;
            tbtMobile.Text = String.Empty;
            tbtEmail.Text = String.Empty;
            tbtNumOfGuests.Text = String.Empty;
        }

    }
}
