using MasterPol.Classes;
using MasterPol.Model;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows;

namespace MasterPol.Contexts
{
    public class ProductTypesContext
    {
        public static List<ProductTypeModel> AllProductsTypes()
        {
            try
            {
                List<ProductTypeModel> AllTypes = new List<ProductTypeModel>();
                DbConnection.CreateConnection();
                MySqlDataReader reader = DbConnection.Query(Queries.GetProductTypes);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ProductTypeModel type = new ProductTypeModel()
                        {
                            id = reader.GetInt32(0),
                            name = reader.GetString(1),
                            coefficient = reader.GetFloat(2)
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
