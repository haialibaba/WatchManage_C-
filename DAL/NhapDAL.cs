using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhapDAL
    {
        public static List<NhapDTO> getDataNhap()
        {
            List<NhapDTO> phieuNhap = new List<NhapDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT bi.id, bi.createdAt, s.name as staff_name, bi.total, p.name as producers_name FROM billimport bi, staffs s, producers p where bi.staff_id = s.phoneNumber and bi.producer_id = p.id", conn);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                NhapDTO nhap = new NhapDTO();
                nhap.id = reader.GetInt32("id");
                nhap.createAt = reader.GetDateTime("createdAt");
                nhap.staff_name = reader.GetString("staff_name");
                nhap.total = reader.GetInt32("total");
                nhap.producer_name = reader.GetString("producers_name");
                phieuNhap.Add(nhap);
            }
            return phieuNhap;
        }
    }
}
