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
    public partial class UpdateKhachHang : Form
    {
        KhachHangBLL qlkhBLL = new KhachHangBLL();
        KhachHangDTO kh = new KhachHangDTO();
        
        public UpdateKhachHang(KhachHangDTO kh)
        {
            InitializeComponent();
            txtPhone.Text = kh.Phone;
            txtName.Text = kh.Name;
        }

        public bool Check()
        {
            TextBox[] text = { txtPhone, txtName };
            foreach (TextBox txt in text)
            {
                if (txt.Text == "")
                {
                    MessageBox.Show("Không được để trống thông tin!");

                    txt.Focus();
                    return false;
                }
            }
            //Kiểm tra định dạng số điện thoại
            if (text[0].Text != null)
            {
                if(!BLL.Class1.IsValidPhone(text[0].Text))
                {
                    MessageBox.Show("Vui lòng kiểm tra lại số điện thoại!");
                    return false;
                }
            }
            return true;
        }

        public void Clear()
        {
            txtName.Text = txtPhone.Text = string.Empty;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                kh.Name = txtName.Text;
                kh.Phone = txtPhone.Text;
                kh.ToTal = 0;
                kh.UpdatedAt = DateTime.Now;
                kh.Status = 1;

                if (qlkhBLL.UpdateKH(kh.Phone, kh.Name, kh.CreatedAt, kh.UpdatedAt, kh.ToTal, kh.Status))
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                Clear();
            }
        }
    }
}
