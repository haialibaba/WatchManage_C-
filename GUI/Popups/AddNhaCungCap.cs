using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI.Popups
{
    public partial class AddNhaCungCap : Form
    {

        public bool flagAdd = false;
        public NhaCungCapDTO producerAdd;
        public AddNhaCungCap()
        {
            InitializeComponent();
        }

        public AddNhaCungCap(int id)
        {
            InitializeComponent();
            txt_id.Text = id.ToString();
            txt_name.GotFocus += RemoveTextName;
            txt_name.LostFocus += AddTextName;

            txt_phone.GotFocus += RemoveTextPhone;
            txt_phone.LostFocus += AddTextPhone;
        }

        private void RemoveTextName(object sender, EventArgs e) { 
            if (txt_name.Text == "Nhập vào tên nhà cung cấp...")
            {
                txt_name.Text = "";
                txt_name.ForeColor = Color.Black;
            }
        }

        private void AddTextName(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text))
            {
                txt_name.Text = "Nhập vào tên nhà cung cấp...";
                txt_name.ForeColor = Color.Gray;
            }
        }

        private void RemoveTextPhone(object sender, EventArgs e)
        {
            if (txt_phone.Text == "Nhập số điện thoại...")
            {
                txt_phone.Text = "";
                txt_phone.ForeColor = Color.Black;
            }
        }

        private void AddTextPhone(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_phone.Text))
            {
                txt_phone.Text = "Nhập số điện thoại...";
                txt_phone.ForeColor = Color.Gray;
            }
        }

        private void AddNhaCungCap_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string name = txt_name.Text;
            string phoneNumber = txt_phone.Text;

            DateTime currentTime = DateTime.Now;
            NhaCungCapDTO producer = new NhaCungCapDTO();
            producer.Id = Convert.ToInt32(id);
            producer.Status = 1;
            producer.Name = name;
            producer.PhoneNumber = phoneNumber;
            producer.CreatedAt = currentTime;
            producer.UpdatedAt = currentTime;


            string check = NhaCungCapBLL.AddData(producer);
            switch (check)
            {
                case "required":
                    MessageBox.Show("Vui lòng nhập đầy đủ");
                    break;
                case "format_error":
                    MessageBox.Show("Vui lòng nhập đúng format số điện thoại");
                    break;
                case "mysql_error":
                    MessageBox.Show("Lỗi trong quá trình chạy SQL");
                    break;
                case "success":
                    MessageBox.Show("Thêm nhà cung cấp thành công!");
                    flagAdd = true;
                    producerAdd = producer;
                    this.Hide();
                    break;
                default:
                     MessageBox.Show("Lỗi trong quá trình thêm!");
                    break;
            }
           
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
