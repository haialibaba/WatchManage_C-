using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class DanhMucBLL
    {
        public static List<DanhMucDTO> GetDataAction()
        {
            return DanhMucDAL.GetDataAction();
        }
        public static bool deleteData(int id)
        {
            return DanhMucDAL.deleteData(id);
        }
        public static string AddData(DanhMucDTO danhmuc)
        {
            if (danhmuc.Name.Trim() == "") 
            { 
                return "required";
            }

            if (DanhMucDAL.addData(danhmuc))
            {
                return "success";
            }
            else
            {
                return "mysql_error";
            }
        }
        public static string UpdateData(DanhMucDTO danhmuc)
        {
            if (danhmuc.Name.Trim() == "")
            {
                return "required";
            }

            if (DanhMucDAL.updateData(danhmuc))
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
