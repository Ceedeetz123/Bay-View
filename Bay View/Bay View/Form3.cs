﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3(string instring)
        {
            InitializeComponent();
            instring = dbConns.dbSource;
            conString = instring;
        }
        string conString;

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
