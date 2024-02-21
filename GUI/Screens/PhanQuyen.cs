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
using GUI.Popups;

namespace GUI.Screens
{
    public partial class PhanQuyen : UserControl
    {
        private string idDanhMucNhanVien { get; set; }
        List<CheckedPermissionsDTO> listPermission=new List<CheckedPermissionsDTO>();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        List<DanhMucNhanVienComboBoxDTO> listcbb = new List<DanhMucNhanVienComboBoxDTO>();
        List<CategoryStaffsDTO> listDanhMuc = new List<CategoryStaffsDTO>();
        List<string> listIcon = new List<string>() {
            "btn_banhang.Image",
            "btn_sanpham.Image",
            "btn_danhmuc.Image",
            "btn_nhacungcap.Image",
            "btn_nhanvien.Image",
            "btn_khachhang.Image",
            "btn_baohanh.Image",
            "btn_nhapxuat.Image",
            "btn_thongke.Image"
        };
        public DataTable data;
        //**************************************************************************
        // quản lý danh mục nhân viên
        public Panel pnl1, pnl_header1, pnl_content1, pnl_footer;
        public Button btn_ADD, btn_quanLyDanhMucNV, btn_phanQuyenDanhMuc;
        public TextBox txt_search;
        public DataGridView tbl;
        //**************************************************************************
        // quản lý phân quyên danh mục nhân viên
        public Panel pnl2, pnl_header2, pnl_chondanhmucnv;
        public FlowLayoutPanel pnl_content2, pnl_chonquyen;
        public Label lbl_titleChonQuyen, lbl_chonDanhMuc;
        public ComboBox cbb1;
        public List<PermissionsDTO> listquyen = new List<PermissionsDTO>();
        public CheckBox[] ck;
        public Button[] btn_quyen;
        public List<PhanQuyenDTO> listpq = new List<PhanQuyenDTO>();
        //**************************************************************************
        public PhanQuyen()
        {
            listpq = PhanQuyenBLL.GetData();
            listcbb = PhanQuyenBLL.GetDataComboBox();
            idDanhMucNhanVien = listcbb[0].id;
            listDanhMuc = PhanQuyenBLL.GetDataCategoryStaffs();
            listquyen = PhanQuyenBLL._GetDataPermissions(listDanhMuc[0].id);
            listPermission = PhanQuyenBLL._GetDataCheckedPermissions();
            InitializeComponent();
            init();
        }

        private void PhanQuyen_Load(object sender, EventArgs e)
        {

        }
        public void init()
        {
            modal1();
            modal2();
            footer();
        }

        //**************************************************************************
        // quản lý danh mục nhân viên
        public void modal1()
        {
            pnl1 = new Panel();
            pnl1.SetBounds(10, 10, 740, 500);
            pnl1.Visible = true;
            this.Controls.Add(pnl1);
            header1();
            content1();
        }
        public void header1()
        {
            pnl_header1 = new Panel()
            {
                BackColor = System.Drawing.ColorTranslator.FromHtml("#CD313E"),
            };
            pnl_header1.SetBounds(0, 0, 740, 150);
            pnl1.Controls.Add(pnl_header1);

            //***********************************************

            txt_search = new TextBox()
            {
                /* Multiline = true,*/
                Text = "Tìm tên danh mục nhân viên...",
                TextAlign = HorizontalAlignment.Center,
                ForeColor = Color.Gray,
                Font = new Font("Times New Roman", 12.0f, FontStyle.Regular),
            };
            txt_search.GotFocus += RemoveText;
            txt_search.LostFocus += AddText;
            txt_search.KeyUp += Txt_search_KeyUp;
            txt_search.SetBounds(40, 55, 240, 0);
            pnl_header1.Controls.Add(txt_search);

            //***********************************************

            btn_ADD = new Button()
            {
                Text = "Thêm danh mục nhân viên",
                ForeColor = Color.White,
                Font = new Font("Times New Roman", 12.0f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = System.Drawing.ColorTranslator.FromHtml("#5F6EFD"),
            };
            btn_ADD.Click += Btn_ADD_Click;
            btn_ADD.SetBounds(480, 50, 240, 40);
            pnl_header1.Controls.Add(btn_ADD);
        }

        private void Btn_ADD_Click(object sender, EventArgs e)
        {
            /*data.Rows.Add(listpq[listpq.Count - 1].id+1, "aaa", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff"), DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff"), 0);*/
            ModalPopupAddDMNV m = new ModalPopupAddDMNV(PhanQuyenBLL._idNext());
            m.ShowDialog();
            if (m.flagaddDMNV == true)
            {
                listcbb = PhanQuyenBLL.GetDataComboBox();
                listpq.Add(m.pqdto);
                data.Rows.Add(m.pqdto.id, m.pqdto.name, m.pqdto.createAt, m.pqdto.updateAt, m.pqdto.status);
                m.flagaddDMNV = false;
            }
        }

        private void Txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            List<PhanQuyenDTO> listSearch = new List<PhanQuyenDTO>();
            if (e.KeyCode == Keys.Enter)
            {
                for(int i = 0; i < listpq.Count; i++)
                {
                    if (listpq[i].name.IndexOf(txt_search.Text) != -1)
                    {
                        listSearch.Add(listpq[i]);
                    }
                }
                _loadData(listSearch);
            }
        }

