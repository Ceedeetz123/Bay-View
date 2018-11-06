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
        SQLiteConnection Conn = new SQLiteConnection(dbConns.Source);
        //Connection Object for linking the database
        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection Conn = new SQLiteConnection())
            {
                Conn.ConnectionString = dbConns.Source;
                string sql = "SELECT Password, FROM staff WHERE Staff_ID=@Username,";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, Conn))
                {
                    cmd.Parameters.AddWithValue("Username", tbUsername);
                    Conn.Open();
                    using (SQLiteDataReader DataRead = cmd.ExecuteReader())
                    {
                        if (!DataRead.HasRows)
                            throw new Exception();
                        //When the password is not correct according to the Database
                        DataRead.Read();
                        if (tbPassword.Text != DataRead[0].ToString())
                            throw new Exception();
                        //If username and Password match the record in the database
                        string Message = "Successfull Login";
                        MessageBox.Show(Message);
                        Conn.Close();


                    }

                }
            }

        }

    }
}

