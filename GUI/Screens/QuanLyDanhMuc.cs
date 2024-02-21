using BLL;
using DTO;
using GUI.Popups;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Screens
{
    public partial class QuanLyDanhMuc : UserControl
    {
        List<DanhMucDTO> list = new List<DanhMucDTO>();
        public QuanLyDanhMuc()
        {
            InitializeComponent();
            loadData();
            txt_search.LostFocus += addText;
            txt_search.GotFocus += removeText;
        }

        public void loadData()
        {
            
            dataGridView_danhmuc.ColumnCount = 2;
            dataGridView_danhmuc.Columns[0].Name = "Id"; 
            dataGridView_danhmuc.Columns[1].Name = "Name";
            list = DanhMucBLL.GetDataAction();
            loadDataToDataGridView(list);
        }
        private void loadDataToDataGridView(List<DanhMucDTO> danhmuc)
        {

            dataGridView_danhmuc.Rows.Clear();
            dataGridView_danhmuc.Refresh();

            foreach (DanhMucDTO dm in danhmuc)
            {
                string[] row = new string[] { dm.Id.ToString(), dm.Name };
                dataGridView_danhmuc.Rows.Add(row);
            }
        }
        public int getIdMax(List<DanhMucDTO> danhmuc)
        {
            int id = danhmuc[0].Id;
            foreach(DanhMucDTO d in danhmuc)
            {
                if(d.Id > id)
                {
                    id = d.Id;
                }
            }
            return id;
        }

        private void addText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_search.Text))
            {
                txt_search.Text = "Tìm kiếm theo ID, tên";
                txt_search.ForeColor = Color.Gray;
                txt_search.Font = new Font("Times New Roman", 12F, FontStyle.Italic);
            }
        }

        private void removeText(object sender, EventArgs e)
        {
            if (txt_search.Text == "Tìm kiếm theo ID, tên")
            {
                txt_search.Text = "";
                txt_search.ForeColor = Color.Black;
                txt_search.Font = new Font("Times New Roman", 12F,FontStyle.Regular);
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            AddDanhMuc addDanhMuc = new AddDanhMuc(getIdMax(list)+1);
            addDanhMuc.ShowDialog();
            if (addDanhMuc.flagAdd)
            {
                list.Add(addDanhMuc.danhMuc);
                string[] row = new string[] {addDanhMuc.danhMuc.Id.ToString(), addDanhMuc.danhMuc.Name};
                dataGridView_danhmuc.Rows.Add(row);
                addDanhMuc.flagAdd = false;
                addDanhMuc.Close();

            }
        }

        private void dataGridView_danhmuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_danhmuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView_danhmuc.Rows[e.RowIndex];
            XacNhanThucHien action = new XacNhanThucHien(Convert.ToInt32(row.Cells["Id"].Value));
            action.ShowDialog();

            if(action.value == "delete")
            {
                DialogResult dr =  MessageBox.Show($"Bạn có chắc chắn muốn xóa danh mục {row.Cells["Id"].Value} - {row.Cells["Name"].Value}","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(dr == DialogResult.Yes)
                {
                    bool flag = DanhMucBLL.deleteData(Convert.ToInt32(row.Cells["Id"].Value));
                    if (flag)
                    {
                        list.RemoveAt(e.RowIndex);
                        dataGridView_danhmuc.Rows.Remove(dataGridView_danhmuc.Rows[e.RowIndex]);
                    }
                }
            }
            else if (action.value == "update")
            {
                UpdateDanhMuc uddm = new UpdateDanhMuc(list[e.RowIndex]);
                uddm.ShowDialog();
                if (uddm.flag)
                {
                    foreach (DanhMucDTO item in list)
                    {
                        if (item.Id == uddm.danhmuc.Id)
                        {
                            item.Name = uddm.danhmuc.Name;
                        }
                    }
                    dataGridView_danhmuc.Rows[e.RowIndex].Cells[1].Value = uddm.danhmuc.Name;
                }
                uddm.Close();
            }
            action.Close();
        }

        public void handle_search()
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dataGridView_danhmuc.Refresh();
            dataGridView_danhmuc.Rows.Clear();
            if(txt_search.Text == "Tìm kiếm theo ID, tên" || txt_search.Text == "")
            {
                loadDataToDataGridView(list);
            }
            return;
            List<DanhMucDTO> list_search = new List<DanhMucDTO>();
            foreach (DanhMucDTO dm in list)
            {
                if (this.txt_search.Text == dm.Id.ToString())
                {
                    list_search.Add(dm);
                }
                else if (dm.Name.Contains(this.txt_search.Text))
                {
                    list_search.Add(dm);
                }
            }
            loadDataToDataGridView(list_search);
        }
    }
}
