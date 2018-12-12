using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Bay_View
{
    class dbConns
    {
        public static string

        //dbSource = @"Data Source={AppDir}\Bay-View.db";
        dbSource = ConfigurationManager.ConnectionStrings["Bay-View"].ConnectionString;
    }
}
