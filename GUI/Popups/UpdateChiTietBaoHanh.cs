using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI.Popups
{
    public partial class UpdateChiTietBaoHanh : Form
    {
        public bool flag = false;
        public ChiTietBaoHanhDTO detail = new ChiTietBaoHanhDTO();
        public UpdateChiTietBaoHanh()
        {
            InitializeComponent();
        }

        public UpdateChiTietBaoHanh(ChiTietBaoHanhDTO detail)
        {
            InitializeComponent();
            this.detail = detail;
        }

        

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UpdateChiTietBaoHanh_Load(object sender, EventArgs e)
        {
            txt_id.Text = detail.Id.ToString();
            txt_phone.Text = detail.CustomerId;
            txt_detail.Text = detail.DetailProductId.ToString();
            cbb_status.DisplayMember = "Text";
            cbb_status.ValueMember = "Value";
            var items = new[] {
            new { Text = "Đã bảo hành", Value = 1 },
            new { Text = "Chưa bảo hành", Value = 0 },

            };


            cbb_status.DataSource = items;

            cbb_status.SelectedItem = detail.Status == 1 ? new { Text = "Đã bảo hành", Value = 1 } : new { Text = "Chưa bảo hành", Value = 0 };
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            ChiTietBaoHanhDTO newDetail = new ChiTietBaoHanhDTO();
            newDetail.Id = detail.Id;
            newDetail.DetailProductId = detail.DetailProductId;
            newDetail.CustomerId = detail.CustomerId;
            newDetail.Status = (cbb_status.SelectedItem as dynamic).Value;
            newDetail.OutOfDate = detail.OutOfDate;
            flag = ChiTietBaoHanhBLL.UpdateData(newDetail);
            if(flag == true)
            {
                detail = newDetail;
                this.Hide();
            }
        }
    }
}
