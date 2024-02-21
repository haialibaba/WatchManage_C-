using BLL;
using DTO;
using GUI.Popups;
using GUI.Properties;
using Org.BouncyCastle.Asn1.BC;
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

namespace GUI.Screens
{
    public partial class NhapHangQLSP : UserControl
    {
       
        List<string> listIcon = new List<string>() {
            "btn_banhang.Image",
            "btn_sanpham.Image",
            "btn_danhmuc.Image",
            "btn_nhacungcap.Image",
            "btn_nhanvien.Image",
            "btn_khachhang.Image",

        };
        private bool flag=false;
        List<spnccDTO> productCtl = new List<spnccDTO>();
        List<spnccDTO> producers = new List<spnccDTO>();
        List<spnccDTO> productFilterNCC = new List<spnccDTO>();
        public static List<spnccDTO> cart = new List<spnccDTO>();

        Panel[] pnlProduct;
        Label[] id;
        Label[] name;
        Label[] type;
        PictureBox[] img;
        Label[] price;
        Label[] origin;
        Label[] producer;
        Button[] btnEdit;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

        public NhapHangQLSP()
        {
            InitializeComponent(); 
            producers = spnccBLL.GetDatacbbType();
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
            foreach (spnccDTO product in producers)
            {
                var item = new { Text = $"{product.Name}", Value = product.Id };
                comboBox1.Items.Add(item);
            }
            productCtl = spnccBLL.GetData();
            loadDataToProductNCC(productCtl);
        }



        public void loadDataToProductNCC(List<spnccDTO> productCtl)
        {
            NhNCC.Controls.Clear();
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
                pnlProduct[i].Size = new Size(670, 64);

                id[i] = new Label();
                id[i].Location = new Point(30, 27);
                id[i].Size = new Size(16, 17);
                id[i].Margin = new Padding(2, 0, 2, 0);
                id[i].Font = SmallFont;
                id[i].Text = productCtl[i].Id.ToString();
                id[i].TextAlign = ContentAlignment.MiddleCenter;



                name[i] = new Label();
                name[i].Size = new Size(104, 44);
                name[i].ForeColor = Color.Black;
                name[i].Font = SmallFont;
                name[i].Text = productCtl[i].Name.ToString();
                name[i].Margin = new Padding(2, 0, 2, 0);
                name[i].Location = new Point(70, 15);
                name[i].TextAlign = ContentAlignment.MiddleCenter;

                type[i] = new Label();
                type[i].Size = new Size(100, 20);
                type[i].Font = SmallFont;
                type[i].Margin = new Padding(2, 0, 2, 0);
                type[i].Text = productCtl[i].Type.ToString();
                type[i].Name = productCtl[i].TypeID.ToString();
                type[i].Location = new Point(230, 30);
                type[i].TextAlign = ContentAlignment.MiddleCenter;

                img[i] = new PictureBox();
                img[i].Location = new Point(410, 10);
                img[i].Size = new Size(98, 57);
                img[i].Margin = new Padding(2, 0, 2, 0);
                img[i].Name = productCtl[i].Image;
                img[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                img[i].Image = new Bitmap(productCtl[i].Image);


                price[i] = new Label();
                price[i].Size = new Size(70, 20);
                price[i].Font = SmallFont;
                price[i].Margin = new Padding(2, 0, 2, 0);
                price[i].Text = productCtl[i].Prices.ToString();
                price[i].Location = new Point(570, 32);
                price[i].TextAlign = ContentAlignment.MiddleCenter;

                origin[i] = new Label();
                origin[i].Size = new Size(26, 35);
                origin[i].Font = SmallFont;
                origin[i].Margin = new Padding(2, 0, 2, 0);
                origin[i].Text = productCtl[i].Origin.ToString();
                origin[i].Location = new Point(685, 32);
                origin[i].TextAlign = ContentAlignment.MiddleCenter;

                btnEdit[i] = new Button();
                btnEdit[i].Text = "Thêm";
                btnEdit[i].Size = new Size(80, 30);
                btnEdit[i].Margin = new Padding(2, 1, 2, 1);
                btnEdit[i].Location = new Point(770, 32);
                btnEdit[i].TextAlign = ContentAlignment.MiddleCenter;
                btnEdit[i].Name = id[i].Text;
                btnEdit[i].Click += NhapHangQLSP_Click;


                pnlProduct[i].Controls.Add(id[i]);
                pnlProduct[i].Controls.Add(name[i]);
                pnlProduct[i].Controls.Add(type[i]);
                pnlProduct[i].Controls.Add(img[i]);
                pnlProduct[i].Controls.Add(price[i]);
                pnlProduct[i].Controls.Add(origin[i]);
                pnlProduct[i].Controls.Add(producer[i]);
                pnlProduct[i].Controls.Add(btnEdit[i]);

                NhNCC.Controls.Add(pnlProduct[i]);

            }
        }

