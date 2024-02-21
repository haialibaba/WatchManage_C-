using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SpnccQLSPDAL
    {

        public static List<spnccDTO> GetData()
        {
            List<spnccDTO> productsNCC = new List<spnccDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand($"SELECT *,producers.name as producers_name from productproducers,producers where productproducers.producer_id = producers.id", conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                spnccDTO productNCC = new spnccDTO();
                productNCC.Id = reader.GetInt32("id");
                productNCC.Name = reader.GetString("name");
                productNCC.Type = reader.GetString("producers_name");
                productNCC.Origin = reader.GetString("origin");
                productNCC.Image = reader.GetString("image");
                productNCC.Prices = reader.GetInt32("prices");
                productNCC.Producer = reader.GetInt32("producer_id");
                productNCC.TypeID = reader.GetString("category_id");
                productsNCC.Add(productNCC);
            }


            conn.Close();

            return productsNCC;
        }

        public static List<spnccDTO> GetDatacbbType()
        {
            List<spnccDTO> productQL = new List<spnccDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("Select * from producers", conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                spnccDTO product = new spnccDTO();
                product.Name = reader.GetString("name");
                product.Id = reader.GetInt32("id");
                productQL.Add(product);
            }
            conn.Close();

            return productQL;
        }

        public static List<spnccDTO> GetDatacbb()
        {
            List<spnccDTO> productQL = new List<spnccDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("Select * from category", conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                spnccDTO product = new spnccDTO();
                product.Name = reader.GetString("name");
                product.Id = reader.GetInt32("id");
                productQL.Add(product);
            }
            conn.Close();

            return productQL;
        }

        public static bool AddData(spnccDTO cart)
        {
            try
            {
                MySqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                string query = $"INSERT INTO `products`(`id`,`name`, `category_id`, `updateAt`, `origin`, `prices`, `quantity`, `producer_id`, `image`) VALUES ('{cart.Id}','{cart.Name}','{cart.TypeID}','{DateTime.Now.ToString("yyyyMMddHHmmss")}','{cart.Origin}','{cart.Prices}','{cart.Quantity}','{cart.Producer}','{cart.Image}')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                conn.Close();
                return true;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }

        public static bool UpdateData(spnccDTO cart)
        {
            try
            {
                MySqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                string query = $"UPDATE `products` SET `quantity`='{cart.Quantity}' WHERE id = {cart.Id}";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                conn.Close();
                return true;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }

        public static bool AddDataSPC(List<spcDTO> spc)
        {
            try
            {

                MySqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                

                foreach(spcDTO item in spc)
                {
                    string values = "";
                    for(int i = 0; i < Convert.ToInt32(item.Quantity); i++)
                    {
                        values += $"(NULL,{Convert.ToInt32(item.Id)},1)";
                        if(i < Convert.ToInt32(item.Quantity) - 1)
                        {
                            values += ",";
                        }
                    }

                    MySqlCommand cmd = new MySqlCommand($"insert into detailproduct values {values}", conn);
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }
    }
}
