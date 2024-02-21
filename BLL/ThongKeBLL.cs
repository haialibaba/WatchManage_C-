using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThongKeBLL
    {
        public static string tongDoanhThu, tienNhap, tienXuat,check;
        public static void _getDataGia(string dayStart, string dayEnd)
        {
            ThongKeDAL._getDataGia(dayStart, dayEnd);
            tongDoanhThu = ThongKeDAL.tongDoanhThu;
            tienNhap = ThongKeDAL.tienNhap;
            tienXuat = ThongKeDAL.tienXuat;
        }
        public static List<ThongKeSanPhamDTO> _getDataSanPhamXuat(string dayStart, string dayEnd)
        {
            return ThongKeDAL._getDataSanPhamXuat(dayStart, dayEnd);
        }
        public static List<ThongKeSanPhamDTO> _getDataSanPhamNhap(string dayStart, string dayEnd)
        {
            return ThongKeDAL._getDataSanPhamNhap(dayStart, dayEnd);
        }
        public static List<ThongKeNhanVienDTO> _getDataNhanVienNhap(string dayStart, string dayEnd)
        {
            return ThongKeDAL._getDataNhanVienNhap(dayStart, dayEnd);
        }
        public static List<ThongKeNhanVienDTO> _getDataNhanVienXuat(string dayStart, string dayEnd)
        {
            return ThongKeDAL._getDataNhanVienXuat(dayStart, dayEnd);
        }
        public static List<ThongKeKhachHangDTO> _getDataKhachHang(string dayStart, string dayEnd)
        {
            return ThongKeDAL._getDataKhachHang(dayStart, dayEnd);
        }
    }
}
