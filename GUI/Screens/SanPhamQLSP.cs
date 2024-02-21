using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BLL;
using DTO;
using GUI.Popups;
using GUI.Properties;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Button = System.Windows.Forms.Button;
using Image = System.Drawing.Image;

namespace GUI.Screens
{
    public partial class SanPhamQLSP : UserControl
    {

        public static List<SpQLSPDTO> productCtl = new List<SpQLSPDTO>();
        Panel[] pnlProduct;
        Label[] id ;
        Label[] name ;
        Label[] type ;
        PictureBox[] img;
        Label[] price;
        Label[] origin;
        Label[] producer;
        Button[] btnEdit ;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        public SanPhamQLSP()
        {
            InitializeComponent();
            loadDataToProduct(GetResources());
        }
     

        private ComponentResourceManager GetResources()
        {
            return resources;
        }

        public void loadDataToProduct(ComponentResourceManager resources)
        {
            productCtl = SpQLSPBLL.GetData();
            pnlProduct = new Panel[productCtl.Count];
             id = new Label[productCtl.Count];
            name = new Label[productCtl.Count];
             type = new Label[productCtl.Count];
             img = new PictureBox[productCtl.Count];
            price = new Label[productCtl.Count];
            origin = new Label[productCtl.Count];
            producer = new Label[productCtl.Count];
            btnEdit = new Button[productCtl.Count];
            Font SmallFont = new Font("Arial", 11);
           


            for (int i = 0; i < productCtl.Count; i++)
            {
                pnlProduct[i] = new Panel();
                pnlProduct[i].BorderStyle = BorderStyle.FixedSingle;
                pnlProduct[i].Size = new Size(630, 64);

                id[i] = new Label();

                id[i].Location = new Point(17, 20);
                id[i].Size = new Size(16, 17);
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
                name[i].Location = new Point(53, 15);
                name[i].TextAlign = ContentAlignment.MiddleCenter;

                type[i] = new Label();
                type[i].Size = new Size(100, 17);
                type[i].Font = SmallFont;
                type[i].Margin = new Padding(2, 0, 2, 0);
                type[i].Text = productCtl[i].Type.ToString();
                type[i].Location = new Point(179, 20);
                type[i].TextAlign = ContentAlignment.MiddleCenter;

                img[i] = new PictureBox();
                img[i].Location = new Point(320, 10);
                img[i].Size = new Size(98, 57);
                img[i].Margin = new Padding(2, 0, 2, 0);
                img[i].Name = productCtl[i].Image;
                img[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                img[i].Image = new Bitmap(productCtl[i].Image);


                price[i] = new Label();
                price[i].Size = new Size(40, 23);
                price[i].Font = SmallFont;
                price[i].Margin = new Padding(2, 0, 2, 0);
                price[i].Text = productCtl[i].Prices.ToString();
                price[i].Location = new Point(470, 20);
                price[i].Name = productCtl[i].Quantity.ToString();
                price[i].TextAlign = ContentAlignment.MiddleCenter;

                origin[i] = new Label();
                origin[i].Size = new Size(26, 17);
                origin[i].Font = SmallFont;
                origin[i].Margin = new Padding(2, 0, 2, 0);
                origin[i].Text = productCtl[i].Origin.ToString();
                origin[i].Location = new Point(550, 20);
                origin[i].TextAlign = ContentAlignment.MiddleCenter;

                producer[i] = new Label();
                producer[i].Size = new Size(114, 17);
                producer[i].Font = SmallFont;
                producer[i].Margin = new Padding(2, 0, 2, 0);
                producer[i].Location = new Point(610, 20);
                producer[i].Text = productCtl[i].producer.ToString();
                producer[i].TextAlign = ContentAlignment.MiddleCenter;

                btnEdit[i] = new Button();
                btnEdit[i].Text = "Sửa";
                btnEdit[i].Size = new Size(50, 30);
                btnEdit[i].Margin = new Padding(2,1,2,1);
                btnEdit[i].Location = new Point(750, 14);
                btnEdit[i].TextAlign = ContentAlignment.MiddleCenter;
                btnEdit[i].Name = id[i].Text;
                btnEdit[i].Click += SanPhamQLSP_Click;

                pnlProduct[i].Controls.Add(id[i]);
                pnlProduct[i].Controls.Add(name[i]);
                pnlProduct[i].Controls.Add(type[i]);
                pnlProduct[i].Controls.Add(img[i]);
                pnlProduct[i].Controls.Add(price[i]);
                pnlProduct[i].Controls.Add(origin[i]);
                pnlProduct[i].Controls.Add(producer[i]);
                pnlProduct[i].Controls.Add(btnEdit[i]);
                panelForm.Controls.Add(pnlProduct[i]);

            }
            


        }

        private void SanPhamQLSP_Click(object sender, EventArgs e)
        {
            productCtl = SpQLSPBLL.GetData();
            for (int i=0; i< productCtl.Count; i++)
            {
                if (productCtl[i].Id.ToString() == (sender as Button).Name)
                {
                    UpdateSanPhamQLSP qlsp = new UpdateSanPhamQLSP(id[i].Text, name[i].Text, type[i].Text, origin[i].Text, price[i].Text, price[i].Name, img[i].Name, producer[i].Text);
                    
                    qlsp.ShowDialog();
                    break;
                }
            }
        }

        private void nameSP_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}

