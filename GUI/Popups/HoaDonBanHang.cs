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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace GUI.Popups
{
    public partial class HoaDonBanHang : Form
    {
        public string idnv { get; set; }
        public string phonekh { get; set; }
        public string idhd { get; set; }
        public string day { get; set; }
        public string namesp { get; set; }

        public string quantity { get; set; }
        public string prices { get; set; }

        public string total { get; set; }

        public hoadonDTO bills;
        public HoaDonBanHang(string idnv, string phonekh, string idhd,string day, string total)
        {
            this.idnv = idnv;
            this.phonekh = phonekh;
            this.idhd = idhd;
            this.day = day;
            this.namesp = namesp;
            this.quantity = quantity;
            this.prices = prices;
            this.total = total;
            InitializeComponent();
            show();
            this.total = total;
        }

        public void show()
        {

            txt_idnv.Text = idnv;
            txt_idnv.Enabled = false;
            txt_phonekh.Text = phonekh;
            txt_phonekh.Enabled = false;
            txt_idhd.Text = idhd;
            txt_idhd.Enabled = false;
            txt_day.Text = day;
            txt_day.Enabled = false;

       
            lbl_total.Text = total;
            InitDataGridView();


        }


        void InitDataGridView()
        {
            dgv_hoadon.ColumnCount = 3;
            dgv_hoadon.Columns[0].HeaderText = "Tên sản phẩm";
            dgv_hoadon.Columns[1].HeaderText = "Số lượng";
            dgv_hoadon.Columns[2].HeaderText = "Giá";
            LoadDataToDataGridView(NhapHangQLSP.cart);
        }

        void LoadDataToDataGridView(List<spnccDTO> list) 
        {
            dgv_hoadon.Rows.Clear();
            dgv_hoadon.Refresh();
            foreach(spnccDTO item in list)
            {
                string[] row = new string[] { item.Name, item.Quantity.ToString(), item.Prices.ToString() };
                dgv_hoadon.Rows.Add(row);

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txt_day_TextChanged(object sender, EventArgs e)
        {

        }

        private void HoaDonBanHang_Load(object sender, EventArgs e)
        {

        }
    }
}
