using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace prjVoorbereidingExamenSem2.Helper
{
    public class Database
    {
        public static MySqlConnection MaakVerbinding()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

            builder.Server = "localhost";
            builder.Database = "login";
            builder.UserID = "root";
            builder.Password = "usbw";
            builder.ConnectionTimeout = 60;
            builder.Port = 3307;
            builder.AllowZeroDateTime = true;

            MySqlConnection conn = new MySqlConnection(builder.ToString());
            conn.Open();

            return conn;
        }
    }
}
