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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace GUI.Screens
{
    public partial class SPConBanHang : Form
    {

        Panel pnlProduct;
        Label idSPC;
        public string id { get; set; }
        public string name { get; set; }
        public string image { get; set; }

        List<SpQLSPDTO> productCon = new List<SpQLSPDTO>();

        public SPConBanHang(string id, string name, string image)
        {
            this.id = id;
            this.name = name;
            this.image = image;
            InitializeComponent();
        }

        public void show(List<SpQLSPDTO> productCon)
        {
            pnlProduct = new Panel();
            idSPC = new Label();
            Font SmallFont = new Font("Arial", 11);

                pnlProduct = new Panel();
                pnlProduct.BorderStyle = BorderStyle.FixedSingle;
                pnlProduct.Size = new Size(645, 83);

                idSPC = new Label();
                idSPC.Location = new Point(26, 31);
                idSPC.Size = new Size(16, 17);
                idSPC.Margin = new Padding(2, 0, 2, 0);
                idSPC.Font = SmallFont;
                idSPC.Text = id.ToString();
                idSPC.TextAlign = ContentAlignment.MiddleCenter;

                pnlProduct.Controls.Add(idSPC);
                flowSPC.Controls.Add(pnlProduct);
            


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
