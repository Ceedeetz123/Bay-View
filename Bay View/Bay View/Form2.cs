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

        SQLiteDataAdapter daSTaff; //Used to communicate with the database

        DataTable dtStaff = new DataTable(); //Used for storing all staff details in a table
    }
}
