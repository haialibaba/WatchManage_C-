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

namespace GUI.Popups
{
    public partial class AddSanPhamNhaCungCap : Form
    {
        public bool flagAdd = false;
        public PProducerDTO producerAdd;

        string Image = "";

        List<NhaCungCapDTO> producers = new List<NhaCungCapDTO>();
        List<DanhMucDTO> categories = new List<DanhMucDTO>();
        public AddSanPhamNhaCungCap()
        {
            InitializeComponent();
        }

        public AddSanPhamNhaCungCap(int id, List<NhaCungCapDTO> producers, List<DanhMucDTO> categories)
        {
            InitializeComponent();
            txt_id.Text = id.ToString();
            txt_name.GotFocus += RemoveTextName;
            txt_name.LostFocus += AddTextName;

            txt_prices.GotFocus += RemoveTextPrices;
            txt_prices.LostFocus += AddTextPrices;

            txt_origin.GotFocus += RemoveTextOrigin;
            txt_origin.LostFocus += AddTextOrigin;
            this.producers = producers;
            this.categories = categories;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                Image = open.FileName.Replace('\\','/');
            }
        }

        private void RemoveTextName(object sender, EventArgs e)
        {
            if (txt_name.Text == "Nhập tên sản phẩm")
            {
                txt_name.Text = "";
                txt_name.ForeColor = Color.Black;
            }
        }

        private void AddTextName(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text))
            {
                txt_name.Text = "Nhập tên sản phẩm";
                txt_name.ForeColor = Color.Gray;
            }
        }

   

        private void AddTextPrices(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_prices.Text))
            {
                txt_prices.Text = "Nhập giá";
                txt_prices.ForeColor = Color.Gray;
            }
        }
        private void RemoveTextPrices(object sender, EventArgs e)
        {
            if (txt_prices.Text == "Nhập giá")
            {
                txt_prices.Text = "";
                txt_prices.ForeColor = Color.Black;
            }
        }

        private void AddTextOrigin(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_origin.Text))
            {
                txt_origin.Text = "Nhập xuất xứ";
                txt_origin.ForeColor = Color.Gray;
            }
        }

        private void RemoveTextOrigin(object sender, EventArgs e)
        {
            if (txt_origin.Text == "Nhập xuất xứ")
            {
                txt_origin.Text = "";
                txt_origin.ForeColor = Color.Black;
            }
        }

        private void AddSanPhamNhaCungCap_Load(object sender, EventArgs e)
        {

            cbb_category.DisplayMember = "Text";
            cbb_category.ValueMember = "Value";
           
            foreach(DanhMucDTO category in categories)
            {
                var item = new { Text = category.Name, Value = category.Id } ;

                cbb_category.Items.Add(item);
            }


            cbb_producer.DisplayMember = "Text";
            cbb_producer.ValueMember = "Value";

            foreach (NhaCungCapDTO producer in producers)
            {
                var item = new { Text = producer.Name, Value = producer.Id };

                cbb_producer.Items.Add(item);
            }

        }

    
        private void btn_add_Click(object sender, EventArgs e)
        {
              int id = Convert.ToInt32(txt_id.Text);
            string name = txt_name.Text;
            
            string origin = txt_origin.Text;
            if(cbb_category.Text == "Chọn loại" || cbb_producer.Text == "Chọn nhà cung cấp")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
                return;
            }

            int category = (cbb_category.SelectedItem as dynamic).Value;
            int producer = (cbb_producer.SelectedItem as dynamic).Value;

            if (!BLL.Class1.IsNumber(txt_prices.Text))
            {
                MessageBox.Show("Giá phải là số và không được bỏ trống");
                return;
            }

            DateTime currentTime = DateTime.Now;
            PProducerDTO pProducer = new PProducerDTO();
            pProducer.Id = id;
            pProducer.Name = name;
            pProducer.Origin = origin;
            pProducer.CategoryId = category;
            pProducer.Prices = Convert.ToInt32(txt_prices.Text);
            pProducer.ProducerId = producer;

            pProducer.CreatedAt = currentTime;
            pProducer.UpdatedAt = currentTime;
            pProducer.Image = Image;

            string check = SanPhamNhaCungCapBLL.AddData(pProducer);
            switch (check)
            {
                case "required":
                    MessageBox.Show("Vui lòng nhập đầy đủ");
                    break;
                case "mysql_error":
                    MessageBox.Show("Lỗi trong quá trình chạy SQL");
                    break;
                case "success":
                    MessageBox.Show("Thêm sản phẩm thành công!");
                    flagAdd = true;
                    producerAdd = pProducer;
                    this.Hide();
                    break;
                default:
                    MessageBox.Show("Lỗi trong quá trình thêm!");
                    break;
            }
        }
    }
}
