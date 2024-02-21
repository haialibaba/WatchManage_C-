using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HideBordersButton();
            trangChu1.BringToFront();
            ActiveSideBar(btn_home);
            lbl_user.Text = Login.user.Name;

        }
        public void HideBorderButton(Button btn)
        {
            btn.TabStop = false;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
        }

        public void HideBordersButton()
        {
            HideBorderButton(btn_banhang);
            HideBorderButton(btn_home);
            HideBorderButton(btn_sanpham);
            HideBorderButton(btn_danhmuc);
            HideBorderButton(btn_nhacungcap);
            HideBorderButton(btn_nhanvien);
            HideBorderButton(btn_khachhang);
            HideBorderButton(btn_logout);
            HideBorderButton(btn_baohanh);
            HideBorderButton(btn_thongke);
            HideBorderButton(btn_nhapxuat);
            HideBorderButton(btn_phanquyen);
        }

        public void ActiveSideBar(Button btn)
        {
            btn_banhang.BackColor = Color.Transparent;
            btn_home.BackColor = Color.Transparent;
            btn_sanpham.BackColor = Color.Transparent;
            btn_danhmuc.BackColor = Color.Transparent;
            btn_nhacungcap.BackColor = Color.Transparent;
            btn_nhanvien.BackColor = Color.Transparent;
            btn_baohanh.BackColor = Color.Transparent;
            btn_thongke.BackColor = Color.Transparent;
            btn_nhapxuat.BackColor = Color.Transparent;
            btn_khachhang.BackColor = Color.Transparent;
            btn_phanquyen.BackColor = Color.Transparent;
            btn.BackColor = Color.FromArgb(58, 0, 142);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hide_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            trangChu1.BringToFront();
            ActiveSideBar(btn_home);
        }

        private void btn_banhang_Click(object sender, EventArgs e)
        {
            banHang1.BringToFront();
            ActiveSideBar(btn_banhang);
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            quanLySanPham1.BringToFront();
            ActiveSideBar(btn_sanpham);
        }

        private void btn_danhmuc_Click(object sender, EventArgs e)
        {
            quanLyDanhMuc1.BringToFront();
            quanLyDanhMuc1.loadData();
            ActiveSideBar(btn_danhmuc);
        }

        private void btn_nhacungcap_Click(object sender, EventArgs e)
        {
            quanLyNhaCungCap1.BringToFront();
            ActiveSideBar(btn_nhacungcap);
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            quanLyNhanVien1.BringToFront();
            ActiveSideBar(btn_nhanvien);
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            quanLyKhachHang1.BringToFront();
            ActiveSideBar(btn_khachhang);
        }

        private void btn_baohanh_Click(object sender, EventArgs e)
        {
            quanLyBaoHanh1.BringToFront();
            ActiveSideBar(btn_baohanh);
        }

        private void btn_nhapxuat_Click(object sender, EventArgs e)
        {
            nhapXuat1.BringToFront();
            nhapXuat1.btn_pxuat_Click(sender,e);
            ActiveSideBar(btn_nhapxuat);
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            thongKe1.BringToFront();
            ActiveSideBar(btn_thongke);
        }

        private void btn_phanquyen_Click(object sender, EventArgs e)
        {
            phanQuyen1.BringToFront();
            ActiveSideBar(btn_phanquyen);
        }
    }
}
