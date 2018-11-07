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
        SQLiteConnection Conn = new SQLiteConnection(@"Data Source=F:\University\Year 2\Team InformationSystemDevelopment\Implementation\Database\Bay-View.db");
        //Connection Object for linking the database
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try

            {
                using (SQLiteConnection Conn = new SQLiteConnection())
                {
                    Conn.ConnectionString = @"Data Source=F:\University\Year 2\Team Information System Development\Implementation\Database\Bay-View.db";
                    string sql = "SELECT Staff_ID,Password FROM Staff WHERE Staff_ID= @Username";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, Conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", tbUsername.Text);

                        Conn.Open();
                        using (SQLiteDataReader DataRead = cmd.ExecuteReader())
                        {
                            //If there is no records
                            if (!DataRead.HasRows)
                                MessageBox.Show("No Rows!");
                            //When the password is not correct according to the Database
                            DataRead.Read();
                            if (tbPassword.Text != DataRead[0].ToString())
                                MessageBox.Show("Password Incorrect!");
                            //If username and Password match the record in the database
                            else
                            {
                                string Message = "Successfull Login";
                                MessageBox.Show(Message);
                            }

                            Conn.Close();


                        }
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    



        private void btnConnect_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select SQLite database file";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Filter = "Database files (*.db)|*.db";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
  


            }
        }
    
        private void btnTest_Click(object sender, EventArgs e)
        { 
            try
         {
            Conn.ConnectionString = conString;
            Conn.Open();
         }
            catch (Exception ex)
         {
                if (Conn.State == System.Data.ConnectionState.Open)
                    Conn.Close();
               
                MessageBox.Show(ex.Message);
            }
}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

