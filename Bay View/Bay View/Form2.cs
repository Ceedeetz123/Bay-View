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
            instring = dbConns.dbSource;
            conString = instring;
        }
        string conString;

        SQLiteConnection Conn = new SQLiteConnection(dbConns.dbSource);
        SQLiteDataAdapter daStaff; //Used to communicate with the database

        DataTable dtStaff = new DataTable(); //Used for storing all staff details in a table

        string sql = "SELECT Staff_ID,Password FROM Staff";

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                //Possible security problem for sql injections
                //Cant use using connection in this section 


                daStaff = new SQLiteDataAdapter(sql, Conn);
                //dataGridView1.DataSource = dtStaff;
                daStaff.Fill(dtStaff);


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
                    using (SQLiteCommand cmd = Conn.CreateCommand())
                    {
                        cmd.CommandText = @"Update Staff SET Password = @Password  WHERE Staff_ID = @id ";
                        cmd.Parameters.AddWithValue("id", tbtStaffID.Text);
                        cmd.Parameters.AddWithValue("Password", tbtPassword.Text);
                        Conn.Open();
                        int UpdatedRow= cmd.ExecuteNonQuery();
                        MessageBox.Show( " Your Password Have been updated");
                        
                        Conn.Close();
                        Conn.Dispose();
                        this.Close();
                        this.Dispose();
                    }
                }
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

            tbtPassword.PasswordChar = '*';
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSubmit_Click(this, new EventArgs());
            }
        }
    }
}
