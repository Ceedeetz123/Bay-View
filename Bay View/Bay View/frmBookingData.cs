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
    public partial class frmBookingData : Form
    {
        public frmBookingData(string inString)
        {
            InitializeComponent();
            conString = inString;
        }
        string conString = dbConns.dbSource;

        DataTable dtbookings = new DataTable();

        string booking = "select * from Booking";

        private void frmBookingData_Load(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection Conn = new SQLiteConnection(conString)) //Connection Object for linking the database
                {
                    using (SQLiteDataAdapter daBookings = new SQLiteDataAdapter(booking, Conn))
                    {
                        daBookings.Fill(dtbookings);
                        dataGridView1.DataSource = dtbookings;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
