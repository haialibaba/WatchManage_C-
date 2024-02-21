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
    public partial class UpdateNhaCungCap : Form
    {
        public bool flag = false;
        public NhaCungCapDTO producer;
        public UpdateNhaCungCap()
        {
            InitializeComponent();
            
        }

        public UpdateNhaCungCap(NhaCungCapDTO producerNCC)
        {
            InitializeComponent();
            txt_id.Text = producerNCC.Id.ToString();
            txt_name.Text = producerNCC.Name;
            txt_phone.Text = producerNCC.PhoneNumber;
            cbb_status.Text = producerNCC.Status == 1 ? "Hoạt động" : "Khóa";
            producer = new NhaCungCapDTO(producerNCC.Id, producerNCC.Name, producerNCC.Status, producerNCC.CreatedAt, producerNCC.UpdatedAt, producerNCC.PhoneNumber);
            txt_name.GotFocus += RemoveTextName;
            txt_name.LostFocus += AddTextName;

            txt_phone.GotFocus += RemoveTextPhone;
            txt_phone.LostFocus += AddTextPhone;
        }

        private void RemoveTextName(object sender, EventArgs e)
        {
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

        private void UpdateNhaCungCap_Load(object sender, EventArgs e)
        {
          
            cbb_status.DisplayMember = "Text";
            cbb_status.ValueMember = "Value";
            var items = new[] {
            new { Text = "Hoạt động", Value = 1 },
            new { Text = "Bị khóa", Value = 0 },
          
            };


            cbb_status.DataSource = items;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            producer.Name = txt_name.Text;
            producer.PhoneNumber = txt_phone.Text;
            producer.Status = (cbb_status.SelectedItem as dynamic).Value;
            producer.UpdatedAt = currentTime;
            string check = NhaCungCapBLL.UpdateData(producer);
            switch (check)
            {
                case "success":
                    flag = true;
                    this.Hide();
                    break;
                case "required":
                    MessageBox.Show("Vui lòng nhập đầy đủ");
                    break;
                case "format_error":
                    MessageBox.Show("Vui lòng nhập đúng format số điện thoại");
                    break;
                default:
                    MessageBox.Show("Lỗi trong quá trình thêm!");
                    break;
            }
            

        }

        private void cbb_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
