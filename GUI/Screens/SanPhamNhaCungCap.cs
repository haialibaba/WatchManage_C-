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
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;


namespace GUI.Screens
{
    public partial class SanPhamNhaCungCap : UserControl
    {
        List<PProducerDTO> pProducers = new List<PProducerDTO>();
        List<NhaCungCapDTO> producers = new List<NhaCungCapDTO>();
        List<DanhMucDTO> categories = new List<DanhMucDTO>();
        List<PProducerDTO> searchPProducers = new List<PProducerDTO>();


        public SanPhamNhaCungCap()
        {
            InitializeComponent();
            initDatagridView();
            txt_search_spncc.GotFocus += RemoveText;
            txt_search_spncc.LostFocus += AddText;
        }

        private void initDatagridView()
        {
            dgv_spncc.ColumnCount = 9;
            dgv_spncc.Columns[0].Name = "ID";
            dgv_spncc.Columns[1].Name = "Tên";
            dgv_spncc.Columns[2].Name = "Danh mục";
            dgv_spncc.Columns[3].Name = "Nguồn gốc";
            dgv_spncc.Columns[4].Name = "Giá";
            dgv_spncc.Columns[5].Name = "Nhà cung cấp";
            dgv_spncc.Columns[6].Name = "Hình ảnh";
            dgv_spncc.Columns[7].Name = "CreatedAt";
            dgv_spncc.Columns[8].Name = "UpdatedAt";
            pProducers = SanPhamNhaCungCapBLL.GetData();
            loadDataToDataGridView(pProducers);
        }

        private void loadDataToDataGridView(List<PProducerDTO> pProducers)
        {

            dgv_spncc.Rows.Clear();
            dgv_spncc.Refresh();

            foreach (PProducerDTO producer in pProducers)
            {
                string[] row = new string[] { producer.Id.ToString(), producer.Name, producer.CategoryId.ToString(),producer.Origin,producer.Prices.ToString(),producer.ProducerId.ToString(), producer.Image, producer.CreatedAt.ToString("dd-MM-yyyy hh:mm:ss"), producer.UpdatedAt.ToString("dd-MM-yyyy hh:mm:ss") };
                dgv_spncc.Rows.Add(row);
            }
        }

        private int getIdMax(List<PProducerDTO> producers)
        {
            int id = producers.Count > 0 ? producers[0].Id : 0;
            foreach (PProducerDTO producer in producers)
            {
                if (producer.Id > id)
                {
                    id = producer.Id;
                }
            }

            return id;
        }

        private void RemoveText(object sender, EventArgs e)
        {
            if (txt_search_spncc.Text == "Tìm kiếm theo ID, tên")
            {
                txt_search_spncc.Text = "";
                txt_search_spncc.ForeColor = Color.Black;
            }
        }

