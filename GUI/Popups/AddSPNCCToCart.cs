using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Image = System.Drawing.Image;

namespace GUI.Popups
{
   
    public partial class AddSPNCCToCart : Form
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string Origin { get; set; }
        public string Prices { get; set; }

        public string typeID { get; set; }
        public string Quantity { get; set; }
        public string Image { get; set; }

        public string Producer { get; set; }

        List<spnccDTO> producers = new List<spnccDTO>();
        public spnccDTO cart;


        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        public AddSPNCCToCart(string id, string name, string type,string typeID, string Origin, string Prices,string Quantity, string Image,string producer)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.typeID = typeID;
            this.Origin = Origin;
            this.Prices = Prices;
            this.Quantity = Quantity; 
            this.Image = Image;
            this.Producer= producer;
            InitializeComponent();
            _show();
            
        }
        public void _show()
        {
            txt_id.Text = id;
            txt_id.Enabled = false;
            txt_name.Text = name;
            txt_name.Enabled = false;
            cbb_type.Text = type;
            cbb_type.Enabled = false;
            cbb_type.SelectedValue = typeID;
            txt_price.Text = Prices;
            txt_price.Enabled = false;
            txt_quantity.Text = Quantity;
            txt_origin.Text = Origin;
            txt_origin.Enabled = false;
            pictureBox1.Image = new Bitmap(Image); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cart = new spnccDTO(int.Parse(id), name, type,typeID, Origin, DateTime.Now, int.Parse(Prices), int.Parse(txt_quantity.Text), Image, int.Parse(Producer));
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbb_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txt_origin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
