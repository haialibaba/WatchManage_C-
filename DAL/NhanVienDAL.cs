using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MySql.Data.MySqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;
using System.Data;

namespace DAL
{
    public class NhanVienDAL : DatabaseAcess
    {
        MySqlConnection conn = SqlConnectionData.Connect();
        private List<NhanVienDTO> dsnv, found;
        //Đọc dữ liệu từ CSDL để lưu vào List
        public List<NhanVienDTO> readDB()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM staffs";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader read = cmd.ExecuteReader();
                dsnv = new List<NhanVienDTO>();
                while (read.Read())
                {
                    NhanVienDTO nv = new NhanVienDTO();   //Khởi tạo đối tượng mới
                    nv.phone = read.GetString(0);
                    nv.pass = read.GetString(1);
                    nv.name = read.GetString(2);
                    nv.status = read.GetInt32(3);
                    nv.createdAt = read.GetDateTime(4);
                    nv.updatedAt = read.GetDateTime(5);
                    nv.type = read.GetInt32(6);
                    dsnv.Add(nv);   //Thêm đối tượng vừa đọc vào List
                }
                conn.Close();   
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex); //Hiển thị lỗi nếu có
            }
            finally
            {
                conn.Close();   //Đóng kết nối
            }
            return dsnv;
        }
        public bool Insert(NhanVienDTO nv)
        {
            conn.Open();
            try
            {
                string query = $"INSERT INTO staffs (phoneNumber, password, name, status, createdAt, updatedAt, CategoryStaffs_id) VALUES ('{nv.phone}', '{nv.pass}', '{nv.name}', '{nv.status}','{nv.createdAt.ToString("yyyy-MM-dd hh:mm:ss")}', '{nv.updatedAt.ToString("yyyy-MM-dd hh:mm:ss")}', '{nv.type}')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //Thêm khách hàng mới vào CSDL
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex);    //Hiển thị lỗi nếu có
                return false;
            }
            finally
            {
                conn.Close();   //Đóng kết nối
            }

        }
        
        public bool Update(string phone, string pass, string name, int type)
        {
            conn.Open();
            try
            {
                NhanVienDTO nv = new NhanVienDTO();
                string query = "UPDATE staffs SET "
                    + "phoneNumber = '" + phone
                    + "',password = '" + pass
                    + "',name = '" + name
                    + "',updatedAt = '" + nv.updatedAt.ToString("yyyy-MM-dd hh:mm:ss")
                    + "',CategoryStaffs_id = '" + type
                    + "' where phoneNumber='" + phone + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //Thực hiện câu lệnh cập nhật khách hàng trong CSDL
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex);    //Hiển thị lỗi nếu có
                return false;
            }
            finally
            {
                conn.Close();   //Đóng kết nối
            }
        }
        //Xoá theo số điện thoại
        public bool Delete(string index)
        {
            conn.Open();
            try
            {
                foreach (NhanVienDTO nv in dsnv)
                {
                    if (nv.phone.Equals(index)) //Nếu số điện thoại bằng giá trị ô được chọn của cột "Số điện thoại" thì mới cập nhật lại status
                    {
                        string query = "UPDATE staffs SET status = '" + nv.status + "' WHERE phoneNumber = '" + index + "'";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex);    //Hiển thị lỗi nếu có
                return false;
            }
            finally
            {
                conn.Close();   //Đóng kết nối
            }
        }

        public List<NhanVienDTO> Search(string text)
        {
            text = text.ToLower();
            try 
            { 
                foreach (NhanVienDTO nv in dsnv)
                {
                    conn.Open();
                    string query = "SELECT * FROM staffs WHERE name LIKE '" + text + "' OR phoneNumber LIKE '" + text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader read = cmd.ExecuteReader();
                    found = new List<NhanVienDTO>();
                    while (read.Read())
                    {
                        nv.phone = read.GetString(0);
                        nv.pass = read.GetString(1);
                        nv.name = read.GetString(2);
                        nv.status = read.GetInt32(3);
                        nv.createdAt = read.GetDateTime(4);
                        nv.updatedAt = read.GetDateTime(5);
                        nv.type = read.GetInt32(6);
                        found.Add(nv);   //Thêm đối tượng vừa đọc vào List
                    }
                    conn.Close();   //Sau mỗi lần đọc lần đóng kết nối lại
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex);    //Hiển thị lỗi nếu có
            }
            finally
            {
                conn.Close();   //Đóng kết nối
            }
            return found;
        }
        //Hiển thị + Reload dữ liệu vào DataGridView
        public DataTable Display(List<NhanVienDTO> ds)
        {
            ds = readDB();
            return Show(ds);
        }

        public DataTable Show(List<NhanVienDTO> ds)
        {
            DataTable dtb = new DataTable();    //Khởi tạo bảng, sau đó thêm các cột và gán kiểu dữ liệu
            dtb.Columns.Add("STT", typeof(int));
            dtb.Columns.Add("Họ tên", typeof(string));
            dtb.Columns.Add("Số điện thoại", typeof(string));
            dtb.Columns.Add("Mật khẩu", typeof(string));
            dtb.Columns.Add("Ngày tạo", typeof(DateTime));
            dtb.Columns.Add("Ngày cập nhật", typeof(DateTime));

            foreach (NhanVienDTO nv in ds)
            {
                if (nv.status == 1)  //Nếu status bằng 1 thì mới hiển thị ra bảng
                {
                    DataRow data = dtb.NewRow();

                    data["Họ tên"] = nv.name;
                    data["Số điện thoại"] = nv.phone;
                    data["Mật khẩu"] = nv.pass;
                    data["Ngày tạo"] = nv.createdAt;
                    data["Ngày cập nhật"] = nv.updatedAt;

                    dtb.Rows.Add(data); //Thêm đối tượng vào bảng

                    for (int i = 0; i < dtb.Rows.Count; i++)
                    {
                        data["STT"] = i + 1;    //set số thứ tự tăng dần cho bảng
                    }
                }
            }
            return dtb;
        }
    }
}
