using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterPol.Classes
{
    public class DbConnection
    {
        public static string ConnectionString = "server=127.0.0.1;port=3307;database=MasterPol;user=root;pwd=;";
        public static MySqlConnection Connection { get; set; }
        public MySqlConnection OpenConnection()
        {
            Connection = new MySqlConnection(ConnectionString);
            Connection.Open();
            return Connection;
        }
    }
}
