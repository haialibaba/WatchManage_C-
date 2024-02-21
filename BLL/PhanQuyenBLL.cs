using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class PhanQuyenBLL
    {
        public static List<string> GetDataStaffCheckDEL()
        {
            return PhanQuyenDAL.GetDataStaffCheckDEL();
        }
        public static List<CheckedPermissionsDTO> _GetDataCheckedPermissions()
        {
            return PhanQuyenDAL._GetDataCheckedPermissions();
        }
        public static bool _AddPermission(string idDanhMucNhanVien, string idQuyen)
        {
            if (idDanhMucNhanVien == "")
            {
                return false;
            }
            else if (idQuyen == "")
            {
                return false;
            }
            return PhanQuyenDAL._AddPermission(idDanhMucNhanVien, idQuyen);
        }
        public static bool _DelPermission(string idDanhMucNhanVien, string idQuyen)
        {
            if (idDanhMucNhanVien == "")
            {
                return false;
            }
            else if (idQuyen == "")
            {
                return false;
            }
            return PhanQuyenDAL._DelPermission(idDanhMucNhanVien, idQuyen);
        }
        public static List<PermissionsDTO> _GetDataPermissions(string id)
        {
            return PhanQuyenDAL._GetDataPermissions(id);
        }
        public static List<CategoryStaffsDTO> GetDataCategoryStaffs()
        {
            return PhanQuyenDAL.GetDataCategoryStaffs();
        }
        public static List<DanhMucNhanVienComboBoxDTO> GetDataComboBox()
        {
            return PhanQuyenDAL.GetDataComboBox();
        }
        public static int _idNext()
        {
            return PhanQuyenDAL._idNext();
        }
        public static List<PhanQuyenDTO> GetData()
        {
            return PhanQuyenDAL.GetData();
        }
        public static bool AddData(int id, string name)
        {
            if(id+"" == "")
            {
                return false;
            }else if (name == "")
            {
                return false;
            }
            return PhanQuyenDAL.AddData(id, name);
        }
        public static bool UpdateData(int id, string name)
        {
            if (id + "" == "")
            {
                return false;
            }
            else if (name == "")
            {
                return false;
            }
            return PhanQuyenDAL.UpdateData(id, name);
        }
        public static bool DeleteData(int id)
        {
            if (id + "" == "")
            {
                return false;
            }
            return PhanQuyenDAL.DeleteData(id);
        }
    }
}
