using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreREC
{
    public class MyConnection
    {
        public SqlConnection conn;

        public MyConnection()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CC"].ConnectionString);
        }

        
        public static string type;
    }
}