        public void loadDataToProduct(List<spnccDTO> productCtl)
        {
            NhNCC.Controls.Clear();
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
                pnlProduct[i].Size = new Size(670, 64);


                id[i] = new Label();
                id[i].Location = new Point(15, 22);
                id[i].Size = new Size(16, 17);
                id[i].Margin = new Padding(2, 0, 2, 0);
                id[i].Font = SmallFont;
                id[i].Text = productCtl[i].Id.ToString();
                id[i].TextAlign = ContentAlignment.MiddleCenter;

                name[i] = new Label();
                name[i].Size = new Size(104, 44);
                name[i].ForeColor = Color.Black;
                name[i].Font = SmallFont;
                name[i].Text = productCtl[i].Name.ToString();
                name[i].Margin = new Padding(2, 0, 2, 0);
                name[i].Location = new Point(40, 9);
                name[i].TextAlign = ContentAlignment.MiddleCenter;

                type[i] = new Label();
                type[i].Size = new Size(100, 20);
                type[i].Font = SmallFont;
                type[i].Margin = new Padding(2, 0, 2, 0);
                type[i].Name = productCtl[i].TypeID.ToString();
                type[i].Text = productCtl[i].Type.ToString();
                type[i].Location = new Point(160, 22);
                type[i].TextAlign = ContentAlignment.MiddleCenter;

                img[i] = new PictureBox();
                img[i].Location = new Point(290, 10);
                img[i].Size = new Size(70, 45);
                img[i].Margin = new Padding(2, 0, 2, 0);
                img[i].Name = productCtl[i].Image;
                img[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                img[i].Image = new Bitmap(productCtl[i].Image);


                price[i] = new Label();
                price[i].Size = new Size(90, 20);
                price[i].Font = SmallFont;
                price[i].Margin = new Padding(2, 0, 2, 0);
                price[i].Text = productCtl[i].Prices.ToString();
                price[i].Location = new Point(370, 18);
                price[i].TextAlign = ContentAlignment.MiddleCenter;

                origin[i] = new Label();
                origin[i].Size = new Size(60, 40);
                origin[i].Font = SmallFont;
                origin[i].Margin = new Padding(2, 0, 2, 0);
                origin[i].Text = productCtl[i].Origin.ToString();
                origin[i].Location = new Point(480, 9);
                origin[i].TextAlign = ContentAlignment.MiddleCenter;

                btnEdit[i] = new Button();
                btnEdit[i].Text = "Thêm";
                btnEdit[i].Size = new Size(80, 30);
                btnEdit[i].Margin = new Padding(2, 1, 2, 1);
                btnEdit[i].Location = new Point(570, 15);
                btnEdit[i].TextAlign = ContentAlignment.MiddleCenter;
                btnEdit[i].Name = id[i].Text;
                btnEdit[i].Click += NhapHangQLSP_Click;

                pnlProduct[i].Controls.Add(id[i]);
                pnlProduct[i].Controls.Add(name[i]);
                pnlProduct[i].Controls.Add(type[i]);
                pnlProduct[i].Controls.Add(img[i]);
                pnlProduct[i].Controls.Add(price[i]);
                pnlProduct[i].Controls.Add(origin[i]);
                pnlProduct[i].Controls.Add(producer[i]);
                pnlProduct[i].Controls.Add(btnEdit[i]);

                NhNCC.Controls.Add(pnlProduct[i]);
            }


        }
    


        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void NhapHangQLSP_Click(object sender, EventArgs e)
        {
        
            if (flag)
            {
                xuly(productFilterNCC, sender);
            }
            else
            {
                xuly(productCtl, sender);
            }

        }
        public void xuly(List<spnccDTO> list, object sender)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Id.ToString() == (sender as Button).Name)
                {
                    AddSPNCCToCart spncctc = new AddSPNCCToCart(id[i].Text, name[i].Text, type[i].Text, type[i].Name.ToString(), origin[i].Text, price[i].Text, "1", img[i].Name, productCtl[i].Producer.ToString());
                    spncctc.ShowDialog();
                    if(spncctc.cart != null)
                    {
                        if (!checkExistCart(spncctc.cart))
                        {
                            cart.Add(spncctc.cart);
                        }
                    }
                   
                    break;
                }
            }
        }

        bool checkExistCart(spnccDTO carts)
        {
            bool flag = false;
            foreach(spnccDTO item in cart)
            {
                if(item.Id == carts.Id)
                {
                    item.Quantity+= carts.Quantity;
                    flag = true;
                    break;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            return flag;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            productFilterNCC.Clear();
            int producerID = (comboBox1.SelectedItem as dynamic).Value;
            for (int i = 0; i < productCtl.Count; i++)
            {
                if (productCtl[i].Producer.ToString() == producerID.ToString())
                {
                    
                    productFilterNCC.Add(productCtl[i]);
                }
            }
            flag = true;
            loadDataToProduct(productFilterNCC);
        }

        private void NhNCC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NhapHangQLSP_Load(object sender, EventArgs e)
        {

        }
    }
}

