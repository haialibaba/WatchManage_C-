using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ShowChiTietPhieuXuatDAL
    {
        public static List<ChiTietPhieuDTO> getDataChiTietPX(int id)
        {
            List<ChiTietPhieuDTO> chiTietPX = new List<ChiTietPhieuDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand($"SELECT p.name, dt.prices,dt.quantity,dt.prices*dt.quantity as \"intomoney\" FROM billexport bi, detailbillexport dt, products p WHERE p.id = dt.product_id and bi.id = dt.order_id and bi.id = {id}", conn);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ChiTietPhieuDTO chiTiet = new ChiTietPhieuDTO();
                chiTiet.product_name = reader.GetString("name");
                chiTiet.price = reader.GetInt32("prices");
                chiTiet.quantity = reader.GetInt32("quantity");
                chiTiet.intoMoney = reader.GetInt32("intomoney");
                chiTietPX.Add(chiTiet);
            }
            return chiTietPX;
        }
    }
}
