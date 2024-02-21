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
    public partial class ShowChiTietPN : Form
    {
        List<ChiTietPhieuDTO> chiTietPhieuNhap = new List<ChiTietPhieuDTO>();
        public ShowChiTietPN(int maHD, string tenNV, string tenNCC)
        {
            InitializeComponent();
            lbl_maHD.Text = maHD.ToString();
            lbl_tenNV.Text = tenNV;
            lbl_tenNCC.Text = tenNCC;
            this.initDataGridView(maHD);
        }
        

        public void initDataGridView(int id)
        {
            dataGridView_pn.ColumnCount = 4;
            dataGridView_pn.Columns[0].Name = "Tên Sản Phẩm";
            dataGridView_pn.Columns[1].Name = "Giá Sản Phẩm";
            dataGridView_pn.Columns[2].Name = "Số lượng Sản Phẩm";
            dataGridView_pn.Columns[3].Name = "Thành Tiền";
            chiTietPhieuNhap = ShowChiTietPhieuNhapBLL.getDataAction(id);
            loadData();
        }

        public void loadData()
        {
            dataGridView_pn.Rows.Clear();
            dataGridView_pn.Refresh();
            foreach (ChiTietPhieuDTO ct in chiTietPhieuNhap)
            {
                string[] row = new string[] { ct.product_name, ct.price.ToString(), ct.quantity.ToString(), ct.intoMoney.ToString() };
                dataGridView_pn.Rows.Add(row);
            }
        }

        private void dataGridView_pn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
