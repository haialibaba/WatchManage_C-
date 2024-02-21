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
    public partial class HoaDonNhapHang : Form
    {
        public HoaDonNhapHang()
        {
            InitializeComponent();
        }

        public HoaDonNhapHang(string idNv, string idHoaDon, DateTime date, int total)
        {
            InitializeComponent();

            lbl_nv.Text = idNv;
            lbl_total.Text = $"{total.ToString()} VND";
            lbl_hoadon.Text = idHoaDon;
            lbl_createdAt.Text = date.ToShortDateString();
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
            foreach (spnccDTO item in list)
            {
                string[] row = new string[] { item.Name, item.Quantity.ToString(), item.Prices.ToString() };
                dgv_hoadon.Rows.Add(row);

            }
        }
        private void HoaDonNhapHang_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
