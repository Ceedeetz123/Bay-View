using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
