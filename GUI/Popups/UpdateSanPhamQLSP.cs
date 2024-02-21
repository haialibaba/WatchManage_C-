using BLL;
using DTO;
using GUI.Properties;
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Image = System.Drawing.Image;

namespace GUI.Popups
{
    public partial class UpdateSanPhamQLSP : Form
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string Origin { get; set; }
        public string Prices { get; set; }

        public string Quantity { get; set; }

        public string Image { get; set; }
        public string producer { get; set; }

        public bool flag = false;
        List<SpQLSPDTO> producttype = new List<SpQLSPDTO>();
        List<SpQLSPDTO> productproducer = new List<SpQLSPDTO>();
        public SpQLSPDTO product;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        public UpdateSanPhamQLSP(string id, string name, string type, string Origin, string Prices,string Quantity, string Image, string producer)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.Origin = Origin;
            this.Prices = Prices;
            this.Quantity = Quantity;
            this.Image = Image;
            this.producer = producer;
            InitializeComponent();
            _show();
        }
        public void _show()
        {
            txt_id.Text = id;
            txt_id.Enabled = false;
            txt_name.Text = name;
            producttype = SpQLSPBLL.GetDatacbbType();
            productproducer = SpQLSPBLL.GetDatacbbProducer();

            cbb_type.DisplayMember = "Text";
            cbb_type.ValueMember = "Value";
            foreach (SpQLSPDTO product in producttype)
            {
                var item = new { Text = $"{product.Type}", Value = product.Id };

                cbb_type.Items.Add(item);
            }

            cbb_type.Text = type;
            txt_price.Text = Prices;
            txt_price.Name = Quantity;
            txt_origin.Text = Origin;
            cbb_producer.DisplayMember = "Text";
            cbb_producer.ValueMember = "Value";
            foreach (SpQLSPDTO producer in productproducer)
            {
                var item = new { Text = $"{producer.producer}", Value = producer.Id };
                cbb_producer.Items.Add(item);
            }
            cbb_producer.Text = producer;
            pictureBox1.Image= new Bitmap(Image);
        }
        


        private void button2_Click(object sender, EventArgs e)
        {
           
            int type = (cbb_type.SelectedItem as dynamic).Value;
            int producer = (cbb_producer.SelectedItem as dynamic).Value;
            SpQLSPDTO product = new SpQLSPDTO(int.Parse(txt_id.Text),txt_name.Text, type.ToString(), txt_origin.Text,DateTime.Now,int.Parse(txt_price.Text), int.Parse(txt_price.Name),Image, producer.ToString());
            SpQLSPBLL.UpdateData(product);
            MessageBox.Show("Thay đổi thành công");
            
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                // image file path  
                Image = open.FileName.Replace('\\', '/');
            }
        }

        private void cbb_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
