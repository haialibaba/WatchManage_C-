using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class NhaCungCapDAL
    {
        public static List<NhaCungCapDTO> GetData()
        {
            List<NhaCungCapDTO> producers = new List<NhaCungCapDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
    
            MySqlCommand cmd = new MySqlCommand("select * from producers", conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                NhaCungCapDTO producer = new NhaCungCapDTO();
                producer.Id = reader.GetInt32("id");
                producer.Name = reader.GetString("name");
                producer.Status = reader.GetInt32("status");
                producer.CreatedAt = reader.GetDateTime("createdAt");
                producer.UpdatedAt = reader.GetDateTime("updatedAt");
                producer.PhoneNumber = reader.GetString("phoneNumber");
                producers.Add(producer);
            }


            conn.Close();

            return producers;
        }

        public static List<NhaCungCapDTO> GetDataAction()
        {
            List<NhaCungCapDTO> producers = new List<NhaCungCapDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from producers where status = 1", conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                NhaCungCapDTO producer = new NhaCungCapDTO();
                producer.Id = reader.GetInt32("id");
                producer.Name = reader.GetString("name");
                producer.Status = reader.GetInt32("status");
                producer.CreatedAt = reader.GetDateTime("createdAt");
                producer.UpdatedAt = reader.GetDateTime("updatedAt");
                producer.PhoneNumber = reader.GetString("phoneNumber");
                producers.Add(producer);
            }


            conn.Close();

            return producers;
        }

        public static bool AddData(NhaCungCapDTO producer)
        {

            try
            {
                MySqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"insert into producers values ({producer.Id},'{producer.Name}',{producer.Status},'{producer.CreatedAt.ToString("yyyy-MM-dd hh:mm:ss")}','{producer.UpdatedAt.ToString("yyyy-MM-dd hh:mm:ss")}','{producer.PhoneNumber}')", conn);
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
                string query = $"delete from producers where id = '{id}'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                return true;
            }catch(MySqlException e)
            {
                return false;
            }
        }

        public static bool UpdateData(NhaCungCapDTO producer)
        {
            try
            {
                MySqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                string query = $"update producers set name = '{producer.Name}', phoneNumber = '{producer.PhoneNumber}', status = '{producer.Status}', updatedAt = '{producer.UpdatedAt.ToString("yyyy-MM-dd hh:mm:ss")}' where id = {producer.Id}";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                return true;
            }catch(MySqlException e)
            {
                return false;
            }
        }
    }
}
