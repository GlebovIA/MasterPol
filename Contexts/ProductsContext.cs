using MasterPol.Classes;
using MasterPol.Model;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows;

namespace MasterPol.Contexts
{
    public class ProductsContext
    {
        public static List<ProductsModel> AllProducts()
        {
            try
            {
                List<ProductsModel> AllTypes = new List<ProductsModel>();
                DbConnection.CreateConnection();
                MySqlDataReader reader = DbConnection.Query(Queries.GetProducts);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ProductsModel type = new ProductsModel()
                        {
                            id = reader.GetInt32(0),
                            article = reader.GetInt32(1),
                            type = reader.GetInt32(2),
                            name = reader.GetString(3),
                            description = reader.GetString(4),
                            minCost = reader.GetInt32(5),
                            massNetto = reader.GetInt32(6),
                            massBrutto = reader.GetInt32(7),
                            productionTime = reader.GetInt32(8),
                            realCost = reader.GetInt32(9),
                            workshopNumber = reader.GetInt32(10),
                            countOfWorkers = reader.GetInt32(11),
                            material = reader.GetString(12)
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
