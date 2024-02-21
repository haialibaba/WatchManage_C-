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
using System.Xml.Linq;

namespace GUI.Popups
{
    public partial class ModalPopupAddDMNV : Form
    {
        public Label lbl_IDDMNV, lbl_TenDMNV;
        public TextBox txt_IDDMNV, txt_TenDMNV;
        public Button btn_OK, btn_reset;
        public FlowLayoutPanel pnl, pnl1, pnl2;
        public Panel pnl_footer;
        public int id;
        public PhanQuyenDTO pqdto;
        public  bool flagaddDMNV=false;
        public ModalPopupAddDMNV(int id)
        {
            this.id = id + 1;
            InitializeComponent();
            init();
        }

        public void init()
        {
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
                Text = id + "",
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
                Size = new Size(200, 20),
                Font = new Font("Times New Roman", 12.0f, FontStyle.Bold),
            };
            pnl2.Controls.Add(txt_TenDMNV);

            //*****************************************

            pnl_footer = new Panel();
            pnl_footer.SetBounds(90, 210, 260, 50);
            this.Controls.Add(pnl_footer);

            //*****************************************

            btn_OK = new Button()
            {
                Text = "Thêm",
                Font = new Font("Times New Roman", 12.0f, FontStyle.Bold),
                Size = new Size(100, 30),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Left,
                BackColor = Color.Pink,
            };
            btn_OK.Click += Btn_OK_Click;
            pnl_footer.Controls.Add(btn_OK);

            //*****************************************

            btn_reset = new Button()
            {
                Text = "Reset",
                Font = new Font("Times New Roman", 12.0f, FontStyle.Bold),
                Size = new Size(100, 30),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Right,
                BackColor = Color.Pink,
            };
            btn_reset.Click += Btn_reset_Click;
            pnl_footer.Controls.Add(btn_reset);
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if (txt_TenDMNV.Text == "")
            {
                MessageBox.Show("Không được bỏ trống tên danh mục nhân viên!!!","Thông báo");
            }
            else
            {
                if (PhanQuyenBLL.AddData(int.Parse(txt_IDDMNV.Text), txt_TenDMNV.Text) == false)
                {
                    MessageBox.Show("Thêm thất bại!!!", "Thông báo");
                }
                else
                {
                    PhanQuyenBLL.AddData(int.Parse(txt_IDDMNV.Text), txt_TenDMNV.Text);
                    pqdto = new PhanQuyenDTO(int.Parse(txt_IDDMNV.Text), txt_TenDMNV.Text, DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff"), DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff"), "1");
                    flagaddDMNV = true;
                    MessageBox.Show("Thêm thành công!!!", "Thông báo");
                    this.Hide();
                }
            }
        }

        private void Btn_reset_Click(object sender, EventArgs e)
        {
            txt_TenDMNV.Text = "";
        }

        private void ModalPopupAddDMNV_Load(object sender, EventArgs e)
        {

        }
    }
}
