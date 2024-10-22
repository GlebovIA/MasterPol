using MasterPol.Classes;
using MasterPol.Model;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows;

namespace MasterPol.Contexts
{
    public class PartnersProductsContext
    {
        public static List<PartnerProductsModel> AllPartnerTypes()
        {
            try
            {
                List<PartnerProductsModel> AllPartnersProducts = new List<PartnerProductsModel>();
                DbConnection.CreateConnection();
                MySqlDataReader reader = DbConnection.Query(Queries.GetPartnersProducts);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        PartnerProductsModel type = new PartnerProductsModel()
                        {
                            id = reader.GetInt32(0),
                            name = reader.GetString(1)
                        };
                        AllPartnersProducts.Add(type);
                    }
                }
                else
                {
                    MessageBox.Show("Таблица была пуста", "Уведомление");
                }
                return AllPartnersProducts;
            }
            catch
            {
                MessageBox.Show("Непредвиденная ошибка", "Уведомление");
                return null;
            }
        }
    }
}
