using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class SPBanHangDAL
    {
        public static List<SPBanHangDTO> GetData()
        {
            List<SPBanHangDTO> productBHs = new List<SPBanHangDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * ,temp.name as name_producer,temps.name as category_name FROM `products`,(SELECT producers.id,producers.name FROM `producers`) as temp,(SELECT category.id,category.name FROM `category`) as temps WHERE products.producer_id=temp.id and temps.id = products.category_id", conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                SPBanHangDTO productBH = new SPBanHangDTO();
                productBH.Id = reader.GetInt32("id");
                productBH.Name = reader.GetString("name");
                productBH.Type = reader.GetString("category_name");
                productBH.Origin = reader.GetString("origin");
                productBH.Image = reader.GetString("image");
                productBH.Prices = reader.GetString("prices");
                productBH.producer = reader.GetString("name_producer");
                productBHs.Add(productBH);
            }


            conn.Close();

            return productBHs;
        }
    }
}
