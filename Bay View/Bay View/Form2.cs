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

        SQLiteConnection Conn;

        SQLiteDataAdapter daStaff; //Used to communicate with the database

        DataTable dtStaff = new DataTable(); //Used for storing all staff details in a table

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                //Uses the database connection
                using (Conn = new SQLiteConnection(conString))
                {
                    Conn.ConnectionString = conString;
                    string sql = "SELECT Staff_ID,Password FROM Staff WHERE Staff_ID = @Username"; 

                    daStaff = new SQLiteDataAdapter(sql, Conn);
                    daStaff.Fill(dtStaff);

                    dataGridView1.DataSource = dtStaff;

                    //Conn.Open();
                    //int recordsChanged = cmd.ExecuteNonQuery();
                    //MessageBox.Show(recordsChanged.ToString() + " records modified");

                }
              
            }
    
            catch (Exception ex)
            {
        
            }

        }

        private void tbtStaffID_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dtStaff.DefaultView;

          
           dv.RowFilter = string.Format("Staff_ID like '%{1}%'" + tbtStaffID.Text);
           dataGridView1.DataSource = dv;
    
            
           
    }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                using (Conn = new SQLiteConnection(conString))
                {
                    Conn.Open();
                    Conn.ConnectionString = conString;
                    string sql = "SELECT Staff_ID,Password FROM Staff WHERE Staff_ID = @Username";


                    using (SQLiteCommand cmd = new SQLiteCommand()) //Creates a connection between the sql code and the database connection
                    {
                        cmd.CommandText = @"UPDATE Password SET Staff_ID = @Username"
                                                         + " WHERE Password = @Security";//SQL code for selecting Staff ID'S in the Data Table

                        cmd.Parameters.AddWithValue("@Security", tbtPassword.Text);//Prevents injection attacks using parameters

                        cmd.ExecuteNonQuery();
                        Conn.Close();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtStaff.Columns.Add("@Username", typeof(string));
            dtStaff.Columns.Add("@Security", typeof(string));

            dataGridView1.DataSource = dtStaff;

        }
    }
}
