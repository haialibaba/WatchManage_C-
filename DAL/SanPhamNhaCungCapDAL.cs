using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class SanPhamNhaCungCapDAL
    {
        public static List<PProducerDTO> GetData()
        {
            List<PProducerDTO> pProducers = new List<PProducerDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from productproducers", conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                PProducerDTO pProducer = new PProducerDTO();
                pProducer.Id = reader.GetInt32("id");
                pProducer.Name = reader.GetString("name");
                pProducer.CategoryId = reader.GetInt32("category_id");
                pProducer.Origin = reader.GetString("origin");
                pProducer.Prices = reader.GetInt32("prices");
                pProducer.ProducerId = reader.GetInt32("producer_id");
                pProducer.Image = reader.GetString("image");
                pProducer.CreatedAt = reader.GetDateTime("createdAt");
                pProducer.UpdatedAt = reader.GetDateTime("updatedAt");
                pProducers.Add(pProducer);
            }


            conn.Close();

            return pProducers;
        }

        public static bool AddData(PProducerDTO pProducer)
        {

            try
            {
                MySqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"insert into productproducers values ('{pProducer.Id}',N'{pProducer.Name}',{pProducer.CategoryId},'{pProducer.Origin}',{pProducer.Prices},{pProducer.ProducerId},'{pProducer.Image}','{pProducer.CreatedAt.ToString("yyyy-MM-dd hh:mm:ss")}','{pProducer.UpdatedAt.ToString("yyyy-MM-dd hh:mm:ss")}')", conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException error)
            {
                return false;
            }


        }

        public static bool DeleteData(int id)
        {
            try
            {
                MySqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                string query = $"delete from productproducers where id = '{id}'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                return true;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }

        public static bool UpdateData(PProducerDTO pProducer)
        {
            try
            {
                MySqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                string query = $"update productproducers set name = '{pProducer.Name}', category_id = '{pProducer.CategoryId}', origin ='{pProducer.Origin}',prices='{pProducer.Prices}',producer_id='{pProducer.ProducerId}', image ='{pProducer.Image}', updatedAt = '{pProducer.UpdatedAt.ToString("yyyy-MM-dd hh:mm:ss")}' where id = {pProducer.Id}";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                return true;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }
    }
}
