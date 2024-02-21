using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginDAL
    {
        public static List<string> _GetDataLeftMenu(string id)
        {
            List<string> data = new List<string>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT privilege.id_Privilege_group FROM `privilege`,(SELECT privilege_detail.url_match_privilege_id FROM `privilege_detail` WHERE privilege_detail.CategoryStaffs_id='{id}') AS temp WHERE privilege.url_match=temp.url_match_privilege_id GROUP BY privilege.id_Privilege_group", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                data.Add(dr.GetString("id_Privilege_group"));
            }
            conn.Close();
            return data;
        }
        public static List<LoginDTO> _GetDataLogin()
        {
            List<LoginDTO> data = new List<LoginDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM `staffs`", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LoginDTO lgDTO = new LoginDTO(dr.GetString("phoneNumber"), dr.GetString("password"), dr.GetString("CategoryStaffs_id"), dr.GetString("name"));
                data.Add(lgDTO);
            }
            conn.Close();
            return data;
        }
        public static List<string> _GetDataUrlMatch(string id)
        {
            List<string> data = new List<string>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT temp.url_match_privilege_id FROM `privilege`,(SELECT privilege_detail.url_match_privilege_id FROM `privilege_detail` WHERE privilege_detail.CategoryStaffs_id='{id}') AS temp WHERE privilege.url_match=temp.url_match_privilege_id ", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                data.Add(dr.GetString("url_match_privilege_id"));
            }
            conn.Close();
            return data;
        }
    }
}
