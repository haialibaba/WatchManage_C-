
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class KhachHangBLL
    {
        private KhachHangDTO kh;
        private List<KhachHangDTO> dskh;
        KhachHangDAL qlkhDAL = new KhachHangDAL();
        
        public List<KhachHangDTO> readDB()
        {
            return qlkhDAL.readDB();
        }

        public DataTable Display()
        {
            dskh = readDB();
            return qlkhDAL.Display(dskh);
        }
        
        public bool InsertKH(KhachHangDTO customer)
        {
            dskh = readDB();
            //Thêm khách hàng mới vào List
            dskh.Add(customer);
            return qlkhDAL.InsertKH(customer);
        }

        public bool InsertKH(string phone, string name, DateTime create, DateTime update, int total, int status)
        {
            kh = new KhachHangDTO(phone, name, create, update, total, status);
            return InsertKH(kh);
        }

        public bool UpdateKH(string phone, string name)
        {
            dskh = readDB();
            //Cập nhật lại thông tin khách hàng trong List
            foreach (KhachHangDTO kh in dskh)
            {
                if (kh.Phone.Equals(phone))
                {
                    kh.Name = name;
                    kh.UpdatedAt = DateTime.Now;
                }
            }
            return qlkhDAL.UpdateKH(phone, name);
        }

        public bool UpdateKH(string phone, string name, DateTime create, DateTime update, int total, int status)
        {
            kh = new KhachHangDTO(phone, name, create, update, total, status);
            return UpdateKH(phone, name);
        }

        public bool DeleteKH(string index)
        {
            dskh = readDB();
            //Xoá khách hàng trong List
            foreach(KhachHangDTO kh in dskh)
            {
                if (kh.Phone.Equals(index))
                {
                    kh.Status = 0;
                }
            }
            return qlkhDAL.DeleteKH(index);
        }

        public DataTable Show(string text)
        {
            List<KhachHangDTO> dskh_tk = new List<KhachHangDTO>();
            dskh_tk = qlkhDAL.Search(text);
            //Tìm kiếm theo chuỗi nhập vào
            return qlkhDAL.Show(dskh_tk);
        }
    }
}
