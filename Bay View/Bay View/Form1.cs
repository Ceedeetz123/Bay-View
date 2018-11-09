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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string conString;
        SQLiteConnection Conn = new SQLiteConnection(dbConns.dbSource);
        //Connection Object for linking the database
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try

            {
                using (SQLiteConnection Conn = new SQLiteConnection())
                {
                    Conn.ConnectionString = dbConns.dbSource;
                    string sql = "SELECT Staff_ID,Password FROM Staff WHERE Staff_ID = @Username"; //SQL code
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, Conn)) //Creates a connection between the sql code and the database connection
                    {
                        cmd.Parameters.AddWithValue("@Username", tbUsername.Text);//Prevents injection attacks using parameters

                        Conn.Open();//Database can be edited
                        using (SQLiteDataReader DataRead = cmd.ExecuteReader())
                        {
                            //If there is no records
                            if (!DataRead.HasRows)
                                MessageBox.Show("No Rows!");
                            //When the password is not correct according to the Database
                            DataRead.Read();
                            if (tbPassword.Text != DataRead[1].ToString())
                                MessageBox.Show("Password Incorrect!");
                            //If username and Password match the record in the database
                            else
                            {
                                string Message = "Successfull Login";
                                MessageBox.Show(Message);
                            }

                            Conn.Close();//Closes the database for editing


                        }
                    }
                }

            }
            catch (Exception ex)
            {
        
           
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(conString); //Sends connection to form 2 to be used for editing Staff details
            form2.ShowDialog();
        }
    }
}

