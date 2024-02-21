using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class ThongKeDAL
    {
        public static string tongDoanhThu, tienNhap, tienXuat, check;

        public static void _getDataGia(string dayStart, string dayEnd)
        {
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT (temp.total-SUM(billexport.total))as tongdoanhthu,SUM(billexport.total)as tienxuat,temp.total as tiennhap FROM `billexport`,(SELECT SUM(billimport.total) as total FROM `billimport` WHERE (billimport.createdAt BETWEEN '{dayStart}' AND '{dayEnd}'))as temp WHERE (billexport.createdAt BETWEEN '{dayStart}' AND '{dayEnd}')", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            int indexTongDoanhThu = dr.GetOrdinal("tongdoanhthu");
            int indexTienNhap = dr.GetOrdinal("tiennhap");
            int indexTienXuat = dr.GetOrdinal("tienxuat");
            while (dr.Read())
            {             
                 tongDoanhThu = dr.IsDBNull(indexTongDoanhThu)? "0":dr.GetString("tongdoanhthu");
                 tienNhap = dr.IsDBNull(indexTienNhap) ? "0" : dr.GetString("tiennhap");
                 tienXuat = dr.IsDBNull(indexTienXuat) ? "0" : dr.GetString("tienxuat");
            }
            conn.Close();
        }
        public static List<ThongKeSanPhamDTO> _getDataSanPhamXuat(string dayStart, string dayEnd)
        {
            List<ThongKeSanPhamDTO> data = new List<ThongKeSanPhamDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT detailbillexport.product_id,products.name,detailbillexport.prices,SUM(detailbillexport.quantity) AS quantity FROM `products`,`detailbillexport`,(SELECT billexport.id AS id FROM `billexport` WHERE billexport.createdAt BETWEEN '{dayStart}' AND '{dayEnd}') AS temp WHERE temp.id=detailbillexport.order_id AND products.id=detailbillexport.product_id GROUP by detailbillexport.product_id", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ThongKeSanPhamDTO tkspnDTO = new ThongKeSanPhamDTO(dr.GetString("product_id"), dr.GetString("name"), dr.GetString("prices"), dr.GetString("quantity"));
                data.Add(tkspnDTO);
            }
            conn.Close();
            return data;
        }
        public static List<ThongKeSanPhamDTO> _getDataSanPhamNhap(string dayStart, string dayEnd)
        {
            List<ThongKeSanPhamDTO> data = new List<ThongKeSanPhamDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT detailbillimport.product_id,productproducers.name,detailbillimport.prices,SUM(detailbillimport.quantity) AS quantity FROM `productproducers`,`detailbillimport`,(SELECT billimport.id AS id FROM `billimport` WHERE billimport.createdAt BETWEEN '{dayStart}' AND '{dayEnd}') AS temp WHERE temp.id=detailbillimport.order_id AND productproducers.id=detailbillimport.product_id GROUP by detailbillimport.product_id", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ThongKeSanPhamDTO tkspnDTO = new ThongKeSanPhamDTO(dr.GetString("product_id"), dr.GetString("name"), dr.GetString("prices"), dr.GetString("quantity"));
                data.Add(tkspnDTO);
            }
            conn.Close();
            return data;
        }
        public static List<ThongKeNhanVienDTO> _getDataNhanVienNhap(string dayStart, string dayEnd)
        {
            List<ThongKeNhanVienDTO> data = new List<ThongKeNhanVienDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT temp.id, staffs.name, temp.soluongdonhang  FROM `staffs`,(SELECT billimport.staff_id AS id, COUNT(billimport.staff_id) as soluongdonhang FROM `billimport` WHERE billimport.createdAt BETWEEN '{dayStart}' AND '{dayEnd}' GROUP BY billimport.staff_id) AS temp WHERE staffs.phoneNumber =temp.id", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ThongKeNhanVienDTO tknvnDTO = new ThongKeNhanVienDTO(dr.GetString("id"), dr.GetString("name"), dr.GetString("soluongdonhang"));
                data.Add(tknvnDTO);
            }
            conn.Close();
            return data;
        }
        public static List<ThongKeNhanVienDTO> _getDataNhanVienXuat(string dayStart, string dayEnd)
        {
            List<ThongKeNhanVienDTO> data = new List<ThongKeNhanVienDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT temp.id, staffs.name, temp.soluongdonhang  FROM `staffs`,(SELECT billexport.staff_id AS id, COUNT(billexport.staff_id) as soluongdonhang FROM `billexport` WHERE billexport.createdAt BETWEEN '{dayStart}' AND '{dayEnd}' GROUP BY billexport.staff_id) AS temp WHERE staffs.phoneNumber = temp.id", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ThongKeNhanVienDTO tknvnDTO = new ThongKeNhanVienDTO(dr.GetString("id"), dr.GetString("name"), dr.GetString("soluongdonhang"));
                data.Add(tknvnDTO);
            }
            conn.Close();
            return data;
        }
        public static List<ThongKeKhachHangDTO> _getDataKhachHang(string dayStart, string dayEnd)
        {
            List<ThongKeKhachHangDTO> data = new List<ThongKeKhachHangDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT temp.phone, customer.name, temp.soluongdonhang, customer.total  FROM `customer`,(SELECT billexport.customerPhone AS phone, COUNT(billexport.customerPhone) as soluongdonhang FROM `billexport` WHERE billexport.createdAt BETWEEN '{dayStart}' AND '{dayEnd}' GROUP BY billexport.customerPhone) AS temp WHERE customer.phoneNumber = temp.phone", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ThongKeKhachHangDTO tkkhnDTO = new ThongKeKhachHangDTO(dr.GetString("phone"), dr.GetString("name"), dr.GetString("soluongdonhang"), dr.GetString("total"));
                data.Add(tkkhnDTO);
            }
            conn.Close();
            return data;
        }
    }
}
