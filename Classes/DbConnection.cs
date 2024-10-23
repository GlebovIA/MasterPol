using MySql.Data.MySqlClient;
using System.Data;
using System.Windows;

namespace MasterPol.Classes
{
    public class DbConnection
    {
        public static string ConnectionString = "server=127.0.0.1;port=3306;database=MasterPol;user=root;pwd=;";
        public static MySqlConnection Connection { get; set; }
        public static MySqlConnection CreateConnection()
        {
            try
            {
                if (Connection == null)
                {
                    Connection = new MySqlConnection(ConnectionString);
                }
                RestarConnection();
                return Connection;
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так");
                (Application.Current.MainWindow as MainWindow).Close();
                return null;
            }
        }
        public static void RestarConnection()
        {
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
            Connection.Open();
        }
        public static void CloseConnection()
        {
            Connection.Close();
        }
        public static MySqlDataReader Query(string sql)
        {
            return new MySqlCommand(sql, Connection).ExecuteReader();
        }
    }
}
