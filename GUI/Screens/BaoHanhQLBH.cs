using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Popups;
using DTO;
using BLL;

namespace GUI.Screens
{
    public partial class BaoHanhQLBH : UserControl
    {
        List<BaoHanhDTO> maintains = new List<BaoHanhDTO>();
        List<PProducerDTO> products = new List<PProducerDTO>();

        List<BaoHanhDTO> searchMaintain = new List<BaoHanhDTO>();
        public BaoHanhQLBH()
        {
            InitializeComponent();
            initDatagridView();
            txt_search_ncc.GotFocus += RemoveText;
            txt_search_ncc.LostFocus += AddText;
        }

        private void btn_add_ncc_Click(object sender, EventArgs e)
        {
            AddBaoHanh add = new AddBaoHanh(getIdMax(maintains) + 1, maintains);
            add.ShowDialog();
            if(add.flag == true)
            {
                maintains.Add(add.maintain);
                string[] row = new string[] { add.maintain.Id.ToString(), add.maintain.ProductId.ToString(), $"{add.maintain.Time.ToString()} ngày", add.maintain.CreatedAt.ToString("dd-MM-yyyy hh:mm:ss"), add.maintain.UpdatedAt.ToString("dd-MM-yyyy hh:mm:ss") };
                dgv_ncc.Rows.Add(row);
                add.flag = false;
                add.Close();
            }
        }

        private int getIdMax(List<BaoHanhDTO> maintains)
        {
            int max = 0;
            foreach(BaoHanhDTO item in maintains)
            {
                if(item.Id > max)
                {
                    max = item.Id;
                }
            }
            return max;

        }

        private void BaoHanhQLBH_Load(object sender, EventArgs e)
        {
          
        }

        private void RemoveText(object sender, EventArgs e)
        {
            if (txt_search_ncc.Text == "Tìm kiếm theo ID, tên")
            {
                txt_search_ncc.Text = "";
                txt_search_ncc.ForeColor = Color.Black;
            }
        }

        private void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_search_ncc.Text))
            {
                txt_search_ncc.Text = "Tìm kiếm theo ID, tên";
                txt_search_ncc.ForeColor = Color.Gray;
            }
        }

        private void initDatagridView()
        {
            dgv_ncc.ColumnCount = 5;
            dgv_ncc.Columns[0].Name = "ID";
            dgv_ncc.Columns[1].Name = "Product ID";
            dgv_ncc.Columns[2].Name = "Time";
            dgv_ncc.Columns[3].Name = "CreatedAt";
            dgv_ncc.Columns[4].Name = "UpdatedAt";
            maintains = BaoHanhBLL.GetData();
            products = SanPhamNhaCungCapBLL.GetData();
            loadDataToDataGridView(maintains);
        }

        private void loadDataToDataGridView(List<BaoHanhDTO> maintains)
        {

            dgv_ncc.Rows.Clear();
            dgv_ncc.Refresh();

            foreach (BaoHanhDTO item in maintains)
            {
                string[] row = new string[] { item.Id.ToString(), item.ProductId.ToString(), $"{item.Time.ToString()} ngày", item.CreatedAt.ToString("dd-MM-yyyy hh:mm:ss"), item.UpdatedAt.ToString("dd-MM-yyyy hh:mm:ss") };
                dgv_ncc.Rows.Add(row);
            }
        }

        private void dgv_ncc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            XacNhanThucHien confirm = new XacNhanThucHien(maintains[e.RowIndex].Id);
            confirm.ShowDialog();
            if(confirm.value == "delete")
            {
                if (MessageBox.Show($"Bạn có chắc chắn muốn xóa bảo hành của SP {maintains[e.RowIndex].ProductId}?", "Cảnh báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    bool flag = BaoHanhBLL.DeleteData(maintains[e.RowIndex].Id);
                    if (flag == true)
                    {
                        maintains.RemoveAt(e.RowIndex);
                        dgv_ncc.Rows.Remove(dgv_ncc.Rows[e.RowIndex]);

                    }

                }
            }else if(confirm.value == "update")
            {
                List<PProducerDTO> listProduct = new List<PProducerDTO>();

               

                foreach(PProducerDTO product in products)
                {
                    if (product.Id == maintains[e.RowIndex].ProductId)
                    {
                        listProduct.Add(product);
                    }
                    bool isExist = false;
                    foreach(BaoHanhDTO item in maintains)
                    {
                         if(item.ProductId == product.Id)
                        {
                            isExist = true;
                        }
                    }

                    if (!isExist)
                    {
                        listProduct.Add(product);
                    }
                }

                UpdateBaoHanh update = new UpdateBaoHanh(maintains[e.RowIndex], listProduct);
                update.ShowDialog();

                if(update.flag == true)
                {
                    foreach(BaoHanhDTO maintain in maintains)
                    {
                        if(maintain.Id == update.maintain.Id)
                        {
                            maintain.ProductId = update.maintain.Id;
                            maintain.Time = update.maintain.Time;
                            maintain.UpdatedAt = update.maintain.UpdatedAt;
                            break;
                        }
                    }

                    dgv_ncc.Rows[e.RowIndex].Cells[1].Value = update.maintain.ProductId;
                    dgv_ncc.Rows[e.RowIndex].Cells[2].Value = $"{update.maintain.Time} ngày";
                    dgv_ncc.Rows[e.RowIndex].Cells[4].Value = update.maintain.UpdatedAt.ToString("dd-MM-yyyy hh:mm:ss");
                }

                update.Close();
            }

            confirm.Close();
        }

        private void HandleSearch()
        {
            if (txt_search_ncc.Text == "" || txt_search_ncc.Text == "Tìm kiếm theo ID, tên")
            {
                loadDataToDataGridView(maintains);
                return;
            }
            foreach (BaoHanhDTO item in maintains)
            {
                if (item.Id.ToString().IndexOf(txt_search_ncc.Text) != -1)
                {
                    searchMaintain.Add(item);
                }
                else if (item.ProductId.ToString().IndexOf(txt_search_ncc.Text) != -1)
                {
                    searchMaintain.Add(item);
                }
            }
            loadDataToDataGridView(searchMaintain);
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
