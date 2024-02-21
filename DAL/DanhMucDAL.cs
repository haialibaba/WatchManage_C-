using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DTO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DanhMucDAL
    {
        public static List<DanhMucDTO> GetDataAction()
        {
            List<DanhMucDTO> categories = new List<DanhMucDTO>();
            MySqlConnection conn = SqlConnectionData.Connect();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from category where status = 1", conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            { 
                DanhMucDTO category = new DanhMucDTO();
                category.Id = reader.GetInt32("id");
                category.Name = reader.GetString("name");
                categories.Add(category);
            }


            conn.Close();

            return categories;
        }

        public static bool addData(DanhMucDTO cate)
        {
            try
            {
                MySqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"insert into category values ('{cate.Id}','{1}','{cate.CreateAt.ToString("yyyy-MM-dd hh:mm:ss")}','{cate.UpdateAt.ToString("yyyy-MM-dd hh:mm:ss")}',N'{cate.Name}')", conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException error)
            {
                return false;
            }

        }

        public static bool deleteData(int id)
        {
            try
            {
                MySqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"delete from category where id = {id}", conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException error)
            {
                return false;
            }
        }
        public static bool updateData(DanhMucDTO cate)
        {
            try
            {
                MySqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"update category set name = '{cate.Name}',createdAt = '{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}',updatedAt = '{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}' where id = '{cate.Id}'", conn);
                MessageBox.Show($"update category set name = N'{cate.Name}', createdAt = '{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}', updatedAt = '{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}' where id = {cate.Id})");
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
