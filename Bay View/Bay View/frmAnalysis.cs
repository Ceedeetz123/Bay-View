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
    public partial class frmAnalysis : Form
    {
        public frmAnalysis(string inString)
        {
            InitializeComponent();
            conString = inString;
            
        }
        string conString = dbConns.dbSource;


        private void btnRooms_Click(object sender, EventArgs e)
        {
            frmRoomOccupancy rooms = new frmRoomOccupancy(conString);
            this.Hide();
            rooms.ShowDialog();
            this.Show();
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            frmYearCost year = new frmYearCost(conString);
            this.Hide();
            year.ShowDialog();
            this.Show();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            frmOccupancyTypes types = new frmOccupancyTypes(conString);
            this.Hide();
            types.ShowDialog();
            this.Show();    

            
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            frmBookingData data = new frmBookingData(conString);
            this.Hide();
            data.ShowDialog();
            this.Show();
        }

        private void frmAnalysis_Load(object sender, EventArgs e)
        {

        }
    }
}
