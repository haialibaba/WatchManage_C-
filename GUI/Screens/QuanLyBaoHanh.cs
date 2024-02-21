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
    public partial class QuanLyBaoHanh : UserControl
    {
        public QuanLyBaoHanh()
        {
            InitializeComponent();
            baoHanhQLBH1.BringToFront();
        }

        private void chiTietBaoHanhQLBH1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baoHanhQLBH1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chiTietBaoHanhQLBH1.BringToFront();
        }
    }
}
