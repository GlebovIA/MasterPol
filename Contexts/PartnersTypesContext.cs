using MasterPol.Classes;
using MasterPol.Model;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows;

namespace MasterPol.Contexts
{
    public class PartnersTypesContext
    {
        public static List<PartnerTypeModel> AllPartnerTypes()
        {
            try
            {
                List<PartnerTypeModel> AllTypes = new List<PartnerTypeModel>();
                DbConnection.CreateConnection();
                MySqlDataReader reader = DbConnection.Query(Queries.GetPartnerTypes);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        PartnerTypeModel type = new PartnerTypeModel()
                        {
                            id = reader.GetInt32(0),
                            name = reader.GetString(1)
                        };
                        AllTypes.Add(type);
                    }
                }
                else
                {
                    MessageBox.Show("Таблица была пуста", "Уведомление");
                }
                return AllTypes;
            }
            catch
            {
                MessageBox.Show("Непредвиденная ошибка", "Уведомление");
                return null;
            }
        }
    }
}
