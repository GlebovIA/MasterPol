using MasterPol.Classes;
using MasterPol.Model;
using MasterPol.View.Elements;
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

        public static string GetPartnerType(int idType)
        {
            return PartnersTypesContext.AllPartnerTypes().Find(x => x.id == idType).name;
        }

        public static string CountDiscount(int idPartner)
        {
            int productsCount = 0;
            int discount = 0;
            foreach (PartnerProductsModel model in PartnersProductsContext.AllPartnerProducts())
            {
                if (model.partner == idPartner)
                    productsCount += model.count;
            }
            if (productsCount < 10000)
                discount = 0;
            else if (productsCount > 10000 && productsCount < 50000)
                discount = 5;
            else if (productsCount > 50000 && productsCount < 300000)
                discount = 10;
            else discount = 15;
            return discount + "%";
        }

        public static List<PartnerItem> CreateItems()
        {
            List<PartnerItem> Items = new List<PartnerItem>();
            foreach (PartnersModel model in AllPartners())
            {
                Items.Add(new PartnerItem(model));
            }
            return Items;
        }
    }
}
