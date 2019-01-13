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
    public partial class Form5 : Form
    {
        public Form5(string instring)
        {
            InitializeComponent();
            conString = instring;
        }

        string conString = dbConns.dbSource;
        string Roles = dbRole.Role;
        private void lblBooking_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(conString); //Sends connection to form 4 to be used for editing Staff details
            this.Hide();
            form4.ShowDialog();
            this.Show();
        }

        private void btnGuests_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(conString); //Sends connection to form 3 to be used for editing Staff details
            this.Hide();
            form3.ShowDialog();
            this.Show();
        }
        private void Form5_Load(object sender, EventArgs e)
        {


            try
            {
                using (SQLiteConnection Conn = new SQLiteConnection(conString)) //Connection Object for linking the database
                {
                    Conn.ConnectionString = conString;
                    Conn.Open();//Database can be edited
                    string role = "SELECT Role From Staff WHERE Staff_ID = @Name"; //SQL code to find the staff's role
                    using (SQLiteCommand cmd = new SQLiteCommand(role, Conn)) //Creates a connection between the sql code and the database connection
                    {
                        cmd.Parameters.AddWithValue("Name", Roles);//Prevents injection attacks using parameters and allows input to be entered into the sql string
                        Roles = (string)cmd.ExecuteScalar(); //executes the sql code to find the staffs role from the staff's ID which is then stored in the 'Roles' variable
                        lblRole.Text = "You are: " + Roles;
                        if (Roles == "Staff")
                        {
                            btnAnalysis.Visible = false;
                        }
                        else
                        {
                            btnAnalysis.Visible= true;
                        }
                    }
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditBookings_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(conString); //Sends connection to form 6 to be used for editing booking details
            this.Hide();
            form6.ShowDialog();
            this.Show();
        }


    }
}
