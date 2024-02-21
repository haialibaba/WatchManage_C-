using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SpQLSPDAL
    {
        public static List<SpQLSPDTO> GetData()
        {
            List<SpQLSPDTO> productQL = new List<SpQLSPDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * ,temp.name as name_producer,temps.name as category_name FROM `products`,(SELECT producers.id,producers.name FROM `producers`) as temp,(SELECT category.id,category.name FROM `category`) as temps WHERE products.producer_id=temp.id and temps.id = products.category_id", conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                SpQLSPDTO product = new SpQLSPDTO();
                product.Id = reader.GetInt32("id");
                product.Name = reader.GetString("name");
                product.Type = reader.GetString("category_name");
                product.Origin = reader.GetString("origin");
                product.Image = reader.GetString("image");
                product.Prices = reader.GetInt32("prices");
                product.Quantity = reader.GetInt32("quantity");
                product.producer = reader.GetString("name_producer");
                productQL.Add(product);
            }


            conn.Close();

            return productQL;
        }

        public static bool UpdateData(SpQLSPDTO product)
        {
            try
            {
                MySqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                string query = $"update products set name = '{product.Name}',category_id = {product.Type},updateAt ='{DateTime.Now.ToString("yyyyMMddHHmmss")}',origin = '{product.Origin}', prices = {product.Prices},producer_id = {product.producer},image = '{product.Image}' where id = {product.Id}";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                return true;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }

        public static List<SpQLSPDTO> GetDatacbbType()
        {
            List<SpQLSPDTO> productQL = new List<SpQLSPDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("Select * from category", conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                SpQLSPDTO product = new SpQLSPDTO();
                product.Type = reader.GetString("name");
                product.Id = reader.GetInt32("id");
                productQL.Add(product);
            }


            conn.Close();

            return productQL;
        }

      public static List<SpQLSPDTO> GetDatacbbProducer()
        {
            List<SpQLSPDTO> productQL = new List<SpQLSPDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("Select * from producers", conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                SpQLSPDTO product = new SpQLSPDTO();
                product.producer = reader.GetString("name");
                product.Id = reader.GetInt32("id");
                productQL.Add(product);
            }


            conn.Close();

            return productQL;
        }





    }
}

