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

namespace GUI.Popups
{
    public partial class UpdateBaoHanh : Form
    {
        public bool flag = false;
        public BaoHanhDTO maintain = new BaoHanhDTO();
        List<PProducerDTO> products = new List<PProducerDTO>();
        public UpdateBaoHanh()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public UpdateBaoHanh(BaoHanhDTO maintain, List<PProducerDTO> products)
        {
            InitializeComponent();


            cbb_product.DisplayMember = "Text";
            cbb_product.ValueMember = "Value";
            foreach (PProducerDTO product in products)
            {
                var item = new { Text = $"{product.Id} - {product.Name}", Value = product.Id };

                cbb_product.Items.Add(item);
            }
            this.maintain = maintain;
            this.products = products;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UpdateBaoHanh_Load(object sender, EventArgs e)
        {
            foreach (PProducerDTO product in products)
            {
                if (product.Id == maintain.ProductId)
                {
                    var item = new { Text = $"{product.Id} - {product.Name}", Value = product.Id };
                    cbb_product.SelectedItem = item;
                    break;
                }
            }

            num_time.Value = maintain.Time;
            txt_id.Text = maintain.Id.ToString();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);
            int productId = (cbb_product.SelectedItem as dynamic).Value;
            int time = Convert.ToInt32(num_time.Value);

            BaoHanhDTO newMaintain = new BaoHanhDTO();
            newMaintain.Id = id;
            newMaintain.ProductId = productId;
            newMaintain.Time = time;

            string check = BaoHanhBLL.UpdateData(newMaintain);

            switch (check)
            {
                case "success":
                    flag = true;
                    maintain = newMaintain;
                    this.Hide();
                    break;
                case "required_time":
                    MessageBox.Show("Thời gian phải lớn hơn 0");
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
