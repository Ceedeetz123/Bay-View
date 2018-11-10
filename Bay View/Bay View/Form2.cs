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
        public Form2(String inString)
        {
            InitializeComponent();
            conString = inString; //Uses the connection in this form
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

                //Uses the database connection


                daStaff = new SQLiteDataAdapter(sql, Conn);
                dataGridView1.DataSource = dtStaff;
                daStaff.Fill(dtStaff);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void tbtStaffID_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dtStaff.DefaultView;

            try
            {
                dv.RowFilter = string.Format("Staff_ID like '%{0}%'",tbtStaffID.Text);
                dataGridView1.DataSource = dv.ToTable();
  
            }
            catch(Exception ex)
            {

            }           
    }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection Conn = new SQLiteConnection(dbConns.dbSource))
                {
                    using (SQLiteCommand cmd = Conn.CreateCommand())
                    {
                        cmd.CommandText = @"Update Staff SET Password = @Password  LIMIT 1";
                        cmd.Parameters.AddWithValue("Password", Convert.ToInt32(tbtPassword.Text));
                        Conn.Open();
                        int recordsChanged = cmd.ExecuteNonQuery();
                        MessageBox.Show(recordsChanged.ToString() + " records Updated");
                        
                        Conn.Close();
                        Conn.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
