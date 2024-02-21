using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Popups
{
    public partial class UpdateDanhMuc : Form
    {
        public bool flag = false;
        public DanhMucDTO danhmuc;
        public UpdateDanhMuc()
        {
            InitializeComponent();
        }
        public UpdateDanhMuc(DanhMucDTO dm)
        {
            InitializeComponent();
            this.danhmuc = dm;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn đổi {danhmuc.Id} - {danhmuc.Name} thành {txt_id.Text} - {txt_name.Text}", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txt_id.Text);
                string name = txt_name.Text;
                DanhMucDTO dm = new DanhMucDTO();
                dm.Id = id;
                dm.Name = name;
                string check = DanhMucBLL.UpdateData(danhmuc);
                switch (check)
                {
                    case "success":
                        this.flag = true;
                        this.danhmuc = dm;
                        this.Hide();
                        break;
                    case "required":
                        MessageBox.Show("Vui lòng nhập đầy đủ");
                        break;
                    case "mysql_error":
                        MessageBox.Show("Có lỗi xảy ra trong quá trình chạy SQL");
                        break;
                    default:
                        MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại");
                        break;
                }
            }
        }
        private void UpdateDanhMuc_Load(object sender, EventArgs e)
        {
            this.txt_id.Text = danhmuc.Id.ToString();
            this.txt_name.Text = danhmuc.Name;
        }
    }
}
