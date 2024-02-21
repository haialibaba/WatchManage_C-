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
using BLL;
using DTO;

namespace GUI.Screens
{
    public partial class NhaCungCap : UserControl
    {
        List<NhaCungCapDTO> producers = new List<NhaCungCapDTO>();
        List<NhaCungCapDTO> searchProducers = new List<NhaCungCapDTO>();
        public NhaCungCap()
        {
            InitializeComponent();
            initDatagridView();
            txt_search_ncc.GotFocus += RemoveText;
            txt_search_ncc.LostFocus += AddText;
        }

        private void initDatagridView()
        {
            dgv_ncc.ColumnCount = 6;
            dgv_ncc.Columns[0].Name = "ID";
            dgv_ncc.Columns[1].Name = "Name";
            dgv_ncc.Columns[2].Name = "Phone Number";
            dgv_ncc.Columns[3].Name = "CreatedAt";
            dgv_ncc.Columns[4].Name = "UpdatedAt";
            dgv_ncc.Columns[5].Name = "Status";
            producers = NhaCungCapBLL.GetData();
            loadDataToDataGridView(producers);
        }

        private void RemoveText(object sender, EventArgs e)
        {
            if (txt_search_ncc.Text == "Tìm kiếm theo ID, tên, sdt...")
            {
                txt_search_ncc.Text = "";
                txt_search_ncc.ForeColor = Color.Black;
            }
        }

        private void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_search_ncc.Text))
            {
                txt_search_ncc.Text = "Tìm kiếm theo ID, tên, sdt...";
                txt_search_ncc.ForeColor = Color.Gray;
            }
        }

        private void btn_add_ncc_Click(object sender, EventArgs e)
        {
            
            AddNhaCungCap AddNcc = new AddNhaCungCap(getIdMax(producers) + 1);
            AddNcc.ShowDialog();
            if(AddNcc.flagAdd == true)
            {
                producers.Add(AddNcc.producerAdd);
                string[] row = new string[] { AddNcc.producerAdd.Id.ToString(), AddNcc.producerAdd.Name, AddNcc.producerAdd.PhoneNumber, AddNcc.producerAdd.CreatedAt.ToString("dd-MM-yyyy hh:mm:ss"), AddNcc.producerAdd.UpdatedAt.ToString("dd-MM-yyyy hh:mm:ss"), AddNcc.producerAdd.Status == 1 ? "Hoạt động" : "Bị khóa" };
                dgv_ncc.Rows.Add(row);
                AddNcc.flagAdd = false;
                AddNcc.Close();
            }
        }

        private int getIdMax(List<NhaCungCapDTO> producers)
        {
            int id = producers.Count > 0 ? producers[0].Id : 0;
            foreach (NhaCungCapDTO producer in producers)
            {
                if(producer.Id > id)
                {
                    id = producer.Id;
                }
            }

            return id;
        }

        private void loadDataToDataGridView(List<NhaCungCapDTO> producers)
        {

            dgv_ncc.Rows.Clear();
            dgv_ncc.Refresh();
   
            foreach (NhaCungCapDTO producer in producers)
            {
                string[] row = new string[] { producer.Id.ToString(),producer.Name, producer.PhoneNumber, producer.CreatedAt.ToString("dd-MM-yyyy hh:mm:ss"), producer.UpdatedAt.ToString("dd-MM-yyyy hh:mm:ss"), producer.Status == 1 ? "Hoạt động" : "Bị khóa" };
                dgv_ncc.Rows.Add(row);
            }
        }

        private void dgv_ncc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            XacNhanThucHien confirm = new XacNhanThucHien(producers[e.RowIndex].Id);
            confirm.ShowDialog();
            if(confirm.value == "delete")
            {
               if(MessageBox.Show($"Bạn có chắc chắn muốn xóa nhà cung cấp {producers[e.RowIndex].Name}?", "Cảnh báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    bool flag = NhaCungCapBLL.DeleteData(producers[e.RowIndex].Id);
                    if(flag == true)
                    {
                        producers.RemoveAt(e.RowIndex);
                        dgv_ncc.Rows.Remove(dgv_ncc.Rows[e.RowIndex]);
                       
                    }
                   
                }
            }else if(confirm.value == "update")
            {
                UpdateNhaCungCap update = new UpdateNhaCungCap(producers[e.RowIndex]);
                update.ShowDialog();
                if(update.flag == true)
                {
                    foreach(NhaCungCapDTO item in producers)
                    {
                        if(item.Id == update.producer.Id)
                        {
                            item.Name = update.producer.Name;
                            item.PhoneNumber = update.producer.PhoneNumber;
                            item.UpdatedAt = update.producer.UpdatedAt;
                            item.Status = update.producer.Status;
                            break;
                        }
                    }
                    dgv_ncc.Rows[e.RowIndex].Cells[1].Value = producers[e.RowIndex].Name;
                    dgv_ncc.Rows[e.RowIndex].Cells[2].Value = producers[e.RowIndex].PhoneNumber;
                    dgv_ncc.Rows[e.RowIndex].Cells[4].Value = producers[e.RowIndex].UpdatedAt.ToString("dd-MM-yyyy hh:mm:ss");
                    dgv_ncc.Rows[e.RowIndex].Cells[5].Value = producers[e.RowIndex].Status == 1 ? "Hoạt động" : "Bị khóa";
                    update.flag = false;
                }
                update.Close();
                
            }
            confirm.Close();
        }

        private void HandleSearch()
        {
            searchProducers.Clear();
            if (txt_search_ncc.Text.Trim() == "" || txt_search_ncc.Text.Trim() == "Tìm kiếm theo ID, tên, sdt...")
            {
                loadDataToDataGridView(producers);
                return;
            }
            foreach (NhaCungCapDTO producer in producers)
            {
                if (producer.Id.ToString() == txt_search_ncc.Text)
                {
                    searchProducers.Add(producer);
                }
                else if (producer.Name.ToUpper().IndexOf(txt_search_ncc.Text.ToUpper()) != -1)
                {
                    searchProducers.Add(producer);
                }
                else if (producer.PhoneNumber.IndexOf(txt_search_ncc.Text) != -1)
                {
                    searchProducers.Add(producer);
                }
            }
            loadDataToDataGridView(searchProducers);
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

        private void NhaCungCap_Load(object sender, EventArgs e)
        {

        }

        private void dgv_ncc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
