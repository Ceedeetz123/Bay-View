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
    public partial class Form2 : Form
    {
        public Form2(string instring)
        {
            InitializeComponent();
            conString = instring;
        }
        string conString;

        //SQLiteConnection Conn = new SQLiteConnection(dbConns.dbSource);
        SQLiteDataAdapter daStaff; //Used to communicate with the database

        DataTable dtStaff = new DataTable(); //Used for storing all staff details in a table

        string sql = "SELECT Staff_ID,Password FROM Staff";

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {

                using (SQLiteConnection Conn = new SQLiteConnection(conString))
                {

                    daStaff = new SQLiteDataAdapter(sql, Conn);
                    //dataGridView1.DataSource = dtStaff;
                    daStaff.Fill(dtStaff);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //used for reports or other feature 
        //private void tbtStaffID_TextChanged(object sender, EventArgs e)
       // {
           // DataView dv = dtStaff.DefaultView;

           // try
           // {
                //dv.RowFilter = string.Format("Staff_ID like '%{0}%'",tbtStaffID.Text);
                //dataGridView1.DataSource = dv.ToTable();
  
            //}
            //catch(Exception ex)
            //{
               // MessageBox.Show(ex.Message);
          //  }           
   // }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection Conn = new SQLiteConnection(conString))
                {
                    Conn.Open();
                    string select = @"SELECT Staff_ID,Password FROM Staff 
                    WHERE Staff_ID = @User and 
                    Password = @OldPass and
                    Email = @emessage";
                    string update = @"Update Staff SET Password = @NewPass WHERE Staff_ID = @User"; //update sql command
                    using (SQLiteCommand selects = new SQLiteCommand(select, Conn))
                    {
                        //cmd.CommandText = @"Update Staff SET Password = @Passes WHERE Staff_ID = @Username" ; //update sql command

                        selects.Parameters.AddWithValue("User", tbtStaffID.Text);
                        selects.Parameters.AddWithValue("OldPass", tbtOldPass.Text);
                        selects.Parameters.AddWithValue("emessage", tbtEmail.Text);

                        using (SQLiteDataReader DataRead = selects.ExecuteReader())
                        {
                            //If there is no records
                            if (!DataRead.HasRows)
                            {
                                MessageBox.Show("Wrong Details!");
                                return;

                            }
                           
                        }
                        using (SQLiteCommand updates = new SQLiteCommand(update, Conn))
                        {
                            updates.Parameters.AddWithValue("User", tbtStaffID.Text);
                            updates.Parameters.AddWithValue("NewPass", tbtNewPass.Text); 
                            updates.ExecuteNonQuery();
                        }

                    }
                    
                    Conn.Close();
                    Conn.Dispose();
                }
                //int UpdatedRow= cmd.ExecuteNonQuery();
                MessageBox.Show(" Your Password Have been updated");

                this.Close();
                this.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //closes and disposes anything in the form that
            this.Close();
            this.Dispose();
        }

        private void tbtPassword_TextChanged(object sender, EventArgs e)
        {

            tbtNewPass.PasswordChar = '*';//hides the password text
        }
        //when the user presses enter it triggers the submit button event to reset the password
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)//when the user presses the enter button
            {
                btnSubmit_Click(this, new EventArgs());//calls the submit button function
            }
        }
    }
}
