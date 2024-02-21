
namespace GUI.Popups
{
    partial class HoaDonBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_day = new System.Windows.Forms.TextBox();
            this.txt_idhd = new System.Windows.Forms.TextBox();
            this.txt_phonekh = new System.Windows.Forms.TextBox();
            this.txt_idnv = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_idhd = new System.Windows.Forms.Label();
            this.lbl_phonekh = new System.Windows.Forms.Label();
            this.lbl_idnv = new System.Windows.Forms.Label();
            this.dgv_hoadon = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 77);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "HÓA ĐƠN";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgv_hoadon);
            this.panel2.Controls.Add(this.txt_day);
            this.panel2.Controls.Add(this.txt_idhd);
            this.panel2.Controls.Add(this.txt_phonekh);
            this.panel2.Controls.Add(this.txt_idnv);
            this.panel2.Controls.Add(this.lbl_total);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lbl_time);
            this.panel2.Controls.Add(this.lbl_idhd);
            this.panel2.Controls.Add(this.lbl_phonekh);
            this.panel2.Controls.Add(this.lbl_idnv);
            this.panel2.Location = new System.Drawing.Point(1, 82);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 278);
            this.panel2.TabIndex = 3;
            // 
            // txt_day
            // 
            this.txt_day.Location = new System.Drawing.Point(494, 42);
            this.txt_day.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_day.Name = "txt_day";
            this.txt_day.Size = new System.Drawing.Size(205, 22);
            this.txt_day.TabIndex = 12;
            this.txt_day.TextChanged += new System.EventHandler(this.txt_day_TextChanged);
            // 
            // txt_idhd
            // 
            this.txt_idhd.Location = new System.Drawing.Point(379, 42);
            this.txt_idhd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_idhd.Name = "txt_idhd";
            this.txt_idhd.Size = new System.Drawing.Size(75, 22);
            this.txt_idhd.TabIndex = 11;
            // 
            // txt_phonekh
            // 
            this.txt_phonekh.Location = new System.Drawing.Point(151, 42);
            this.txt_phonekh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_phonekh.Name = "txt_phonekh";
            this.txt_phonekh.Size = new System.Drawing.Size(165, 22);
            this.txt_phonekh.TabIndex = 10;
            // 
            // txt_idnv
            // 
            this.txt_idnv.Location = new System.Drawing.Point(23, 42);
            this.txt_idnv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_idnv.Name = "txt_idnv";
            this.txt_idnv.Size = new System.Drawing.Size(89, 22);
            this.txt_idnv.TabIndex = 9;
            // 
            // lbl_total
            // 
            this.lbl_total.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(602, 229);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(90, 26);
            this.lbl_total.TabIndex = 8;
            this.lbl_total.Text = "300$";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(522, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 41);
            this.label10.TabIndex = 7;
            this.label10.Text = "TOTAL:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(289, 228);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "In Hóa Đơn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 228);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(491, 10);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(62, 16);
            this.lbl_time.TabIndex = 3;
            this.lbl_time.Text = "Ngày tạo";
            // 
            // lbl_idhd
            // 
            this.lbl_idhd.AutoSize = true;
            this.lbl_idhd.Location = new System.Drawing.Point(375, 10);
            this.lbl_idhd.Name = "lbl_idhd";
            this.lbl_idhd.Size = new System.Drawing.Size(72, 16);
            this.lbl_idhd.TabIndex = 2;
            this.lbl_idhd.Text = "ID hóa đơn";
            // 
            // lbl_phonekh
            // 
            this.lbl_phonekh.AutoSize = true;
            this.lbl_phonekh.Location = new System.Drawing.Point(148, 10);
            this.lbl_phonekh.Name = "lbl_phonekh";
            this.lbl_phonekh.Size = new System.Drawing.Size(157, 16);
            this.lbl_phonekh.TabIndex = 1;
            this.lbl_phonekh.Text = "Số điện thoại khách hàng";
            // 
            // lbl_idnv
            // 
            this.lbl_idnv.AutoSize = true;
            this.lbl_idnv.Location = new System.Drawing.Point(20, 10);
            this.lbl_idnv.Name = "lbl_idnv";
            this.lbl_idnv.Size = new System.Drawing.Size(83, 16);
            this.lbl_idnv.TabIndex = 0;
            this.lbl_idnv.Text = "ID Nhân viên";
            this.lbl_idnv.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgv_hoadon
            // 
            this.dgv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoadon.Location = new System.Drawing.Point(21, 82);
            this.dgv_hoadon.Name = "dgv_hoadon";
            this.dgv_hoadon.RowHeadersWidth = 51;
            this.dgv_hoadon.RowTemplate.Height = 24;
            this.dgv_hoadon.Size = new System.Drawing.Size(678, 125);
            this.dgv_hoadon.TabIndex = 13;
            // 
            // HoaDonBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "HoaDonBanHang";
            this.Text = "HoaDonBanHang";
            this.Load += new System.EventHandler(this.HoaDonBanHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_idhd;
        private System.Windows.Forms.Label lbl_phonekh;
        private System.Windows.Forms.Label lbl_idnv;
        private System.Windows.Forms.TextBox txt_day;
        private System.Windows.Forms.TextBox txt_idhd;
        private System.Windows.Forms.TextBox txt_phonekh;
        private System.Windows.Forms.TextBox txt_idnv;
        private System.Windows.Forms.DataGridView dgv_hoadon;
    }
}