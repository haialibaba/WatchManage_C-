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
using GUI.Popups;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace GUI.Screens
{
    public partial class GioHangQLSP : UserControl
    {


        Panel[] pnlProduct;
        Label[] id;
        Label[] name;
        Label[] type;
        PictureBox[] img;
        Label[] price;
        Label[] origin;
        Label[] quantity;
        Label[] producer;
        Button[] btnEdit;
        Button[] btnDelete;
        List<spnccDTO> carts = new List<spnccDTO>();
        public List<spcDTO> listProductChild = new List<spcDTO>();
        private bool flag = false;
        public static List<hoadonDTO> bills = new List<hoadonDTO>();

        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        public GioHangQLSP()
        {
            InitializeComponent();
            loadDataToCart(NhapHangQLSP.cart);
        }
        public void loadDataToCart(List<spnccDTO> carts)
        {   
            panel1.Controls.Clear();
            pnlProduct = new Panel[carts.Count];
            id = new Label[carts.Count];
            name = new Label[carts.Count];
            type = new Label[carts.Count];
            img = new PictureBox[carts.Count];
            price = new Label[carts.Count];
            quantity = new Label[carts.Count];
            origin = new Label[carts.Count];
            producer = new Label[carts.Count];
            btnEdit = new Button[carts.Count];
            btnDelete = new Button[carts.Count];
            Font SmallFont = new Font("Arial", 11);

            for (int i = 0; i < carts.Count; i++)
            {
                pnlProduct[i] = new Panel();
                pnlProduct[i].BorderStyle = BorderStyle.FixedSingle;
                pnlProduct[i].Size = new Size(680, 64);

                id[i] = new Label();
                id[i].Location = new Point(17, 24);
                id[i].Size = new Size(16, 17);
                id[i].Margin = new Padding(2, 0, 2, 0);
                id[i].Font = SmallFont;
                id[i].Text = carts[i].Id.ToString();
                id[i].TextAlign = ContentAlignment.MiddleCenter;


                name[i] = new Label();
                name[i].Size = new Size(104, 30);
                name[i].ForeColor = Color.Black;
                name[i].Font = SmallFont;
                name[i].Text = carts[i].Name.ToString();
                name[i].Margin = new Padding(2, 0, 2, 0);
                name[i].Location = new Point(36, 15);
                name[i].TextAlign = ContentAlignment.MiddleCenter;

                type[i] = new Label();
                type[i].Size = new Size(100, 17);
                type[i].Font = SmallFont;
                type[i].Margin = new Padding(2, 0, 2, 0);
                type[i].Text = carts[i].Type.ToString();
                type[i].Location = new Point(150, 24);
                type[i].TextAlign = ContentAlignment.MiddleCenter;

                img[i] = new PictureBox();
                img[i].Location = new Point(270, 5);
                img[i].Size = new Size(90,52);
                img[i].Margin = new Padding(2, 0, 2, 0);
                img[i].Name = carts[i].Image;
                img[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                img[i].Image = new Bitmap(carts[i].Image);

                price[i] = new Label();
                price[i].Size = new Size(55, 23);
                price[i].Font = SmallFont;
                price[i].Margin = new Padding(2, 0, 2, 0);
                price[i].Text = carts[i].Prices.ToString();
                price[i].Location = new Point(380, 21);
                price[i].TextAlign = ContentAlignment.MiddleCenter;

                origin[i] = new Label();
                origin[i].Size = new Size(50, 17);
                origin[i].Font = SmallFont;
                origin[i].Margin = new Padding(2, 0, 2, 0);
                origin[i].Text = carts[i].Origin.ToString();
                origin[i].Location = new Point(450, 23);
                origin[i].TextAlign = ContentAlignment.MiddleCenter;

                quantity[i] = new Label();
                quantity[i].Size = new Size(30, 17);
                quantity[i].Font = SmallFont;
                quantity[i].Margin = new Padding(2, 0, 2, 0);
                quantity[i].Location = new Point(520, 23);
                quantity[i].Text = carts[i].Quantity.ToString();

                btnEdit[i] = new Button();
                btnEdit[i].Text = "Sửa";
                btnEdit[i].Size = new Size(50, 30);
                btnEdit[i].Margin = new Padding(2, 1, 2, 1);
                btnEdit[i].Location = new Point(560, 14);
                btnEdit[i].TextAlign = ContentAlignment.MiddleCenter;
                btnEdit[i].Name = id[i].Text;
                btnEdit[i].Click += sua;

                btnDelete[i] = new Button();
                btnDelete[i].Text = "Xóa";
                btnDelete[i].Size = new Size(50, 30);
                btnDelete[i].Margin = new Padding(2, 1, 2, 1);
                btnDelete[i].Location = new Point(620, 14);
                btnDelete[i].TextAlign = ContentAlignment.MiddleCenter;
                btnDelete[i].Name = id[i].Text;
                btnDelete[i].Click += xoa;

                pnlProduct[i].Controls.Add(id[i]);
                pnlProduct[i].Controls.Add(name[i]);
                pnlProduct[i].Controls.Add(type[i]);
                pnlProduct[i].Controls.Add(img[i]);
                pnlProduct[i].Controls.Add(price[i]);
                pnlProduct[i].Controls.Add(origin[i]);
                pnlProduct[i].Controls.Add(quantity[i]);
                pnlProduct[i].Controls.Add(btnEdit[i]);
                pnlProduct[i].Controls.Add(btnDelete[i]);
                panel1.Controls.Add(pnlProduct[i]);

            }



        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            foreach (spnccDTO item in NhapHangQLSP.cart)
            {
                listProductChild.Add(new spcDTO(item.Id.ToString(), item.Quantity.ToString()));
                spnccDTO product = new spnccDTO(item.Id, item.Name.ToString(), item.Type,item.TypeID, item.Origin.ToString(), DateTime.Now, item.Prices, item.Quantity,item.Image.ToString(), item.Producer);

                foreach (SpQLSPDTO item1 in SanPhamQLSP.productCtl)
                {
                    if (product.Id == item1.Id)
                    {
                        product.Quantity += item1.Quantity;
                        spnccBLL.UpdateData(product);
                    }
                    else
                    {
                        spnccBLL.AddData(product);
                    }
                }

                
            }
            bool flag = spnccBLL.AddDataSPC(listProductChild);
            if (flag)
            {
                MessageBox.Show("Thanh toán thành công");


                HoaDonNhapHang bill = new HoaDonNhapHang(Login.user.Username.ToString(), "1", DateTime.Now, Total(NhapHangQLSP.cart));
                    bill.ShowDialog();
                NhapHangQLSP.cart.Clear();
                panel1.Controls.Clear();
              


            }

        }

       
        int Total(List<spnccDTO> cart)
        {
            int sum = 0;
            for (int i = 0; i < cart.Count; i++)
            {
                sum += int.Parse(quantity[i].Text) * cart[i].Prices;
            }
            return sum;
        }
      
        private void GioHangQLSP_Load(object sender, EventArgs e)
        {

        }
     

        private void GioHangQLSP_Paint(object sender, PaintEventArgs e)
        {
            loadDataToCart(NhapHangQLSP.cart);

            label6.Text = Total(NhapHangQLSP.cart).ToString();

        }

        private void GioHangQLSP_EnabledChanged(object sender, EventArgs e)
        {
        }

        private void GioHangQLSP_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                sua(sender, e);
            }

            else
            {
                xoa(sender, e);
            }
                
        }

        public void sua(object sender, EventArgs e)
        {
                foreach (spnccDTO item in NhapHangQLSP.cart)
                {
                    if (item.Id.ToString() == (sender as Button).Name)
                    {
                        editGioHangQLSP editgh = new editGioHangQLSP(item.Id.ToString(), item.Name.ToString(), item.Type.ToString(), item.TypeID.ToString(), item.Origin.ToString(), item.Prices.ToString(), item.Quantity.ToString(), item.Image.ToString(), item.Producer.ToString());
                        editgh.ShowDialog();
                        if (item.Id.ToString() == editgh.cart.Id.ToString())
                        {
                            item.Quantity = editgh.cart.Quantity;
                            loadDataToCart(NhapHangQLSP.cart);
                        }
                    }
                }

            
        }

        public void xoa(object sender, EventArgs e)
        {

                var DialogResult = MessageBox.Show("Are you sure you want to delete", "Are you sure?", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes) //Creates the yes function
                {
                    foreach (spnccDTO item in NhapHangQLSP.cart)
                    {
                        if (item.Id.ToString() == (sender as Button).Name)
                        {
                            NhapHangQLSP.cart.Remove(item);
                            loadDataToCart(NhapHangQLSP.cart);
                            break;
                        }
                    }
                }
            
        }
        private void GioHangQLSP_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void GioHangQLSP_TabStopChanged(object sender, EventArgs e)
        {
            
        }

        private void GioHangQLSP_ParentChanged(object sender, EventArgs e)
        {
        }

        private void GioHangQLSP_AutoValidateChanged(object sender, EventArgs e)
        {

        }

        private void GioHangQLSP_Validated(object sender, EventArgs e)
        {
           
        }

        private void GioHangQLSP_Validating(object sender, CancelEventArgs e)
        {
        }

        private void GioHangQLSP_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void GioHangQLSP_EnabledChanged_1(object sender, EventArgs e)
        {
    
        }

        private void GioHangQLSP_ControlAdded(object sender, ControlEventArgs e)
        {
            
        }

        private void GioHangQLSP_DockChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