        private void RemoveText(object sender, EventArgs e)
        {
            if (txt_search.Text == "Tìm tên danh mục nhân viên...")
            {
                txt_search.Text = "";
                txt_search.Font = new Font("Times New Roman", 12.0f, FontStyle.Bold);
                txt_search.ForeColor = Color.Black;
            }
        }

        private void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_search.Text))
            {
                txt_search.Text = "Tìm tên danh mục nhân viên...";
                txt_search.Font = new Font("Times New Roman", 12.0f, FontStyle.Regular);
                txt_search.ForeColor = Color.Gray;
            }
        }

        public void content1()
        {
            pnl_content1 = new Panel()
            {
                BackColor = Color.Blue,
            };
            pnl_content1.SetBounds(0, 160, 740, 330);
            pnl1.Controls.Add(pnl_content1);
            data = new DataTable()
            {
                Columns = { "ID", "Tên danh mục nhân viên", "Ngày tạo", "Ngày cập nhật", "Status" },
            };
            _loadData(listpq);
            tbl = new DataGridView()
            {
                BorderStyle = BorderStyle.FixedSingle,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                /* AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders,*/
                DataSource=data,
            };
            tbl.CellClick += Tbl_CellClick;
            tbl.SetBounds(0, 0, 740, 330);
            pnl_content1.Controls.Add(tbl);
        }
        public void _loadData(List<PhanQuyenDTO> listpq)
        {
            data.Rows.Clear();
            for (int i = 0; i < listpq.Count; i++)
                {
                    data.Rows.Add(listpq[i].id, listpq[i].name, listpq[i].createAt, listpq[i].updateAt, listpq[i].status);
                }
        }

        private void Tbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                if (tbl.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != "")
            {
                string iddmnv = tbl.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                string namedmnv = tbl.Rows[e.RowIndex].Cells["Tên danh mục nhân viên"].FormattedValue.ToString();
                string createAtdmnv = tbl.Rows[e.RowIndex].Cells["Ngày tạo"].FormattedValue.ToString();
                string updatedAtdmnv = tbl.Rows[e.RowIndex].Cells["Ngày cập nhật"].FormattedValue.ToString();
                string statusdmnv = tbl.Rows[e.RowIndex].Cells["Status"].FormattedValue.ToString();
                if (iddmnv!= "" && namedmnv != "" && createAtdmnv != "" && updatedAtdmnv != "" && statusdmnv != "")
                {
                    ModalPopupUpdateDMNV modalPopupUpdateDMNV = new ModalPopupUpdateDMNV(iddmnv, namedmnv, createAtdmnv);
                    modalPopupUpdateDMNV.ShowDialog();
                    if (modalPopupUpdateDMNV.flagupdate == true)
                    {
                        for (int i = 0; i < listpq.Count; i++)
                        {
                            if (listpq[i].id.ToString() == iddmnv)
                            {
                                listpq[i].name = modalPopupUpdateDMNV.pqdto.name;
                                listpq[i].updateAt = modalPopupUpdateDMNV.pqdto.updateAt;
                            }
                        }
                        _loadData(listpq);
                        modalPopupUpdateDMNV.flagupdate = false;
                    }
                    if (modalPopupUpdateDMNV.flagdelete == true)
                    {
                        for (int i = 0; i < listpq.Count; i++)
                        {
                            if (listpq[i].id.ToString() == iddmnv)
                            {
                                listpq.Remove(listpq[i]);
                            }
                        }
                        _loadData(listpq);
                        modalPopupUpdateDMNV.flagdelete = false;
                    }
                        listcbb = PhanQuyenBLL.GetDataComboBox();
                }
                else
                {
                    MessageBox.Show("Hãy chọn dòng có nội dung", "Thông báo");
                }
            }
            }
            
        }

        //**************************************************************************
        // quản lý phân quyên danh mục nhân viên

        public void modal2()
        {
            pnl2 = new Panel();
            pnl2.SetBounds(10, 10, 740, 500);
            pnl2.Visible = false;
            this.Controls.Add(pnl2);
            header2();
            content2();
        }
        public void header2()
        {
            pnl_header2 = new Panel();
            pnl_header2.SetBounds(0, 0, 740, 180);
            pnl2.Controls.Add(pnl_header2);

            //****************************************************************

            pnl_chondanhmucnv = new Panel()
            {
                BackColor = System.Drawing.ColorTranslator.FromHtml("#778899"),
            };
            pnl_chondanhmucnv.SetBounds(0, 0, 250, 180);
            pnl_header2.Controls.Add(pnl_chondanhmucnv);

            //****************************************************************

            _loadComboBox();

            //****************************************************************

            pnl_chonquyen = new FlowLayoutPanel()
            {
                BackColor = System.Drawing.ColorTranslator.FromHtml("#7D26CD"),
            };
            pnl_chonquyen.SetBounds(260, 0, 480, 180);
            pnl_header2.Controls.Add(pnl_chonquyen);

            //**************************************************************
            _loadCheckBox(listquyen, listDanhMuc[0].name);

        }
        public void _loadComboBox()
        {
            pnl_chondanhmucnv.Controls.Clear();

            //****************************************************************

            lbl_chonDanhMuc = new Label()
            {
                Text = "Chọn danh mục nhân viên",
                Font = new Font("Times New Roman", 12.0f, FontStyle.Bold),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
            };
            lbl_chonDanhMuc.SetBounds(0, 0, 250, 40);
            pnl_chondanhmucnv.Controls.Add(lbl_chonDanhMuc);

            //****************************************************************

            cbb1 = new ComboBox()
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Popup,
                DropDownHeight = 70,
                Font = new Font("Times New Roman", 12.0f, FontStyle.Regular),
            };
            Dictionary<string, string> cbbSource = new Dictionary<string, string>();
            for (int i = 0; i < listcbb.Count; i++)
            {
                cbbSource.Add(listcbb[i].id, listcbb[i].name);
            }
            cbb1.DataSource = new BindingSource(cbbSource, null);
            cbb1.DisplayMember = "Value";
            cbb1.ValueMember = "Key";
            cbb1.SelectedIndexChanged += Cbb1_SelectedIndexChanged;
            cbb1.SetBounds(30, 75, 200, 0);
            pnl_chondanhmucnv.Controls.Add(cbb1);
        }
        private void _loadCheckBox(List<PermissionsDTO> listquyen,string nameTitle)
        {
            pnl_chonquyen.Controls.Clear();
            lbl_titleChonQuyen = new Label()
            {
                Margin = new Padding(0),
                Text = nameTitle,
                ForeColor = Color.White,
                Font = new Font("Times New Roman", 12.0f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            lbl_titleChonQuyen.SetBounds(0, 3, 480, 40);
            pnl_chonquyen.Controls.Add(lbl_titleChonQuyen);

            //***************************************************************

            ck = new CheckBox[listquyen.Count];
            for (int i = 0; i < listquyen.Count; i++)
            {
                ck[i] = new CheckBox()
                {
                    Name = listquyen[i].urlmatch,
                    Width = 234,
                    Height = 40,
                    /*Size = new Size(154, 40),*/
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(5, 0, 0, 0),
                    Text = listquyen[i].name,
                    ForeColor = Color.White,
                    Font = new Font("Times New Roman", 12.0f, FontStyle.Regular),
                    BackColor = System.Drawing.ColorTranslator.FromHtml("#CD9B1D"),
                };
                ck[i].Click += PhanQuyen_CheckedChanged;
                pnl_chonquyen.Controls.Add(ck[i]);
            }
            _loadChecked(listquyen, listPermission);
        }
        private void _loadChecked(List<PermissionsDTO> listquyen, List<CheckedPermissionsDTO> listPermission)
        {
            for (int i = 0; i < listquyen.Count; i++)
            {
                for (int j = 0; j < listPermission.Count; j++)
                {
                    if (listPermission[j].idDanhMucNhanVien == idDanhMucNhanVien && listPermission[j].idQuyen == ck[i].Name)
                    {
                        ck[i].Checked = true;
                    }                 
                }
            }
        }
        private void PhanQuyen_CheckedChanged(object sender, EventArgs e)
        {
            for(int i=0; i<listquyen.Count; i++)
            {
                if(ck[i].Text== (sender as CheckBox).Text )
                {
                    if(ck[i].Checked == true)
                    {
                        PhanQuyenBLL._AddPermission(idDanhMucNhanVien, listquyen[i].urlmatch);
                    }
                    else
                    {
                        PhanQuyenBLL._DelPermission(idDanhMucNhanVien, listquyen[i].urlmatch);
                    }
                }
            }
        }
        private void Cbb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listDanhMuc.Count; i++)
            {
                btn_quyen[i].BackColor = System.Drawing.ColorTranslator.FromHtml("#FF6D82");
            }
            string key = ((KeyValuePair<string, string>)cbb1.SelectedItem).Key;
            /*string value = ((KeyValuePair<string, string>)cbb1.SelectedItem).Value;*/
            btn_quyen[0].BackColor = System.Drawing.ColorTranslator.FromHtml("#ECAB53");
            idDanhMucNhanVien = key;
            listquyen = PhanQuyenBLL._GetDataPermissions(listDanhMuc[0].id);
            listPermission = PhanQuyenBLL._GetDataCheckedPermissions();
            _loadCheckBox(listquyen, btn_quyen[0].Text);
            _loadChecked(listquyen, listPermission);
        }

        public void content2()
        {
            pnl_content2 = new FlowLayoutPanel()
            {
                BackColor = System.Drawing.ColorTranslator.FromHtml("#00BF9E"),
            };
            pnl_content2.SetBounds(0, 190, 740, 300);
            pnl2.Controls.Add(pnl_content2);

            //*********************************************************************
            btn_quyen = new Button[listDanhMuc.Count];
            for (int i = 0; i < listDanhMuc.Count; i++)
            {
                btn_quyen[i] = new Button()
                {
                    ForeColor = Color.White,
                    Image = ((System.Drawing.Image)(resources.GetObject(listIcon[i]))),
                    ImageAlign = ContentAlignment.TopCenter,
                    Text = listDanhMuc[i].name,
                    TextAlign = ContentAlignment.BottomCenter,
                    BackColor = System.Drawing.ColorTranslator.FromHtml("#FF6D82"),
                    Font = new Font("Times New Roman", 12.0f, FontStyle.Regular),
                    Size = new Size(240, 60),
                    Margin = new Padding(5, 30, 0, 0),
                    FlatStyle = FlatStyle.Flat,
                };
                btn_quyen[0].BackColor = System.Drawing.ColorTranslator.FromHtml("#ECAB53");
                btn_quyen[i].Click += QuanLyDanhMucNhanVien_Click;
                pnl_content2.Controls.Add(btn_quyen[i]);
            }
        }

        private void QuanLyDanhMucNhanVien_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listDanhMuc.Count; i++)
            {
                btn_quyen[i].BackColor = System.Drawing.ColorTranslator.FromHtml("#FF6D82");
                if (btn_quyen[i].Text == (sender as Button).Text)
                {
                    btn_quyen[i].BackColor = System.Drawing.ColorTranslator.FromHtml("#ECAB53");
                    listquyen = PhanQuyenBLL._GetDataPermissions(listDanhMuc[i].id);
                    listPermission = PhanQuyenBLL._GetDataCheckedPermissions();
                    _loadCheckBox(listquyen, btn_quyen[i].Text);
                    _loadChecked(listquyen, listPermission);
                }
            }
        }
        //**************************************************************************
        public void footer()
        {
            pnl_footer = new Panel();
            pnl_footer.SetBounds(10, 510, 740, 60);
            this.Controls.Add(pnl_footer);

            //************************************************

            btn_quanLyDanhMucNV = new Button()
            {
                Text = "Quản lý danh mục",
                ForeColor = Color.White,
                Font = new Font("Times New Roman", 12.0f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = System.Drawing.ColorTranslator.FromHtml("#838B83"),
            };
            btn_quanLyDanhMucNV.Click += Btn_quanLyDanhMucNV_Click;
            btn_quanLyDanhMucNV.SetBounds(0, 0, 365, 60);
            pnl_footer.Controls.Add(btn_quanLyDanhMucNV);

            //************************************************

            btn_phanQuyenDanhMuc = new Button()
            {
                Text = "Phân quyền danh mục",
                ForeColor = Color.White,
                Font = new Font("Times New Roman", 12.0f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = System.Drawing.ColorTranslator.FromHtml("#5F6EFD"),
            };
            btn_phanQuyenDanhMuc.MouseClick += Btn_phanQuyenDanhMuc_MouseClick;
            btn_phanQuyenDanhMuc.SetBounds(375, 0, 365, 60);
            pnl_footer.Controls.Add(btn_phanQuyenDanhMuc);
        }

        private void Btn_quanLyDanhMucNV_Click(object sender, EventArgs e)
        {
            pnl1.Visible = true;
            pnl2.Visible = false;
            btn_quanLyDanhMucNV.BackColor = System.Drawing.ColorTranslator.FromHtml("#838B83");
            btn_phanQuyenDanhMuc.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F6EFD");
        }

        private void Btn_phanQuyenDanhMuc_MouseClick(object sender, MouseEventArgs e)
        {
            pnl1.Visible = false;
            pnl2.Visible = true;
            _loadComboBox();
            btn_quanLyDanhMucNV.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F6EFD");
            btn_phanQuyenDanhMuc.BackColor = System.Drawing.ColorTranslator.FromHtml("#838B83");
        }
    }
}
