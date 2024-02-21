using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DTO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class PhanQuyenDAL
    {
        public static int idNext=0;

        public static List<CheckedPermissionsDTO> _GetDataCheckedPermissions()
        {
            List<CheckedPermissionsDTO> data = new List<CheckedPermissionsDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT privilege_detail.CategoryStaffs_id as idDanhMucNhanVien, privilege_detail.url_match_privilege_id as idQuyen FROM `privilege_detail`", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CheckedPermissionsDTO checkedQuyenDTO = new CheckedPermissionsDTO(dr.GetString("idDanhMucNhanVien"), dr.GetString("idQuyen"));
                data.Add(checkedQuyenDTO);
            }
            conn.Close();
            return data;
        }
        public static bool _AddPermission(string idDanhMucNhanVien, string idQuyen)
        {
            try
            {
                MySqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO `privilege_detail`(`CategoryStaffs_id`, `url_match_privilege_id`, `updatedAt`) VALUES ('{idDanhMucNhanVien}','{idQuyen}','{DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff")}')", conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException error)
            {
                return false;
            }
        }
        public static bool _DelPermission(string idDanhMucNhanVien, string idQuyen)
        {
            try
            {
                MySqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"DELETE FROM `privilege_detail` WHERE privilege_detail.CategoryStaffs_id='{idDanhMucNhanVien}' AND privilege_detail.url_match_privilege_id='{idQuyen}'", conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException error)
            {
                return false;
            }
        }
        public static List<PermissionsDTO> _GetDataPermissions(string id)
        {
            List<PermissionsDTO> data = new List<PermissionsDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM `privilege` WHERE privilege.id_Privilege_group={id}", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PermissionsDTO quyenDTO = new PermissionsDTO(dr.GetString("name"), dr.GetString("url_match"));
                data.Add(quyenDTO);
            }
            conn.Close();
            return data;
        }
        public static List<CategoryStaffsDTO> GetDataCategoryStaffs()
        {
            List<CategoryStaffsDTO> data = new List<CategoryStaffsDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `privilege_group` WHERE 1", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CategoryStaffsDTO ctgrSDTO = new CategoryStaffsDTO(dr.GetString("id"), dr.GetString("name"));
                data.Add(ctgrSDTO);
            }
            conn.Close();
            return data;
        }
        public static List<DanhMucNhanVienComboBoxDTO> GetDataComboBox()
        {
            List<DanhMucNhanVienComboBoxDTO> data = new List<DanhMucNhanVienComboBoxDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `categorystaffs` WHERE categorystaffs.status=1 ", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DanhMucNhanVienComboBoxDTO dmnvcbbDTO = new DanhMucNhanVienComboBoxDTO(dr.GetString("id"),dr.GetString("name"));
                data.Add(dmnvcbbDTO);
            }
            conn.Close();
            return data;
        }
        public static int _idNext()
        {
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `categorystaffs` ", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                idNext=dr.GetInt32("id");
            }
            conn.Close();
            return idNext;
        }
        public static List<PhanQuyenDTO> GetData()
        {
            List<PhanQuyenDTO> data = new List<PhanQuyenDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `categorystaffs` ", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr.GetString("status") != "0")
                {
                    PhanQuyenDTO quyen = new PhanQuyenDTO(dr.GetInt32("id"), dr.GetString("name"), dr.GetString("createdAt"), dr.GetString("updateAt"), dr.GetString("status"));
                    data.Add(quyen);
                }
            }
            conn.Close();
            return data;
        }
        public static List<string> GetDataStaffCheckDEL()
        {
            List<string> data = new List<string>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT staffs.CategoryStaffs_id FROM `staffs` WHERE 1", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
              data.Add(dr.GetString("CategoryStaffs_id"));
            }
            conn.Close();
            return data;
        }


        public static bool AddData(int id, string name)
        {
            try
            {
                MySqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                MySqlCommand cmd= new MySqlCommand($"INSERT INTO  categorystaffs VALUE({id},'{name}','{DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff")}','{DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff")}','1')",conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException error)
            {
                return false;
            }
        }
        public static bool UpdateData(int id, string name)
        {
            try
            {
                MySqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"UPDATE `categorystaffs` SET `name`='{name}',`updateAt`='{DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff")}' WHERE id={id}", conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException error)
            {
                return false;
            }
        }
        public static bool DeleteData(int id)
        {
            try
            {
                MySqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"UPDATE `categorystaffs` SET `status`='0' WHERE id={id}", conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException error)
            {
                return false;
            }
        }
    }
}
