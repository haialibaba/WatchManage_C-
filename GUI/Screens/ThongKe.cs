using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI.Screens
{
    public partial class ThongKe : UserControl
    {
     

        public Panel pnl_top, pnl_table, pnl_left,
           pnl_mid, pnl_right, pnl_nhap, pnl_xuat, pnl_chiTietNhap, pnl_chiTietXuat, pnl_loc;
        public Label lbl_titleLeft, lbl_titleMid,
            lbl_titleRight, lbl_ngayNhap, lbl_ngayXuat, lbl_tienNhap, lbl_tienXuat, lbl_tongDoanhThu, lbl_dateStart, lbl_dateEnd;
        public Button btn_xemChiTietNhap, btn_xemChiTietXuat, btn_loc;
        public DateTimePicker cld_start, cld_end;
        public ComboBox cbb1;
        List<string> listcbb = new List<string>() { "Sản phẩm", "Nhân viên", "Khách hàng" };
        public DataGridView tbl1;
        public DataTable data;
        private int flagClearTable = 0;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        private void ThongKe_Load(object sender, EventArgs e)
        {

        }
        public ThongKe()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            header();
            table(); 
        }
        public void header()
        {
            pnl_top = new Panel();
            pnl_top.SetBounds(10, 10, 740, 220);
            this.Controls.Add(pnl_top);
            //*******************************
            headerRight();
            ThongKeBLL._getDataGia(cld_start.Value.ToString("yyyy-MM-ddTHH:mm:ss.fff"), cld_end.Value.ToString("yyyy-MM-ddTHH:mm:ss.fff"));
            lbl_tongDoanhThu.Text = ThongKeBLL.tongDoanhThu + " đ";
            //*******************************
            headerLeft();
            headerMid();
        }
        public void headerLeft()
        {
            pnl_left = new Panel()
            {
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = System.Drawing.ColorTranslator.FromHtml("#00BF9E")
            };
            pnl_left.SetBounds(0, 0, 220, 220);
            pnl_top.Controls.Add(pnl_left);

            //************************************************************

            lbl_titleLeft = new Label()
            {
                Text = "Tổng tiền nhập hàng",
                ForeColor = Color.White,
                Font = new Font("Times New Roman", 12.0f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };
            lbl_titleLeft.SetBounds(10, 10, 200, 30);
            pnl_left.Controls.Add(lbl_titleLeft);

            //************************************************************

            lbl_ngayNhap = new Label()
            {
                Text = $"Từ ngày {cld_start.Value.ToString("dd/ MM/ yyyy")} đến ngày {cld_end.Value.ToString("dd/ MM/ yyyy")}",
                ForeColor = Color.White,
                Font = new Font("Times New Roman", 12.0f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
            };
            lbl_ngayNhap.SetBounds(10, 40, 200, 50);
            pnl_left.Controls.Add(lbl_ngayNhap);

            //************************************************************

            lbl_tienNhap = new Label()
            {
                Image = global::GUI.Properties.Resources.icons8_box_50px_1,
                ImageAlign = ContentAlignment.MiddleLeft,
                Text = ThongKeBLL.tienNhap + " đ",
                ForeColor = Color.White,
                Font = new Font("Times New Roman", 14.0f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleRight,
            };
            lbl_tienNhap.SetBounds(10, 90, 200, 50);
            pnl_left.Controls.Add(lbl_tienNhap);

            //************************************************************

            pnl_chiTietNhap = new Panel();
            pnl_chiTietNhap.SetBounds(0, 140, 220, 80);
            pnl_left.Controls.Add(pnl_chiTietNhap);

            //************************************************************
            btn_xemChiTietNhap = new Button()
            {
                Text = "Xem sản phẩm",
                ForeColor = Color.White,
                Font = new Font("Times New Roman", 12.0f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };
            btn_xemChiTietNhap.Click += Btn_xemChiTietNhap_Click;
            btn_xemChiTietNhap.FlatStyle = FlatStyle.Flat;
            btn_xemChiTietNhap.SetBounds(10, 20, 200, 40);
            pnl_chiTietNhap.Controls.Add(btn_xemChiTietNhap);

            //************************************************************

            if (Login._checkUrlMatch("xemsanphamnhap:TK"))
            {
                btn_xemChiTietNhap.Visible = true;
            }else
            {
                btn_xemChiTietNhap.Visible = false;
            }

            //************************************************************

        }

        private void Btn_xemChiTietNhap_Click(object sender, EventArgs e)
        {
            data = new DataTable();
            if (cbb1.SelectedIndex == 0)
            {
                data.Columns.Add("ID");
                data.Columns.Add("Tên sản phẩm đã mua");
                data.Columns.Add("Giá sản phẩm đã mua");
                data.Columns.Add("Số lượng sản phẩm đã mua");
                List<ThongKeSanPhamDTO> list = new List<ThongKeSanPhamDTO>();
                list = ThongKeBLL._getDataSanPhamNhap(cld_start.Value.ToString("yyyy-MM-ddTHH:mm:ss.fff"), cld_end.Value.ToString("yyyy-MM-ddTHH:mm:ss.fff"));
                for (int i = 0; i < list.Count; i++)
                {
                    data.Rows.Add(list[i].id, list[i].name, list[i].prices, list[i].quantity);
                }
                tbl1.DataSource = data;
            }
            else if (cbb1.SelectedIndex == 1)
            {
                data.Columns.Add("Số điện thoại");
                data.Columns.Add("Tên nhân viên ");
                data.Columns.Add("Số lượng đơn đã bán");
                List<ThongKeNhanVienDTO> list = new List<ThongKeNhanVienDTO>();
                list = ThongKeBLL._getDataNhanVienNhap(cld_start.Value.ToString("yyyy-MM-ddTHH:mm:ss.fff"), cld_end.Value.ToString("yyyy-MM-ddTHH:mm:ss.fff"));
                for (int i = 0; i < list.Count; i++)
                {
                    data.Rows.Add(list[i].id, list[i].name, list[i].soluongdonhang);
                }
                tbl1.DataSource = data;
            }
            flagClearTable = 1;
        }

        public void headerMid()
        {
            pnl_mid = new Panel()
            {
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = System.Drawing.ColorTranslator.FromHtml("#5F6EFD")
            };
            pnl_mid.SetBounds(230, 0, 220, 220);
            pnl_top.Controls.Add(pnl_mid);

            //************************************************************

            lbl_titleMid = new Label()
            {
                Text = "Tổng tiền bán hàng",
                ForeColor = Color.White,
                Font = new Font("Times New Roman", 12.0f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };
            lbl_titleMid.SetBounds(10, 10, 200, 30);
            pnl_mid.Controls.Add(lbl_titleMid);

            //************************************************************

            lbl_ngayXuat = new Label()
            {
                Text = $"Từ ngày {cld_start.Value.ToString("dd/ MM/ yyyy")} đến ngày {cld_end.Value.ToString("dd/ MM/ yyyy")}",
                ForeColor = Color.White,
                Font = new Font("Times New Roman", 12.0f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
            };
            lbl_ngayXuat.SetBounds(10, 40, 200, 50);
            pnl_mid.Controls.Add(lbl_ngayXuat);

            //************************************************************

            lbl_tienXuat = new Label()
            {
                Image = global::GUI.Properties.Resources.icons8_bank_cards_50px,
                ImageAlign = ContentAlignment.MiddleLeft,
                Text = ThongKeBLL.tienXuat + " đ",
                ForeColor = Color.White,
                Font = new Font("Times New Roman", 14.0f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleRight,
            };
            lbl_tienXuat.SetBounds(10, 90, 200, 50);
            pnl_mid.Controls.Add(lbl_tienXuat);

            //************************************************************

            pnl_chiTietXuat = new Panel();
            pnl_chiTietXuat.SetBounds(0, 140, 220, 80);
            pnl_mid.Controls.Add(pnl_chiTietXuat);

            //************************************************************

            btn_xemChiTietXuat = new Button()
            {
                Text = "Xem sản phẩm",
                ForeColor = Color.White,
                Font = new Font("Times New Roman", 12.0f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };
            btn_xemChiTietXuat.Click += Btn_xemChiTietXuat_Click;
            btn_xemChiTietXuat.FlatStyle = FlatStyle.Flat;
            btn_xemChiTietXuat.SetBounds(10, 20, 200, 40);
            pnl_chiTietXuat.Controls.Add(btn_xemChiTietXuat);

            //************************************************************

            if (Login._checkUrlMatch("xemsanphamban:TK"))
            {
                btn_xemChiTietXuat.Visible = true;
            }
            else
            {
                btn_xemChiTietXuat.Visible = false;
            }
            //************************************************************
        }

        private void Btn_xemChiTietXuat_Click(object sender, EventArgs e)
        {
            data = new DataTable();
            if (cbb1.SelectedIndex == 0)
            {
                data.Columns.Add("ID");
                data.Columns.Add("Tên sản phẩm đã bán");
                data.Columns.Add("Giá sản phẩm đã bán");
                data.Columns.Add("Số lượng sản phẩm đã bán");
                List<ThongKeSanPhamDTO> list = new List<ThongKeSanPhamDTO>();
                list=ThongKeBLL._getDataSanPhamXuat(cld_start.Value.ToString("yyyy-MM-ddTHH:mm:ss.fff"), cld_end.Value.ToString("yyyy-MM-ddTHH:mm:ss.fff"));
                for (int i = 0; i < list.Count; i++)
                {
                    data.Rows.Add(list[i].id, list[i].name, list[i].prices, list[i].quantity );
                }
                tbl1.DataSource = data;
            }
            else if (cbb1.SelectedIndex == 1)
            {
                data.Columns.Add("Số điện thoại");
                data.Columns.Add("Tên nhân viên ");
                data.Columns.Add("Số lượng đơn đã bán");
                List<ThongKeNhanVienDTO> list = new List<ThongKeNhanVienDTO>();
                list = ThongKeBLL._getDataNhanVienXuat(cld_start.Value.ToString("yyyy-MM-ddTHH:mm:ss.fff"), cld_end.Value.ToString("yyyy-MM-ddTHH:mm:ss.fff"));
                for (int i = 0; i < list.Count; i++)
                {
                    data.Rows.Add(list[i].id, list[i].name, list[i].soluongdonhang);
                }
                tbl1.DataSource = data;
            }
            flagClearTable = 1;
        }

        public void headerRight()
        {
            pnl_right = new Panel()
            {
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = System.Drawing.ColorTranslator.FromHtml("#FF6D82"),
            };
            pnl_right.SetBounds(460, 0, 280, 220);
            pnl_top.Controls.Add(pnl_right);

            //****************************************************************

            lbl_titleRight = new Label()
            {
                Text = "Tổng Doanh thu",
                ForeColor = Color.White,
                Font = new Font("Times New Roman", 12.0f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };
            lbl_titleRight.SetBounds(10, 10, 260, 30);
            pnl_right.Controls.Add(lbl_titleRight);

            //****************************************************************
            lbl_tongDoanhThu = new Label()
            {
                Image = global::GUI.Properties.Resources.icons8_money_50px,
                ImageAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.White,
                Font = new Font("Times New Roman", 14.0f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleRight,
            };
            lbl_tongDoanhThu.SetBounds(10, 40, 260, 50);
            pnl_right.Controls.Add(lbl_tongDoanhThu);

            //***************************************************************

            pnl_loc = new Panel();
            pnl_loc.SetBounds(10, 90, 260, 120);
            pnl_right.Controls.Add(pnl_loc);

            //***************************************************************

            lbl_dateStart = new Label()
            {
                Text = "Ngày bắt đầu",
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.White,
                Font = new Font("Times New Roman", 12.0f, FontStyle.Bold),
            };
            lbl_dateStart.SetBounds(0, 0, 140, 20);
            pnl_loc.Controls.Add(lbl_dateStart);

            //***************************************************************

            DateTime dateBegin = new DateTime(2008, 3, 1, 0, 0, 0);
            cld_start = new DateTimePicker()
            {
                Value = dateBegin,
            };
            cld_start.SetBounds(50, 20, 210, 20);
            pnl_loc.Controls.Add(cld_start);

            //**************************************************************

            lbl_dateEnd = new Label()
            {
                Text = "Ngày kết thúc",
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.White,
                Font = new Font("Times New Roman", 12.0f, FontStyle.Bold),
            };
            lbl_dateEnd.SetBounds(0, 40, 140, 20);
            pnl_loc.Controls.Add(lbl_dateEnd);

            //**************************************************************
            cld_end = new DateTimePicker();
            cld_end.SetBounds(50, 60, 210, 20);
            pnl_loc.Controls.Add(cld_end);

            //**************************************************************

            cbb1 = new ComboBox()
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Popup,
                DropDownHeight = 70,
                Font = new Font("Times New Roman", 12.0f, FontStyle.Bold),
                DataSource = listcbb,
            };
            cbb1.SetBounds(0, 92, 120, 20);
            pnl_loc.Controls.Add(cbb1);

            //*************************************************************

            btn_loc = new Button()
            {
                Text = "Lọc",
                ForeColor = Color.White,
                Font = new Font("Times New Roman", 12.0f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };
            btn_loc.FlatStyle = FlatStyle.Flat;
            btn_loc.SetBounds(180, 90, 80, 30);
            btn_loc.Click += Btn_loc_Click;
            pnl_loc.Controls.Add(btn_loc);

            //*************************************************************

            if (Login._checkUrlMatch("loc:TK"))
            {
                btn_loc.Visible = true;
            }
            else
            {
                btn_loc.Visible = false;
            }
            //************************************************************
        }

        private void Btn_loc_Click(object sender, EventArgs e)
        {
            if(cld_start.Value> cld_end.Value)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc","Thông báo");
            }
            else
            {
                ThongKeBLL._getDataGia(cld_start.Value.ToString("yyyy-MM-ddTHH:mm:ss.fff"), cld_end.Value.ToString("yyyy-MM-ddTHH:mm:ss.fff"));
                lbl_tienNhap.Text = ThongKeBLL.tienNhap + " đ";
                lbl_tienXuat.Text = ThongKeBLL.tienXuat + " đ";
                lbl_tongDoanhThu.Text = ThongKeBLL.tongDoanhThu + " đ";
                lbl_ngayNhap.Text = $"Từ ngày {cld_start.Value.ToString("dd/ MM/ yyyy")} đến ngày {cld_end.Value.ToString("dd/ MM/ yyyy")}";
                lbl_ngayXuat.Text = $"Từ ngày {cld_start.Value.ToString("dd/ MM/ yyyy")} đến ngày {cld_end.Value.ToString("dd/ MM/ yyyy")}";
                if (flagClearTable == 1)
                {
                    data.Columns.Clear();
                    data.Rows.Clear();
                }
                if (cbb1.SelectedIndex == 0)
                {
                    if (Login._checkUrlMatch("xemsanphamban:TK"))
                    {
                        btn_xemChiTietXuat.Visible = true;
                    }
                    else
                    {
                        btn_xemChiTietXuat.Visible = false;
                    }
                    if (Login._checkUrlMatch("xemsanphamnhap:TK"))
                    {
                        btn_xemChiTietNhap.Visible = true;
                    }
                    else
                    {
                        btn_xemChiTietNhap.Visible = false;
                    }
                    btn_xemChiTietNhap.Text = "Xem sản phẩm";
                    btn_xemChiTietXuat.Text = "Xem sản phẩm";
                }
                else if (cbb1.SelectedIndex == 1)
                {
                    if (Login._checkUrlMatch("xemnhanvienban:TK"))
                    {
                        btn_xemChiTietXuat.Visible = true;
                    }
                    else
                    {
                        btn_xemChiTietXuat.Visible = false;
                    }
                    if (Login._checkUrlMatch("xemnhanviennhap:TK"))
                    {
                        btn_xemChiTietNhap.Visible = true;
                    }
                    else
                    {
                        btn_xemChiTietNhap.Visible = false;
                    }
                    btn_xemChiTietNhap.Text = "Xem nhân viên";
                    btn_xemChiTietXuat.Text = "Xem nhân viên";
                }
                else if (cbb1.SelectedIndex == 2)
                {
                    btn_xemChiTietNhap.Visible = false;
                    btn_xemChiTietXuat.Visible = false;

                    if (Login._checkUrlMatch("xemkhachhang:TK"))
                    {
                        data = new DataTable();
                        data.Columns.Add("Số điện thoại");
                        data.Columns.Add("Tên khách hàng ");
                        data.Columns.Add("Số lượng đơn đã mua");
                        data.Columns.Add("Tổng tiền đã mua");
                        List<ThongKeKhachHangDTO> list = new List<ThongKeKhachHangDTO>();
                        list = ThongKeBLL._getDataKhachHang(cld_start.Value.ToString("yyyy-MM-ddTHH:mm:ss.fff"), cld_end.Value.ToString("yyyy-MM-ddTHH:mm:ss.fff"));
                        for (int i = 0; i < list.Count; i++)
                        {
                            data.Rows.Add(list[i].id, list[i].name, list[i].soluongdon, list[i].tongtien);
                        }
                        tbl1.DataSource = data;
                    }
                }
            }     
        }

        public void table()
        {
            pnl_table = new Panel()
            {
                BackColor = Color.Aqua
            };
            pnl_table.SetBounds(10, 240, 740, 330);
            this.Controls.Add(pnl_table);

            //**********************************************************
            tbl1 = new DataGridView()
            {
                BorderStyle = BorderStyle.FixedSingle,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                /* AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders,*/
            };
            /*tbl1.CellClick += Tbl1_CellClick;*/
            tbl1.SetBounds(0, 0, 740, 330);
            pnl_table.Controls.Add(tbl1);
        }

        /*private void Tbl1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tbl1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != "")
            {
                MessageBox.Show(tbl1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString());
            }
        }*/
    }
}