        private void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_search_spncc.Text))
            {
                txt_search_spncc.Text = "Tìm kiếm theo ID, tên";
                txt_search_spncc.ForeColor = Color.Gray;
            }
        }

        private void btn_add_spncc_Click(object sender, EventArgs e)
        {
            AddSanPhamNhaCungCap Add = new AddSanPhamNhaCungCap(getIdMax(pProducers) + 1, producers, categories);
            Add.ShowDialog();
            if(Add.flagAdd == true)
            {
                pProducers.Add(Add.producerAdd);
                string[] row = new string[] { Add.producerAdd.Id.ToString(), Add.producerAdd.Name, Add.producerAdd.CategoryId.ToString(), Add.producerAdd.Origin, Add.producerAdd.Prices.ToString(), Add.producerAdd.ProducerId.ToString(), Add.producerAdd.Image, Add.producerAdd.CreatedAt.ToString("dd-MM-yyyy hh:mm:ss"), Add.producerAdd.UpdatedAt.ToString("dd-MM-yyyy hh:mm:ss") };
                dgv_spncc.Rows.Add(row);
                Add.flagAdd = false;
                Add.Close();

            }
        }

        private void SanPhamNhaCungCap_Load(object sender, EventArgs e)
        {
            producers = NhaCungCapBLL.GetDataAction();
            categories = DanhMucBLL.GetDataAction();

            cbb_category.DisplayMember = "Text";
            cbb_category.ValueMember = "Value";

            var item1 = new { Text = "Chọn loại", Value = 0 };

            cbb_category.Items.Add(item1);
            foreach (DanhMucDTO category in categories)
            {
                var item = new { Text = $"{category.Name} - {category.Id}", Value = category.Id };

                cbb_category.Items.Add(item);
            }

            var item2 = new { Text = "Chọn nhà cung cấp", Value = 0 };

            cbb_producer.Items.Add(item2);
            cbb_producer.DisplayMember = "Text";
            cbb_producer.ValueMember = "Value";

            foreach (NhaCungCapDTO producer in producers)
            {
                var item = new { Text = $"{producer.Name} - {producer.Id}", Value = producer.Id };

                cbb_producer.Items.Add(item);
            }
        }

        private void dgv_spncc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_spncc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            XacNhanThucHien confirm = new XacNhanThucHien(pProducers[e.RowIndex].Id);
            confirm.ShowDialog();

            if (confirm.value == "delete")
            {
                if (MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm {pProducers[e.RowIndex].Id} - {pProducers[e.RowIndex].Name}?", "Cảnh báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    bool flag = SanPhamNhaCungCapBLL.DeleteData(pProducers[e.RowIndex].Id);
                    if (flag == true)
                    {
                        pProducers.RemoveAt(e.RowIndex);
                        dgv_spncc.Rows.Remove(dgv_spncc.Rows[e.RowIndex]);

                    }

                }
            }
            else if (confirm.value == "update")
            {
                UpdateSanPhamNhaCungCap update = new UpdateSanPhamNhaCungCap(pProducers[e.RowIndex], producers, categories);
                update.ShowDialog();
                if(update.flag == true)
                {
                   foreach(PProducerDTO item in pProducers)
                    {
                        if(item.Id == update.pProducer.Id)
                        {
                            item.Image = update.pProducer.Image;
                            item.Name = update.pProducer.Name;
                            item.Origin = update.pProducer.Origin;
                            item.Prices = update.pProducer.Prices;
                            item.ProducerId = update.pProducer.ProducerId;
                            item.CategoryId = update.pProducer.CategoryId;
                            break;
                        }
                    }

                

                    dgv_spncc.Rows[e.RowIndex].Cells[1].Value = update.pProducer.Name;
                    dgv_spncc.Rows[e.RowIndex].Cells[2].Value = update.pProducer.CategoryId;
                    dgv_spncc.Rows[e.RowIndex].Cells[3].Value = update.pProducer.Origin;
                    dgv_spncc.Rows[e.RowIndex].Cells[4].Value = update.pProducer.Prices;
                    dgv_spncc.Rows[e.RowIndex].Cells[5].Value = update.pProducer.ProducerId;
                    dgv_spncc.Rows[e.RowIndex].Cells[6].Value = update.pProducer.Image;
                    dgv_spncc.Rows[e.RowIndex].Cells[8].Value = update.pProducer.UpdatedAt.ToString("dd-MM-yyyy hh:mm:ss");

                }
                    update.Close();

            }
            confirm.Close();
        }

        private void HandleSearch()
        {
            searchPProducers.Clear();
            if ((txt_search_spncc.Text == "" || txt_search_spncc.Text == "Tìm kiếm theo ID, tên") && cbb_category.Text == "Chọn loại" && cbb_producer.Text == "Chọn nhà cung cấp")
            {
                loadDataToDataGridView(pProducers);
                return;
            }

            if ((txt_search_spncc.Text != "" || txt_search_spncc.Text != "Tìm kiếm theo ID, tên") && cbb_category.Text == "Chọn loại" && cbb_producer.Text == "Chọn nhà cung cấp")
            {
                foreach (PProducerDTO item in pProducers)
                {
                    if (item.Id.ToString().IndexOf(txt_search_spncc.Text) != -1)
                    {
                        searchPProducers.Add(item);
                    }
                    else if (item.Name.ToUpper().IndexOf(txt_search_spncc.Text.ToUpper()) != -1)
                    {
                        searchPProducers.Add(item);
                    }
                }
                loadDataToDataGridView(searchPProducers);
                return;
            }

            if ((txt_search_spncc.Text == "" || txt_search_spncc.Text == "Tìm kiếm theo ID, tên") && cbb_category.Text != "Chọn loại" && cbb_producer.Text == "Chọn nhà cung cấp")
            {
                int value = (cbb_category.SelectedItem as dynamic).Value;
                foreach (PProducerDTO item in pProducers)
                {
                    if (item.CategoryId == value)
                    {
                        searchPProducers.Add(item);
                    }
                }
                loadDataToDataGridView(searchPProducers);
                return;
            }

            if ((txt_search_spncc.Text == "" || txt_search_spncc.Text == "Tìm kiếm theo ID, tên") && cbb_category.Text == "Chọn loại" && cbb_producer.Text != "Chọn nhà cung cấp")
            {
                int value = (cbb_producer.SelectedItem as dynamic).Value;
                foreach (PProducerDTO item in pProducers)
                {
                    if (item.ProducerId == value)
                    {
                        searchPProducers.Add(item);
                    }
                }
                loadDataToDataGridView(searchPProducers);
                return;
            }

            if ((txt_search_spncc.Text != "" || txt_search_spncc.Text != "Tìm kiếm theo ID, tên") && cbb_category.Text != "Chọn loại" && cbb_producer.Text == "Chọn nhà cung cấp")
            {
                int value = (cbb_category.SelectedItem as dynamic).Value;
                foreach (PProducerDTO item in pProducers)
                {
                    if (item.CategoryId == value && (item.Id.ToString().IndexOf(txt_search_spncc.Text) != -1 || item.Name.ToUpper().IndexOf(txt_search_spncc.Text.ToUpper()) != -1))
                    {
                        searchPProducers.Add(item);
                    }
                }
                loadDataToDataGridView(searchPProducers);
                return;
            }

            if ((txt_search_spncc.Text != "" || txt_search_spncc.Text != "Tìm kiếm theo ID, tên") && cbb_category.Text == "Chọn loại" && cbb_producer.Text != "Chọn nhà cung cấp")
            {
                int value = (cbb_producer.SelectedItem as dynamic).Value;
                foreach (PProducerDTO item in pProducers)
                {
                    if (item.ProducerId == value && (item.Id.ToString().IndexOf(txt_search_spncc.Text) != -1 || item.Name.ToUpper().IndexOf(txt_search_spncc.Text.ToUpper()) != -1))
                    {
                        searchPProducers.Add(item);
                    }
                }
                loadDataToDataGridView(searchPProducers);
                return;
            }

            if ((txt_search_spncc.Text != "Tìm kiếm theo ID, tên") && cbb_category.Text != "Chọn loại" && cbb_producer.Text != "Chọn nhà cung cấp")
            {
                int valueCategory = (cbb_category.SelectedItem as dynamic).Value;
                int valueProducer = (cbb_producer.SelectedItem as dynamic).Value;
                foreach (PProducerDTO item in pProducers)
                {
                    if (item.ProducerId == valueProducer && item.CategoryId == valueCategory && (item.Id.ToString().IndexOf(txt_search_spncc.Text) != -1 || item.Name.ToUpper().IndexOf(txt_search_spncc.Text.ToUpper()) != -1))
                    {
                        searchPProducers.Add(item);
                    }
                }
                loadDataToDataGridView(searchPProducers);
                return;
            }

            if ((txt_search_spncc.Text == "" || txt_search_spncc.Text == "Tìm kiếm theo ID, tên") && cbb_category.Text != "Chọn loại" && cbb_producer.Text != "Chọn nhà cung cấp")
            {
                int valueCategory = (cbb_category.SelectedItem as dynamic).Value;
                int valueProducer = (cbb_producer.SelectedItem as dynamic).Value;
                foreach (PProducerDTO item in pProducers)
                {
                    if (item.ProducerId == valueProducer && item.CategoryId == valueCategory)
                    {
                        searchPProducers.Add(item);
                    }
                }
                loadDataToDataGridView(searchPProducers);
                return;
            }
        }

        private void btn_search_spncc_Click(object sender, EventArgs e)
        {
            HandleSearch();
           
        }

        private void txt_search_spncc_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                HandleSearch();
            }
        }

        private void cbb_producer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for(int i = 0; i < dgv_spncc.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgv_spncc.Columns[i].HeaderText;
            }

            for(int i = 0; i < dgv_spncc.Rows.Count; i++) { 
                for(int j = 0; j < dgv_spncc.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgv_spncc.Rows[i].Cells[j].Value;
                }
            }

            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveAs(path);
            application.ActiveWorkbook.Saved = true;
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export to Excel";
            saveFileDialog.Filter = "Excel (*.xlsx) | *.xlsx|Excel 2003 (*.xls) | *.xls)";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                        ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuat file thanh cong");
                }
                catch(Exception ex) {
                    MessageBox.Show("Xuat file that bai\n" + ex.Message);
                }
            }
        }

        bool flagImport = false;

        void ImportExcel(string path)
        {
            List<PProducerDTO> lists = new List<PProducerDTO>();
            using (ExcelPackage excelPackage = new ExcelPackage(new System.IO.FileInfo(path)))
            {

                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];

                for (int i = excelWorksheet.Dimension.Start.Row + 1; i <= excelWorksheet.Dimension.End.Row; i++)
                    {
                        PProducerDTO product = new PProducerDTO();
                        product.Id = Convert.ToInt32(excelWorksheet.Cells[i, 1].Value);
                    product.Name = excelWorksheet.Cells[i, 2].Value.ToString();
                        product.CategoryId = Convert.ToInt32(excelWorksheet.Cells[i, 3].Value);
                        product.Origin = excelWorksheet.Cells[i,4].Value.ToString();
                        product.Prices = Convert.ToInt32(excelWorksheet.Cells[i, 5].Value);
                        product.ProducerId = Convert.ToInt32(excelWorksheet.Cells[i, 6].Value);
                        product.Image = excelWorksheet.Cells[i,7].Value.ToString();
                        lists.Add(product);
                        
                }

                    foreach(PProducerDTO product in lists)
                    {
                        string check = SanPhamNhaCungCapBLL.AddData(product);
                        switch (check)
                        {
                            case "success":
                                pProducers.Add(product);
                                string[] row = new string[] { product.Id.ToString(), product.Name, product.CategoryId.ToString(), product.Origin, product.Prices.ToString(), product.ProducerId.ToString(), product.Image, product.CreatedAt.ToString("dd-MM-yyyy hh:mm:ss"), product.UpdatedAt.ToString("dd-MM-yyyy hh:mm:ss") };
                                dgv_spncc.Rows.Add(row);
                                break;
                            default:
                            flagImport = true;
                                MessageBox.Show($"san pham {product.Id.ToString()} lỗi...");
                                break;
                        }
                    }

                   
                
            }

        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Import to Excel";
            openFileDialog.Filter = "Excel (*.xlsx) | *.xlsx|Excel 2003 (*.xls) | *.xls)";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImportExcel(openFileDialog.FileName);
                    if (!flagImport)
                    {
                        MessageBox.Show("Import thanh cong");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Import that bai\n" + ex.Message);
                }
            }
        }
    }
}
