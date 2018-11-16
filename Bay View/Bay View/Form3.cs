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

        DataTable dtCustomerID = new DataTable(); //For the customer ID Combobox.


        private void Form3_Load(object sender, EventArgs e)
        {
                try
                {
                    
                    using (SQLiteConnection Conn = new SQLiteConnection(conString))
                    {
                        string ID = "SELECT * from Guests"; //For the customer ID Combobox
                        //Sets a connection between the SQL code and the Database for the Customer ID combobox.
                        daCustomerID = new SQLiteDataAdapter(ID, Conn);
                       cbCustID.DataSource = dtCustomerID;
                       daCustomerID.Fill(dtCustomerID);
                       cbCustID.ValueMember = "Customer_ID";
                       cbCustID.DisplayMember = "name";
                        cbCustID.SelectedIndex = -1;
                        dataGridView1.DataSource = dtCustomerID;
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
                    DataView dv = dtCustomerID.DefaultView;
                    dv.RowFilter = string.Format("Customer_ID LIKE '%{0}%'",cbCustID.SelectedValue.ToString());

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
                //MessageBox.Show(ex.Message);
           }
        }
    }
}
