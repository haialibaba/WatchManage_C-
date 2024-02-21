using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class ChiTietBaoHanhDAL
    {
        public static List<ChiTietBaoHanhDTO> GetData()
        {
            List<ChiTietBaoHanhDTO> details = new List<ChiTietBaoHanhDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from detailmaintainance", conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ChiTietBaoHanhDTO detail = new ChiTietBaoHanhDTO();
                detail.Id = reader.GetInt32("id");
                detail.DetailProductId = reader.GetInt32("detailProduct_id");
                detail.CustomerId = reader.GetString("customer_id");
                detail.CreatedAt = reader.GetDateTime("createdAt");
                detail.OutOfDate = reader.GetDateTime("outofdate");
                detail.Status = reader.GetInt32("status");

                details.Add(detail);
            }


            conn.Close();

            return details;
        }

        public static bool UpdateData(ChiTietBaoHanhDTO detail)
        {
            try
            {
                MySqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                string query = $"update detailmaintainance set status = {detail.Status} where id = {detail.Id}";
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
