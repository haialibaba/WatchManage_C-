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

namespace GUI
{
    public partial class Login : Form
    {
        public static string id_Privilege_group;
        public static List<string> listUrlMatch = new List<string>();
        public List<LoginDTO> list = new List<LoginDTO>();
        public static LoginDTO user;
        public Login()
        {
            InitializeComponent();
            list = LoginBLL._GetDataLogin();
           /* LoginDTO lgDTO = new LoginDTO("admin", "123456", "0");
            list.Add(lgDTO);*/
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Bạn không được bỏ trống số điện thoại và mật khẩu!!!", "Thông báo");
                return;
            }
            else if (textBox1.Text != "" && textBox2.Text == "")
            {
                MessageBox.Show("Bạn không được bỏ trống mật khẩu!!!", "Thông báo");
                return;
            }
            else if (textBox1.Text == "" && textBox2.Text != "")
            {
                MessageBox.Show("Bạn không được bỏ trống số điện thoại!!!", "Thông báo");
                return;
            }
            int check = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Username ==textBox1.Text &&  list[i].Password== textBox2.Text)
                {
                    user = list[i];
                    MessageBox.Show("Đăng nhập thành công!!!", "Thông báo");
                    id_Privilege_group = list[i].id;
                    listUrlMatch = LoginBLL._GetDataUrlMatch(id_Privilege_group);
                    Form1 mf = new Form1();
                    this.Hide();
                    mf.ShowDialog();
                    check = 1;
                }
            }
            if (check == 0)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!!!", "Thông báo");
            }
        }
        public static bool _checkUrlMatch(string urlMatch)
        {
            for (int i=0; i< Login.listUrlMatch.Count; i++)
            {
                if(urlMatch== listUrlMatch[i])
                {
                    return true;
                }
            }
            return false;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }
}
