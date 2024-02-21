using BLL;
using DTO;
using GUI.Screens;
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
    public partial class ModalPopupUpdateDMNV : Form
    {
        public Label lbl_IDDMNV, lbl_TenDMNV;
        public TextBox txt_IDDMNV, txt_TenDMNV;
        public Button btn_OK, btn_reset, btn_del;
        public FlowLayoutPanel pnl, pnl1, pnl2;
        public Panel pnl_footer;
        public string iddmnv, namedmnv, createAtdmnv;
        public PhanQuyenDTO pqdto;
        public bool flagupdate = false;
        public bool flagdelete = false;
        public List<string> listCheckDel = new List<string>();
        public ModalPopupUpdateDMNV(string iddmnv, string namedmnv, string createAtdmnv)
        {
            this.iddmnv = iddmnv;
            this.namedmnv = namedmnv;
            this.createAtdmnv = createAtdmnv;
            listCheckDel = PhanQuyenBLL.GetDataStaffCheckDEL();
            InitializeComponent();
            init();
        }
        public void init()
        {
            //******************************************************

            this.BackColor = Color.Gray;
            pnl = new FlowLayoutPanel();
            pnl.SetBounds(20, 20, 400, 180);
            this.Controls.Add(pnl);

            //*****************************************

            pnl1 = new FlowLayoutPanel();
            pnl1.SetBounds(0, 20, 394, 80);
            pnl.Controls.Add(pnl1);
            //*****************************************

            lbl_IDDMNV = new Label()
            {
                Size = new Size(180, 30),
                Text = "ID danh mục nhân viên:",
                Font = new Font("Times New Roman", 12.0f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };
            pnl1.Controls.Add(lbl_IDDMNV);

            //*****************************************

            txt_IDDMNV = new TextBox()
            {
                Text = iddmnv,
                Enabled = false,
                Size = new Size(200, 20),
                Font = new Font("Times New Roman", 12.0f, FontStyle.Bold),
            };
            pnl1.Controls.Add(txt_IDDMNV);

            //*****************************************

            pnl2 = new FlowLayoutPanel();
            pnl2.SetBounds(0, 20, 394, 80);
            pnl.Controls.Add(pnl2);

            //****************************************

            lbl_TenDMNV = new Label()
            {
                Size = new Size(180, 30),
                Text = "Tên danh mục nhân viên:",
                Font = new Font("Times New Roman", 12.0f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };
            pnl2.Controls.Add(lbl_TenDMNV);

            //*****************************************

            txt_TenDMNV = new TextBox()
            {
                Text = namedmnv,
                Size = new Size(200, 20),
                Font = new Font("Times New Roman", 12.0f, FontStyle.Bold),
            };
            pnl2.Controls.Add(txt_TenDMNV);

            //*****************************************   440

            pnl_footer = new Panel();
            pnl_footer.SetBounds(70, 210, 300, 50);
            this.Controls.Add(pnl_footer);

            //*****************************************

            btn_OK = new Button()
            {
                BackColor = Color.Pink,
                Text = "Sửa",
                Font = new Font("Times New Roman", 12.0f, FontStyle.Bold),
                Size = new Size(100, 30),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Left,
            };
            btn_OK.Click += Btn_OK_Click;
            pnl_footer.Controls.Add(btn_OK);

            //****************************************

            btn_reset = new Button()
            {
                BackColor = Color.Pink,
                Text = "Reset",
                Font = new Font("Times New Roman", 12.0f, FontStyle.Bold),
                Size = new Size(100, 30),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Right,
            };
            pnl_footer.Controls.Add(btn_reset);

            //****************************************

            btn_del = new Button()
            {
                BackColor = Color.Pink,
                Text = "Xóa",
                Font = new Font("Times New Roman", 12.0f, FontStyle.Bold),
                Size = new Size(100, 30),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Right,
            };
            btn_del.Click += Btn_del_Click;
            pnl_footer.Controls.Add(btn_del);
        }

        private void Btn_del_Click(object sender, EventArgs e)
        {
            int check = 0;
            for(int i=0; i< listCheckDel.Count; i++)
            {
                if (listCheckDel[i]== txt_IDDMNV.Text)
                {
                    check = 1;
                }
            }
            if (check == 1)
            {
                MessageBox.Show("Đã có nhân viên thuộc danh mục này nên chưa thể xóa!!!!","Thông báo");
            }
            else
            {
                DialogResult dir = MessageBox.Show("Bạn có muốn xóa danh mục nhân viên này không?", "Hỏi xóa danh mục nhân viên", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dir == DialogResult.Yes)
                {
                    if (PhanQuyenBLL.DeleteData(int.Parse(txt_IDDMNV.Text)) == false)
                    {
                        MessageBox.Show("Xóa thất bại!!!", "Thông báo");
                    }
                    else
                    {
                        PhanQuyenBLL.DeleteData(int.Parse(txt_IDDMNV.Text));
                        pqdto = new PhanQuyenDTO(int.Parse(txt_IDDMNV.Text), txt_TenDMNV.Text, createAtdmnv, DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff"), "0");
                        flagdelete = true;
                        MessageBox.Show("Xóa thành công!!!", "Thông báo");
                        this.Hide();
                    }
                }
            }
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if (txt_TenDMNV.Text == "")
            {
                MessageBox.Show("Không được bỏ trống tên danh mục nhân viên!!!", "Thông báo");
            }
            else
            {
                if (PhanQuyenBLL.UpdateData(int.Parse(txt_IDDMNV.Text), txt_TenDMNV.Text) == false)
                {
                    MessageBox.Show("Update thất bại!!!", "Thông báo");
                }
                else
                {
                    PhanQuyenBLL.UpdateData(int.Parse(txt_IDDMNV.Text), txt_TenDMNV.Text);
                    pqdto = new PhanQuyenDTO(int.Parse(txt_IDDMNV.Text), txt_TenDMNV.Text, createAtdmnv, DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff"), "1");
                    flagupdate = true;
                    MessageBox.Show("Update thành công!!!", "Thông báo");
                    this.Hide();
                }
            }
        }

        private void ModalPopupUpdateDMNV_Load(object sender, EventArgs e)
        {

        }
    }
}
