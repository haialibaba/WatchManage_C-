using BLL;
using DTO;
using GUI.Popups;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Screens
{
    public partial class UCXuat : UserControl
    {
        public static List<XuatDTO> phieuXuat = new List<XuatDTO>();
        public static List<XuatDTO> list_Search = new List<XuatDTO>();
        public UCXuat()
        {
            InitializeComponent();
            initDataGridView();
            loadData(phieuXuat);

        }

        public void initDataGridView()
        {
            dataGridView_Xuat.ColumnCount = 5;
            dataGridView_Xuat.Columns[0].Name = "Id"; 
            dataGridView_Xuat.Columns[1].Name = "Ngày Tạo Hóa Đơn"; 
            dataGridView_Xuat.Columns[2].Name = "Tên Nhân Viên"; 
            dataGridView_Xuat.Columns[3].Name = "Tổng Tiền"; 
            dataGridView_Xuat.Columns[4].Name = "Tên Khách Hàng";
            phieuXuat = XuatBLL.getDataAction();
        }
        public void loadData(List<XuatDTO> px)
        {
            dataGridView_Xuat.Rows.Clear();
            dataGridView_Xuat.Refresh();
            foreach(XuatDTO x in px)
            {
                string[] row = new string[] { x.id.ToString(),x.createdAt.ToString("dd-MM-yyyy"), x.staff_name.ToString(), x.total.ToString(), x.customer_name.ToString() };
                dataGridView_Xuat.Rows.Add(row);
            }
        }
        public void loadData()
        {
            dataGridView_Xuat.Rows.Clear();
            dataGridView_Xuat.Refresh();
            foreach (XuatDTO x in phieuXuat)
            {
                string[] row = new string[] { x.id.ToString(), x.createdAt.ToString("dd-MM-yyyy"), x.staff_name.ToString(), x.total.ToString(), x.customer_name.ToString() };
                dataGridView_Xuat.Rows.Add(row);
            }
        }


        private void dataGridView_Xuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView_Xuat.Rows[e.RowIndex];
            int maHD = Convert.ToInt16(row.Cells["Id"].Value);
            string tenNV = Convert.ToString(row.Cells["Tên Nhân Viên"].Value);
            string tenKH = Convert.ToString(row.Cells["Tên Khách Hàng"].Value);
            ShowChiTietPX showPX = new ShowChiTietPX(maHD,tenNV,tenKH);
            showPX.ShowDialog();
        }

        public void getDateTime()
        {

        }

        private void dataGridView_Xuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            list_Search.Clear();
            DateTime startTime = dtp_start.Value;
            DateTime endTime = dtp_end.Value;
            foreach(XuatDTO item in phieuXuat)
            {
                if(startTime <= item.createdAt && item.createdAt <= endTime)
                {
                    list_Search.Add(item);
                }
            }
            loadData(list_Search);
        }
    }
}
