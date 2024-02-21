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
    public partial class AddDanhMuc : Form
    {
        public bool flagAdd = false;
        public DanhMucDTO danhMuc;
        public AddDanhMuc()
        {
            InitializeComponent();
        }
        public AddDanhMuc(int id)
        {
            InitializeComponent();
            this.txt_id.Text = id.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DanhMucDTO dm = new DanhMucDTO();
            dm.Id = Convert.ToInt32(txt_id.Text);
            dm.Name = txt_name.Text;
            string check = DanhMucBLL.AddData(dm);
            switch (check)
            {
                case "required":
                    MessageBox.Show("Vui lòng nhập đầy đủ");
                    txt_name.Focus();
                    break;
                case "mysql_error":
                    MessageBox.Show("Lỗi trong quá trình chạy SQL");
                    break;
                case "success":
                    MessageBox.Show("Thêm sản phẩm thành công!");
                    flagAdd = true;
                    danhMuc = dm;
                    this.Hide();
                    break;
                default:
                    MessageBox.Show("Lỗi trong quá trình thêm!");
                    break;
            }
        }
    }
}
