using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
//using System.Data;


namespace GPSys_Desk_APP.Controls
{
    public class ExternDBConnection
    {
        SqlConnection con = new SqlConnection(@"Data Source={0}; Initial Catalog={1}; User ID={2}; Password={3}");
        public static void OpenConnection()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ONZE-HOME-SERVER\ONZEHOMESERVER;Initial Catalog=TestDB;User ID=sa;Password=@123OpenDB");

            con.Open();
        }

        public void CloseConnection()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ONZE-HOME-SERVER\ONZEHOMESERVER;Initial Catalog=TestDB;User ID=sa;Password=@123OpenDB");

            con.Close();
        }
    }
}
