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
    public partial class Place_a_Booking : Form
    {
        public Place_a_Booking()
        {
            InitializeComponent();
        }
        string conString = dbConns.dbSource;


    }
}
