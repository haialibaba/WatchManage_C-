using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Popups
{
    public partial class XacNhanThucHien : Form
    {

        public string value = "cancel";
        public XacNhanThucHien()
        {
            InitializeComponent();
        }

        public XacNhanThucHien(int id)
        {
            InitializeComponent();
            lbl_message.Text = $"Bạn đang chọn ID {id.ToString()}";

        }

        private void XacNhanThucHien_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            value = "delete";
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            value = "update";
            this.Hide();
        }
    }
}
