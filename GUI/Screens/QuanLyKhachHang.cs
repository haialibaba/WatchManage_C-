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
    public partial class QuanLyKhachHang : UserControl
    {
        private KhachHangBLL qlkhBLL = new KhachHangBLL();
        private List<KhachHangDTO> dskh;
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void btnAdd_KH_Click(object sender, EventArgs e)
        {
            new AddKhachHang().Show();
        }

        private void btnReload_KH_Click(object sender, EventArgs e)
        {
            dataGridView_KH.DataSource = qlkhBLL.Display();
            txtFind_KH.Clear();
        }
        DataGridViewButtonColumn btn1, btn2;
        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            dataGridView_KH.DataSource = qlkhBLL.Display();
            btn1 = new DataGridViewButtonColumn();
            btn1.Name = "colUpdate";
            btn1.Text = "Sửa";
            btn1.HeaderText = "";
            btn1.UseColumnTextForButtonValue = true;
            dataGridView_KH.Columns.Add(btn1);

            btn2 = new DataGridViewButtonColumn();
            btn2.Name = "colDelete";
            btn2.Text = "Xoá";
            btn2.HeaderText = "";
            btn2.UseColumnTextForButtonValue = true;
            dataGridView_KH.Columns.Add(btn2);
        }

        private void btnSearch_KH_Click(object sender, EventArgs e)
        {
            string searchValue = txtFind_KH.Text;
            dataGridView_KH.DataSource = qlkhBLL.Show(searchValue);
        }

        private void dataGridView_KH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dataGridView_KH.Columns[e.ColumnIndex].Name;
            if(colname == "colUpdate")
            {
                dskh = qlkhBLL.readDB();
                string sdt = dataGridView_KH.Rows[e.RowIndex].Cells["Số điện thoại"].Value.ToString();
                foreach (KhachHangDTO kh in dskh)
                {
                    if (kh.Phone.Equals(sdt))
                    {
                        new UpdateKhachHang(kh).Show();
                    }
                }
            }
            
            if(colname == "colDelete")
            {
                dskh = qlkhBLL.readDB();
                if(MessageBox.Show("Bạn chắc chắn muốn xoá dòng này?") == DialogResult.OK)
                {
                    string index = dataGridView_KH.Rows[e.RowIndex].Cells["Số điện thoại"].Value.ToString();
                    qlkhBLL.DeleteKH(index);
                    dataGridView_KH.Rows.RemoveAt(e.RowIndex); //Xoá trực tiếp trên DataGridView nhưng ko xoá trong CSDL
                    MessageBox.Show("Đã xoá thành công!");
                }
            }
            dataGridView_KH.DataSource = qlkhBLL.Display();
        }
    }
}
