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
    public partial class UpdateSanPhamNhaCungCap : Form
    {
        public bool flag = false;
        public PProducerDTO pProducer = new PProducerDTO();
        string Image = "";

        List<NhaCungCapDTO> producers = new List<NhaCungCapDTO>();
        List<DanhMucDTO> categories = new List<DanhMucDTO>();


        public UpdateSanPhamNhaCungCap()
        {
            InitializeComponent();
        }

        public UpdateSanPhamNhaCungCap(PProducerDTO pproducer, List<NhaCungCapDTO> producers, List<DanhMucDTO> categories)
        {
            InitializeComponent();
            this.pProducer = pproducer;
           
            this.producers = producers;
            this.categories = categories;

            cbb_category.DisplayMember = "Text";
            cbb_category.ValueMember = "Value";

            foreach (DanhMucDTO category in categories)
            {
                var item = new { Text = category.Name, Value = category.Id };

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


        private void UpdateSanPhamNhaCungCap_Load(object sender, EventArgs e)
        {
            foreach(DanhMucDTO category in categories)
            {
                if(category.Id == pProducer.CategoryId)
                {
                    var item = new { Text = category.Name, Value = category.Id };
                    cbb_category.SelectedItem = item;
                    break;
                }
            }

            foreach(NhaCungCapDTO producer in producers)
            {
                if(producer.Id == pProducer.ProducerId)
                {
                    var item = new { Text = producer.Name, Value = producer.Id };

                    cbb_producer.SelectedItem = item;
                    break;
                }
            }

            txt_id.Text = pProducer.Id.ToString();
            txt_name.Text = pProducer.Name;
            txt_origin.Text = pProducer.Origin;
            txt_prices.Text = pProducer.Prices.ToString();
            pictureBox1.Image = new Bitmap(pProducer.Image);
            Image = pProducer.Image;
            txt_name.GotFocus += RemoveTextName;
            txt_name.LostFocus += AddTextName;

            txt_origin.GotFocus += RemoveTextOrigin;
            txt_origin.LostFocus += AddTextOrigin;

            txt_prices.GotFocus += RemoveTextPrices;
            txt_prices.LostFocus += AddTextPrices;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);
            string name = txt_name.Text;
            if (cbb_category.Text == "Chọn loại" || cbb_producer.Text == "Chọn nhà cung cấp")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
                return;
            }

            if (!BLL.Class1.IsNumber(txt_prices.Text))
            {
                MessageBox.Show("Giá phải là số và không được bỏ trống");
                return;
            }

            int prices = Convert.ToInt32(txt_prices.Text);
            string origin = txt_origin.Text;
            int category = (cbb_category.SelectedItem as dynamic).Value;
            int producer = (cbb_producer.SelectedItem as dynamic).Value;

            PProducerDTO productProducer = new PProducerDTO();
            productProducer.Id = id;
            productProducer.Name = name;
            productProducer.Image = Image;
            productProducer.Origin = origin;
            productProducer.Prices = prices;
            productProducer.CategoryId = category;
            productProducer.ProducerId = producer;

            string check = SanPhamNhaCungCapBLL.UpdateData(productProducer);
            switch (check)
            {
                case "success":
                    flag = true;
                    pProducer = productProducer;
                    this.Hide();
                    break;
                case "required":
                    MessageBox.Show("Vui lòng nhập đầy đủ");
                    break;
                case "mysql_error":
                    MessageBox.Show("Có lỗi xảy ra trong quá trình chạy SQL");
                    break;
                default:
                    MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại");
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                Image = open.FileName.Replace('\\', '/');
            }
        }

        private void cbb_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbb_producer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
