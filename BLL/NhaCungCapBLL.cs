using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class NhaCungCapBLL
    {
        public static List<NhaCungCapDTO> GetData()
        {
            return NhaCungCapDAL.GetData();
        }

        public static List<NhaCungCapDTO> GetDataAction()
        {
            return NhaCungCapDAL.GetDataAction();
        }

        public static string AddData(NhaCungCapDTO producer)
        {
            if(producer.Name.Trim() == "" || producer.Name.Trim() == "Nhập vào tên nhà cung cấp..." || producer.PhoneNumber.Trim() == "" || producer.PhoneNumber.Trim() == "Nhập số điện thoại...")
            {
                return "required";
            }

            if (!Class1.IsValidPhone(producer.PhoneNumber))
            {
                return "format_error";
            }

            if(NhaCungCapDAL.AddData(producer) == true)
            {
                return "success";
            }
            else
            {
                return "mysql_error";
            }
        }

        public static bool DeleteData(int id)
        {
            return NhaCungCapDAL.DeleteData(id);
        }

        public static string UpdateData(NhaCungCapDTO producer)
        {
            if (producer.Name.Trim() == "" || producer.Name.Trim() == "Nhập vào tên nhà cung cấp..." || producer.PhoneNumber.Trim() == "" || producer.PhoneNumber.Trim() == "Nhập số điện thoại...")
            {
                return "required";
            }

            if (!Class1.IsValidPhone(producer.PhoneNumber))
            {
                return "format_error";
            }

            if (NhaCungCapDAL.UpdateData(producer))
            {
                return "success";
            }
            else
            {
                return "mysql_error";
            }
        }
    }
}
