using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class XuatDAL
    {
        public static List<XuatDTO> getData()
        {
            List<XuatDTO> data = new List<XuatDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT bi.id,bi.createdAt ,s.name as staff_name,bi.total, ctm.name as customer_name FROM billexport bi, staffs s, customer ctm where bi.staff_id = s.phoneNumber and ctm.phoneNumber = bi.customerPhone", conn);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                XuatDTO phieuXuat = new XuatDTO();
                phieuXuat.id = reader.GetInt32("id");
                phieuXuat.createdAt = reader.GetDateTime("createdAt");
                phieuXuat.staff_name = reader.GetString("staff_name");
                phieuXuat.total = reader.GetInt32("total");
                phieuXuat.customer_name = reader.GetString("customer_name");
                data.Add(phieuXuat);
            }
            return data;
        }
    }
}
