using BLL;
using DTO;
using GUI.Popups;
using GUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Screens
{
    public partial class SanPhamBanHangcs : UserControl
    {
        List<SPBanHangDTO> producerBH = new List<SPBanHangDTO>();

        List<SpQLSPDTO> productCtl = new List<SpQLSPDTO>();
        public SanPhamBanHangcs()
        {
            InitializeComponent();
            loadDataToDataSPBH();
        }
       

        private void loadDataToDataSPBH()
        {
            productCtl = SpQLSPBLL.GetData();
            Panel[] pnlProduct = new Panel[productCtl.Count];
            Label[] id = new Label[productCtl.Count];
            Label[] name = new Label[productCtl.Count];
            Label[] type = new Label[productCtl.Count];
            PictureBox[] img = new PictureBox[productCtl.Count];
            Label[] price = new Label[productCtl.Count];
            Label[] origin = new Label[productCtl.Count];
            Label[] producer = new Label[productCtl.Count];
            Font SmallFont = new Font("Arial", 11);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));


            for (int i = 0; i < productCtl.Count; i++)
            {
                pnlProduct[i] = new Panel();
                pnlProduct[i].BorderStyle = BorderStyle.FixedSingle;
                pnlProduct[i].Size = new Size(630, 64);

                id[i] = new Label();
                id[i].Location = new Point(25, 32);
                id[i].Size = new Size(25, 30);
                id[i].Margin = new Padding(2, 0, 2, 0);
                id[i].Font = SmallFont;
                id[i].Text = productCtl[i].Id.ToString();
                id[i].TextAlign = ContentAlignment.MiddleCenter;



                name[i] = new Label();
                name[i].Size = new Size(104, 30);
                name[i].ForeColor = Color.Black;
                name[i].Font = SmallFont;
                name[i].Text = productCtl[i].Name.ToString();
                name[i].Margin = new Padding(2, 0, 2, 0);
                name[i].Location = new Point(110, 32);
                name[i].TextAlign = ContentAlignment.MiddleCenter;
                name[i].Click += SanPhamBanHangcs_Click;

                type[i] = new Label();
                type[i].Size = new Size(100, 30);
                type[i].Font = SmallFont;
                type[i].Margin = new Padding(2, 0, 2, 0);
                type[i].Text = productCtl[i].Type.ToString();
                type[i].Location = new Point(260, 32);
                type[i].TextAlign = ContentAlignment.MiddleCenter;

                img[i] = new PictureBox();
                img[i].Location = new Point(410, 15);
                img[i].Size = new Size(98, 57);
                img[i].Margin = new Padding(2, 0, 2, 0);
                img[i].Name = productCtl[i].Image;
                img[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                img[i].Image = new Bitmap(productCtl[i].Image);



                price[i] = new Label();
                price[i].Size = new Size(40, 32);
                price[i].Font = SmallFont;
                price[i].Margin = new Padding(2, 0, 2, 0);
                price[i].Text = productCtl[i].Prices.ToString();
                price[i].Location = new Point(580, 32);
                price[i].TextAlign = ContentAlignment.MiddleCenter;

                origin[i] = new Label();
                origin[i].Size = new Size(26, 32);
                origin[i].Font = SmallFont;
                origin[i].Margin = new Padding(2, 0, 2, 0);
                origin[i].Text = productCtl[i].Origin.ToString();
                origin[i].Location = new Point(680, 32);
                origin[i].TextAlign = ContentAlignment.MiddleCenter;

                producer[i] = new Label();
                producer[i].Size = new Size(150, 32);
                producer[i].Font = SmallFont;
                producer[i].Margin = new Padding(2, 0, 2, 0);
                producer[i].Location = new Point(760, 32);
                producer[i].Text = productCtl[i].producer.ToString();
                producer[i].TextAlign = ContentAlignment.MiddleCenter;



                pnlProduct[i].Controls.Add(id[i]);
                pnlProduct[i].Controls.Add(name[i]);
                pnlProduct[i].Controls.Add(type[i]);
                pnlProduct[i].Controls.Add(img[i]);
                pnlProduct[i].Controls.Add(price[i]);
                pnlProduct[i].Controls.Add(origin[i]);
                pnlProduct[i].Controls.Add(producer[i]);

                panelForm.Controls.Add(pnlProduct[i]);

            }
        }


    

            private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void floSPBH_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SanPhamBanHangcs_Click(object sender, EventArgs e)
        {
            foreach(var item in productCtl)
            {
                SPConBanHang spc = new SPConBanHang(item.Id.ToString(), item.Name.ToString(), item.Image.ToString());
                spc.ShowDialog();
            }

        }
    }
}
