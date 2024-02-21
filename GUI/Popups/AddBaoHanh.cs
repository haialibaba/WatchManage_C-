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
    public partial class AddBaoHanh : Form
    {


        public bool flag = false;
        public BaoHanhDTO maintain = new BaoHanhDTO();
        List<BaoHanhDTO> maintains = new List<BaoHanhDTO>();
        List<PProducerDTO> products = new List<PProducerDTO>();

        public AddBaoHanh()
        {
            InitializeComponent();
        }

        private void AddBaoHanh_Load(object sender, EventArgs e)
        {
            
        }

        public AddBaoHanh(int id,List<BaoHanhDTO> baohanh)
        {
            InitializeComponent();
            cbb_product.DisplayMember = "Text";
            cbb_product.ValueMember = "Value";
            txt_id.Text = id.ToString();
            this.products = SanPhamNhaCungCapBLL.GetData();
            this.maintains = baohanh;

            foreach (PProducerDTO product in products)
            {
                var item = new { Text = $"{product.Id} - {product.Name}", Value = product.Id };

                cbb_product.Items.Add(item);
            }
           
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);
            if(cbb_product.Text == "Chọn sản phẩm")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
                return;
            }

            int productId = (cbb_product.SelectedItem as dynamic).Value;
            int time = Convert.ToInt32(num_time.Value);

            BaoHanhDTO newMainTain = new BaoHanhDTO();
            newMainTain.Id = id;
            newMainTain.ProductId = productId;
            newMainTain.Time = time;
            string check = BaoHanhBLL.AddData(newMainTain, maintains);
            switch (check)
            {
                case "success":
                    MessageBox.Show("Thêm thành công");
                    flag = true;
                    maintain = newMainTain;
                    this.Hide();
                    break;
                case "required_time":
                    MessageBox.Show("Thời gian phải lớn hơn 0");
                    break;
                case "duplicate":
                    MessageBox.Show("Sản phẩm này đã có bảo hành");
                    break;
                case "mysql_erorr":
                    MessageBox.Show("Lỗi trong quá trình chạy SQL");
                    break;
                default:
                    MessageBox.Show("Lỗi trong quá trình thêm!");
                    break;
            }
        }
    }
}
