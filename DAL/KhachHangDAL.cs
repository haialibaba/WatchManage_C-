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
    public class KhachHangDAL
    {
        MySqlConnection conn = SqlConnectionData.Connect();
        private List<KhachHangDTO> dskh, found;
        //Đọc dữ liệu từ CSDL để lưu vào List
        public List<KhachHangDTO> readDB()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM customer";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader read = cmd.ExecuteReader();
                dskh = new List<KhachHangDTO>();
                while (read.Read())
                {
                    KhachHangDTO kh = new KhachHangDTO();   //Khởi tạo đối tượng mới
                    kh.Phone = read.GetString(0);
                    kh.Name = read.GetString(1);
                    kh.CreatedAt = read.GetDateTime(2);
                    kh.UpdatedAt = read.GetDateTime(3);
                  //  kh.ToTal = read.GetInt32(4);
                    //kh.Status = read.GetInt32(5);
                    dskh.Add(kh);   //Thêm đối tượng vừa đọc vào List
                }
                conn.Close();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Error: " + ex); //Hiển thị lỗi nếu có
            }
            finally
            {
                conn.Close();   //Đóng kết nối
            }
            return dskh;
        }
        
        public bool InsertKH(KhachHangDTO kh)
        {
            conn.Open();
            try
            {
                string query = $"INSERT INTO customer (phoneNumber, name, createdAt, updateAt, total, status) VALUES ('{kh.Phone}', '{kh.Name}', '{kh.CreatedAt.ToString("yyyy-MM-dd hh:mm:ss")}', '{kh.UpdatedAt.ToString("yyyy-MM-dd hh:mm:ss")}', '{kh.ToTal}', '{kh.Status}')";
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
         
        public bool UpdateKH(string phone, string name)
        {
            conn.Open();
            try
            {
                KhachHangDTO kh = new KhachHangDTO();
                string query = "UPDATE customer SET "
                    + "phoneNumber = '" + phone
                    + "',name = '" + name
                    + "',updateAt = '" + kh.UpdatedAt.ToString("yyyy-MM-dd hh:mm:ss")
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
        public bool DeleteKH(string index)
        {
            conn.Open(); 
            try
            {
                foreach(KhachHangDTO kh in dskh)
                {
                    if (kh.Phone.Equals(index)) //Nếu số điện thoại bằng giá trị ô được chọn của cột "Số điện thoại" thì mới cập nhật lại status
                    {
                        string query = "UPDATE customer SET status = '" + kh.Status + "' WHERE phoneNumber = '"+ index +"'";
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

        public List<KhachHangDTO> Search(string text)
        {
            try
            {
                foreach (KhachHangDTO kh in dskh)
                {
                    conn.Open();
                    string query = "SELECT * FROM customer WHERE name LIKE '" + text + "' OR phoneNumber LIKE '" + text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader read = cmd.ExecuteReader();
                    found = new List<KhachHangDTO>();
                    while (read.Read())
                    {
                        kh.Phone = read.GetString(0);
                        kh.Name = read.GetString(1);
                        kh.CreatedAt = read.GetDateTime(2);
                        kh.UpdatedAt = read.GetDateTime(3);
                        kh.ToTal = read.GetInt32(4);
                        kh.Status = read.GetInt32(5);
                        found.Add(kh);   //Thêm đối tượng vừa đọc vào List
                    }
                    conn.Close(); //Sau mỗi lần đọc lần đóng kết nối lại
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
        public DataTable Display(List<KhachHangDTO> ds)
        {
            ds = readDB();
            return Show(ds);
        }

        public DataTable Show(List<KhachHangDTO> ds)
        {
            DataTable dtb = new DataTable();    //Khởi tạo bảng, sau đó thêm các cột và gán kiểu dữ liệu
            dtb.Columns.Add("STT", typeof(int));
            dtb.Columns.Add("Họ tên", typeof(string));
            dtb.Columns.Add("Số điện thoại", typeof(string));
            dtb.Columns.Add("Ngày tạo", typeof(DateTime));
            dtb.Columns.Add("Ngày cập nhật", typeof(DateTime));

            foreach (KhachHangDTO kh in ds)
            {
                if (kh.Status == 1)  //Nếu status bằng 1 thì mới thêm
                {
                    DataRow data = dtb.NewRow();
                    data["Họ tên"] = kh.Name;
                    data["Số điện thoại"] = kh.Phone;
                    data["Ngày tạo"] = kh.CreatedAt;
                    data["Ngày cập nhật"] = kh.UpdatedAt;

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
