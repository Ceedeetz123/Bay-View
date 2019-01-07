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
    public partial class Bookings : Form
    {
        public Bookings()
        {
            InitializeComponent();
        }

        string conString = dbConns.dbSource;

        private void btnBooking_Click(object sender, EventArgs e)
        {
            Place_a_Booking frmBooking = new Place_a_Booking(conString);
            frmBooking.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Customers frmcustomers = new Customers(conString);
            frmcustomers.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Customers frmcustomers = new Customers(conString);
            //frmcustomers.ShowDialog();
        }
    }
}
