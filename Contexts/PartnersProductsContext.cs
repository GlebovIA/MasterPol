using MasterPol.Classes;
using MasterPol.Model;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows;

namespace MasterPol.Contexts
{
    public class PartnersProductsContext
    {
        public static List<PartnerProductsModel> AllPartnerProducts()
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
                            product = reader.GetInt32(1),
                            partner = reader.GetInt32(2),
                            count = reader.GetInt32(3),
                            dateOfSell = reader.GetDateTime(4)
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
