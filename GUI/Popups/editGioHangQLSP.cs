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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI.Popups
{
    public partial class editGioHangQLSP : Form
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }

        public string typeID { get; set; }
        public string Origin { get; set; }
        public string Prices { get; set; }

        public string Quantity { get; set; }
        public string Image { get; set; }

        public string Producer { get; set; }

        public spnccDTO cart;

        public editGioHangQLSP(string id, string name, string type,string typeID, string Origin, string Prices, string Quantity, string Image, string producer)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.typeID = typeID;
            this.Origin = Origin;
            this.Prices = Prices;
            this.Quantity = Quantity;
            this.Image = Image;
            this.Producer = producer;
            this.Quantity = Quantity;
            InitializeComponent();
            show();
        }

        public void show()
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



        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
 
            cart = new spnccDTO(int.Parse(id), name, type,typeID, Origin, DateTime.Now, int.Parse(Prices), int.Parse(txt_quantity.Text), Image, int.Parse(Producer));
            this.Hide();
        }
    }
}
