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
using GUI.Screens;

namespace GUI.Popups
{
    public partial class UpdateNhanVien : Form
    {
        NhanVienBLL qlnvBLL = new NhanVienBLL();
        NhanVienDTO nv = new NhanVienDTO(); 
        public UpdateNhanVien(NhanVienDTO nv)
        {
            InitializeComponent();
            txtName.Text = nv.name;
            txtPass.Text = nv.pass;
            txtPhone.Text = nv.phone;
            if(nv.type == 0)
            {
                cboType.Text = "Admin";
            }
            if (nv.type == 1)
            {
                cboType.Text = "Quản lý";
            }
            if (nv.type == 2)
            {
                cboType.Text = "Nhân viên";
            }
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
            if (cboType.Text == "")
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

        public void Clear()
        {
            txtName.Text = txtPhone.Text = txtPass.Text = cboType.Text = string.Empty;
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (Check())
            {
                nv.name = txtName.Text;
                nv.phone = txtPhone.Text;
                nv.pass = txtPass.Text;
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
                if (qlnvBLL.Update(nv.phone, nv.pass, nv.name, nv.createdAt, nv.updatedAt, nv.status, nv.type))
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                Clear();
            }
        }
    }
}
