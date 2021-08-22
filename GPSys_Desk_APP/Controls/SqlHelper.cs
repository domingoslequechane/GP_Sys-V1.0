using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GPSys_Desk_APP.Controls
{
    public class SqlHelper
    {
        SqlConnection con;

        public SqlHelper(string connectionString)
        {
            con = new SqlConnection(connectionString);
        }

        public bool IsConnection
        {
            get
            {
                if (con.State == System.Data.ConnectionState.Closed)
                    con.Open();
                return true;
            }
        }
    }
}
