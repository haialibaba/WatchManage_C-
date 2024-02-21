using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Reflection;

namespace BLL
{
    public class NhanVienBLL
    {
        private NhanVienDTO nv;
        private List<NhanVienDTO> dsnv;
        NhanVienDAL qlnvDAL = new NhanVienDAL();

        public List<NhanVienDTO> readDB()
        {
            return qlnvDAL.readDB();
        }

        public DataTable Display()
        {
            dsnv = readDB();
            return qlnvDAL.Display(dsnv);
        }

        public bool Insert(NhanVienDTO staff)
        {
            dsnv = readDB();
            //Thêm nhân viên mới vào List
            dsnv.Add(staff);
            return qlnvDAL.Insert(staff);
        }

        public bool Insert(string phone, string pass, string name, DateTime create, DateTime update, int status, int type)
        {
            nv = new NhanVienDTO(phone, pass, name, create, update, status, type);
            return Insert(nv);
        }

        public bool Update(string phone, string pass, string name, int type)
        {
            dsnv = readDB();
            //Cập nhật lại thông tin nhân viên trong List
            foreach (NhanVienDTO nv in dsnv)
            {
                if (nv.phone.Equals(phone))
                {
                    nv.name = name;
                    nv.pass = pass;
                    nv.type = type;
                    nv.updatedAt = DateTime.Now;
                }
            }
            return qlnvDAL.Update(phone, pass, name, type);
        }

        public bool Update(string phone, string pass, string name, DateTime create, DateTime update, int status, int type)
        {
            nv = new NhanVienDTO(phone, pass, name, create, update, status, type);
            return Update(phone, pass, name, type);
        }

        public bool Delete(string index)
        {
            dsnv = readDB();
            //Xoá nhân viên trong List
            foreach (NhanVienDTO nv in dsnv)
            {
                if (nv.phone.Equals(index))
                {
                    nv.status = 0;
                }
            }
            return qlnvDAL.Delete(index);
        }
        public DataTable Show(string text)
        {
            List<NhanVienDTO> dsnv_tk = new List<NhanVienDTO>();
            dsnv_tk = qlnvDAL.Search(text);
            //Tìm kiếm nhân viên theo chuỗi nhập vào
            return qlnvDAL.Show(dsnv_tk);
        }
    }
}
