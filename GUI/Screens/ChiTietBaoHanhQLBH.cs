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
using GUI.Popups;

namespace GUI.Screens
{
    public partial class ChiTietBaoHanhQLBH : UserControl
    {
        List<ChiTietBaoHanhDTO> details = new List<ChiTietBaoHanhDTO>();
        List<ChiTietBaoHanhDTO> searchDetails = new List<ChiTietBaoHanhDTO>();
        public ChiTietBaoHanhQLBH()
        {
            InitializeComponent();
            initDatagridView();
            txt_search_ncc.GotFocus += RemoveText;
            txt_search_ncc.LostFocus += AddText;
        }

        private void RemoveText(object sender, EventArgs e)
        {
            if (txt_search_ncc.Text == "Tìm theo số điện thoại")
            {
                txt_search_ncc.Text = "";
                txt_search_ncc.ForeColor = Color.Black;
            }
        }

        private void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_search_ncc.Text))
            {
                txt_search_ncc.Text = "Tìm theo số điện thoại";
                txt_search_ncc.ForeColor = Color.Gray;
            }
        }

        private void initDatagridView()
        {
            dgv_ncc.ColumnCount = 6;
            dgv_ncc.Columns[0].Name = "ID";
            dgv_ncc.Columns[1].Name = "Detail Product ID";
            dgv_ncc.Columns[2].Name = "Customer";
            dgv_ncc.Columns[3].Name = "CreatedAt";
            dgv_ncc.Columns[4].Name = "Out Of Date";
            dgv_ncc.Columns[5].Name = "Status";
            details = ChiTietBaoHanhBLL.GetData();
            loadDataToDataGridView(details);
        }

        private void loadDataToDataGridView(List<ChiTietBaoHanhDTO> details)
        {

            dgv_ncc.Rows.Clear();
            dgv_ncc.Refresh();

            foreach (ChiTietBaoHanhDTO item in details)
            {
                string[] row = new string[] { item.Id.ToString(), item.DetailProductId.ToString(), $"{item.CustomerId}", item.CreatedAt.ToString("dd-MM-yyyy hh:mm:ss"), item.OutOfDate.ToString("dd-MM-yyyy hh:mm:ss"), item.Status == 1 ? "Đã bảo hành" : "Chưa bảo hành" };
                dgv_ncc.Rows.Add(row);
            }
        }


        private void ChiTietBaoHanhQLBH_Load(object sender, EventArgs e)
        {

        }

        private void dgv_ncc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateChiTietBaoHanh update = new UpdateChiTietBaoHanh(details[e.RowIndex]);
            update.ShowDialog();
            if(update.flag == true)
            {
                foreach(ChiTietBaoHanhDTO detail in details)
                {
                    if(detail.Id == update.detail.Id)
                    {
                        detail.Status = update.detail.Status;
                    }
                }
            }

            dgv_ncc.Rows[e.RowIndex].Cells[5].Value = update.detail.Status == 1 ? "Đã bảo hành" : "Chưa bảo hành";

            update.Close();
        }


        private void HandleSearch()
        {
            searchDetails.Clear();
            if (txt_search_ncc.Text == "" || txt_search_ncc.Text == "Tìm theo số điện thoại")
            {
                loadDataToDataGridView(details);
                return;
            }
            foreach(ChiTietBaoHanhDTO detail in details)
            {
                if (detail.CustomerId.IndexOf(txt_search_ncc.Text) != -1)
                {
                    searchDetails.Add(detail);
                }
            }
            loadDataToDataGridView(searchDetails);
        }
        private void btn_search_ncc_Click(object sender, EventArgs e)
        {
            HandleSearch();
        }

        private void txt_search_ncc_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                HandleSearch();
            }
        }
    }
}
