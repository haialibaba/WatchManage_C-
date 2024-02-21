using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class BaoHanhDAL
    {

        public static List<BaoHanhDTO> GetData()
        {
            List<BaoHanhDTO> maintains = new List<BaoHanhDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from maintainance", conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                BaoHanhDTO maintain = new BaoHanhDTO();
                maintain.Id = reader.GetInt32("id");
                maintain.Time = reader.GetInt32("time");
                maintain.ProductId = reader.GetInt32("product_id");
                maintain.CreatedAt = reader.GetDateTime("createdAt");
                maintain.UpdatedAt = reader.GetDateTime("updatedAt");
                maintains.Add(maintain);
            }


            conn.Close();

            return maintains;
        }

        public static bool AddData(BaoHanhDTO maintain)
        {

            try
            {
                MySqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"insert into maintainance values ({maintain.Id},{maintain.ProductId},{maintain.Time},'{maintain.CreatedAt.ToString("yyyy-MM-dd hh:mm:ss")}','{maintain.UpdatedAt.ToString("yyyy-MM-dd hh:mm:ss")}')", conn);
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
                string query = $"delete from maintainance where id = '{id}'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                return true;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }

        public static bool UpdateData(BaoHanhDTO maintain)
        {
            try
            {
                MySqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                string query = $"update maintainance set product_id ={maintain.ProductId}, time ={maintain.Time}, updatedAt ='{maintain.UpdatedAt.ToString("yyyy-MM-dd hh:mm:ss")}' where id ={maintain.Id}";
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
