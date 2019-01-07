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
using System.Configuration;

namespace Bay_View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string conString = dbConns.dbSource;


        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection Conn = new SQLiteConnection(conString)) //Connection Object for linking the database
                {
                    Conn.ConnectionString = conString;
                    Conn.Open();//Database can be edited
                    string sql = "SELECT Staff_ID,Password FROM Staff WHERE Staff_ID = @Username"; //SQL code
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, Conn)) //Creates a connection between the sql code and the database connection
                    {
                        cmd.Parameters.AddWithValue("@Username", tbUsername.Text);//Prevents injection attacks using parameters

                        using (SQLiteDataReader DataRead = cmd.ExecuteReader())
                        {
                            //If there is no records
                            if (!DataRead.HasRows)
                            {
                                MessageBox.Show("Login failed - try again!");
                                return;
                            }
                        }
                    }
                    Conn.Close();
                }
                string Message = "Successful Login";
                MessageBox.Show(Message);
                //Customers form3 = new Customers(conString); //Sends connection to form 3 to be used for editing Staff details
                //form3.ShowDialog();
                btnCustomers.Enabled = true;
                btnBooking.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(conString); //Sends connection to form 2 to be used for editing Staff details
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '*';
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) //Used in the Username and password Textboxes too
        {
            if (e.KeyCode == Keys.Enter)//when the user presses the enter button
            {
                btnLogin_Click(this, new EventArgs());//calls the login button function
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customers frmcustomers = new Customers(conString); 
            frmcustomers.ShowDialog();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            Bookings frmbookings = new Bookings(conString);
            frmbookings.ShowDialog();
        }
    }
}

