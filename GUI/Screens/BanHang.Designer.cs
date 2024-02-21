
namespace GUI.Screens
{
    partial class BanHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sanPhamBanHangcs1 = new GUI.Screens.SanPhamBanHangcs();
            this.gioHangBanHang1 = new GUI.Screens.GioHangBanHang();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(602, 791);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(488, 80);
            this.button2.TabIndex = 3;
            this.button2.Text = "Giỏ hàng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 791);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(484, 80);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sản phẩm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gioHangBanHang1);
            this.panel1.Controls.Add(this.sanPhamBanHangcs1);
            this.panel1.Location = new System.Drawing.Point(33, 69);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 705);
            this.panel1.TabIndex = 4;
            // 
            // sanPhamBanHangcs1
            // 
            this.sanPhamBanHangcs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sanPhamBanHangcs1.Location = new System.Drawing.Point(0, 0);
            this.sanPhamBanHangcs1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.sanPhamBanHangcs1.Name = "sanPhamBanHangcs1";
            this.sanPhamBanHangcs1.Size = new System.Drawing.Size(1080, 705);
            this.sanPhamBanHangcs1.TabIndex = 0;
            // 
            // gioHangBanHang1
            // 
            this.gioHangBanHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gioHangBanHang1.Location = new System.Drawing.Point(0, 0);
            this.gioHangBanHang1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gioHangBanHang1.Name = "gioHangBanHang1";
            this.gioHangBanHang1.Size = new System.Drawing.Size(1080, 705);
            this.gioHangBanHang1.TabIndex = 1;
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BanHang";
            this.Size = new System.Drawing.Size(1142, 894);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private SanPhamBanHangcs sanPhamBanHangcs1;
        private GioHangBanHang gioHangBanHang1;
    }
}
