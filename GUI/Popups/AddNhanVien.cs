using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DTO;
using BLL;

namespace GUI.Popups
{
    public partial class AddNhanVien : Form
    {
        NhanVienBLL qlnvBLL = new NhanVienBLL();
        NhanVienDTO nv = new NhanVienDTO();
        public AddNhanVien()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            txtName.Text = txtPhone.Text = txtPass.Text = cboType.Text = string.Empty;
        }

        public bool Check()
        {
            TextBox[] text = { txtName, txtPhone, txtPass };
            foreach (TextBox txt in text)
            {
                if (txt.Text == "")
                {
                    MessageBox.Show("Không được để trống thông tin!");
                    txt.Focus();
                    return false;
                }
            }
            if(cboType.Text == "")
            {
                MessageBox.Show("Cần chọn loại nhân viên!");
                return false;
            }
            //Kiểm tra định dạng số điện thoại
            if (text[1].Text != null)
            {
                if(!BLL.Class1.IsValidPhone(text[1].Text))
                {
                    MessageBox.Show("Vui lòng kiểm tra lại số điện thoại!");
                    return false;
                }
            }
            
            return true;
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                nv.name = txtName.Text;
                nv.phone = txtPhone.Text;
                nv.pass = txtPass.Text;
                nv.createdAt = DateTime.Now;
                nv.updatedAt = DateTime.Now;
                nv.status = 1;
                if (cboType.SelectedItem == "Admin")
                {
                    nv.type = cboType.SelectedIndex;
                }
                if (cboType.SelectedItem == "Quản lý")
                {
                    nv.type = cboType.SelectedIndex;
                }
                if (cboType.SelectedItem == "Nhân viên")
                {
                    nv.type = cboType.SelectedIndex;
                }
                if (qlnvBLL.Insert(nv.phone, nv.pass, nv.name, nv.createdAt, nv.updatedAt, nv.status, nv.type))
                {
                    MessageBox.Show("Thêm thành công!");
                }
                Clear();
            }
        }
        
    }
}
