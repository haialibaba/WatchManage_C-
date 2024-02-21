using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ShowChiTietPhieuNhapDAL
    {
        public static List<ChiTietPhieuDTO> getDataChiTietPN(int id)
        {
            List<ChiTietPhieuDTO> chiTietPN = new List<ChiTietPhieuDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand($"SELECT p.name, dt.prices,dt.quantity,dt.prices*dt.quantity as \"intomoney\" FROM billimport bi, detailbillimport dt, products p WHERE p.id = dt.product_id and bi.id = dt.order_id and bi.id = {id}", conn);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ChiTietPhieuDTO chiTiet = new ChiTietPhieuDTO();
                chiTiet.product_name = reader.GetString("name");
                chiTiet.price = reader.GetInt32("prices");
                chiTiet.quantity = reader.GetInt32("quantity");
                chiTiet.intoMoney = reader.GetInt32("intomoney");
                chiTietPN.Add(chiTiet);
            }
            return chiTietPN;
        } 
    }
}
