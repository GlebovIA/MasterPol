using MasterPol.Classes;
using MasterPol.Model;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows;

namespace MasterPol.Contexts
{
    public class PartnersContext
    {
        public static List<PartnersModel> AllPartners()
        {
            try
            {
                List<PartnersModel> AllPartners = new List<PartnersModel>();
                DbConnection.CreateConnection();
                MySqlDataReader reader = DbConnection.Query(Queries.GetPartners);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        PartnersModel type = new PartnersModel()
                        {
                            id = reader.GetInt32(0),
                            type = reader.GetInt32(1),
                            name = reader.GetString(2),
                            juridicalAddress = reader.GetString(3),
                            inn = reader.GetInt64(4),
                            directorFio = reader.GetString(5),
                            phone = reader.GetInt32(6),
                            email = reader.GetString(7),
                            rating = reader.GetInt32(8),
                            historyOfImplementation = reader.GetString(9)
                        };
                        AllPartners.Add(type);
                    }
                }
                else
                {
                    MessageBox.Show("Таблица была пуста", "Уведомление");
                }
                return AllPartners;
            }
            catch
            {
                MessageBox.Show("Непредвиденная ошибка", "Уведомление");
                return null;
            }
        }
    }
}
