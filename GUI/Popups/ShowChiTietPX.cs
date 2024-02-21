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
    public partial class ShowChiTietPX : Form
    {
        List<ChiTietPhieuDTO> listChiTietPX = new List<ChiTietPhieuDTO>();
        public ShowChiTietPX(int id, string TenNV, string TenKH)
        {
            InitializeComponent();
            lbl_maHD.Text = id.ToString();
            lbl_tenNV.Text = TenNV;
            lbl_tenKH.Text = TenKH;
            initDataGridView(id);
        }


        public void initDataGridView(int id)
        {
            dataGridView_px.ColumnCount = 4;
            dataGridView_px.Columns[0].Name = "Tên Sản Phẩm";
            dataGridView_px.Columns[1].Name = "Giá Sản Phẩm";
            dataGridView_px.Columns[2].Name = "Số lượng Sản Phẩm";
            dataGridView_px.Columns[3].Name = "Thành Tiền";
            listChiTietPX = ShowChiTietPhieuXuatBLL.getDataAction(id);
            loadData();
        }

        public void loadData()
        {
            dataGridView_px.Rows.Clear();
            dataGridView_px.Refresh();
            foreach (ChiTietPhieuDTO ct in listChiTietPX)
            {
                string[] row = new string[] { ct.product_name,ct.price.ToString(),ct.quantity.ToString(),ct.intoMoney.ToString() };
                dataGridView_px.Rows.Add(row);
            }
        }

        private void ShowChiTietPX_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_px_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_export_Click(object sender, EventArgs e)
        {

            dataGridView_px.SelectAll();
            DataObject copydata = dataGridView_px.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object miseddata = System.Reflection.Missing.Value;
            xlWbook = xlapp.Workbooks.Add(miseddata);

            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();
            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }    
    }
}
