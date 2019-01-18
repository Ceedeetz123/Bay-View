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
    public partial class frmLogin : Form
    {
        public frmLogin()
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
                    string sql = "SELECT Staff_ID,Password FROM Staff WHERE Staff_ID = @User AND Password = @Pass"; //SQL code
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, Conn)) //Creates a connection between the sql code and the database connection
                    {
                        cmd.Parameters.AddWithValue("User", tbUsername.Text);//Prevents injection attacks using parameters
                        cmd.Parameters.AddWithValue("Pass", tbPassword.Text);
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
                dbRole.Role = tbUsername.Text;
                string Message = "Successful Login";
                MessageBox.Show(Message);
                frmMenu form5 = new frmMenu(conString); //Sends connection to form 5 to be used for editing Staff details
                form5.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            frmPassword form2 = new frmPassword(conString); //Sends connection to form 2 to be used for editing Staff details
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '*'; //hides Password field
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) //Used in the Username and password Textboxes too
        {
            if (e.KeyCode == Keys.Enter)//when the user presses the enter button
            {
                btnLogin_Click(this, new EventArgs());//calls the login button function
            }
        }
    }
}

