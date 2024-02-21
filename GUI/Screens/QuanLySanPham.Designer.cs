
namespace GUI.Screens
{
    partial class QuanLySanPham
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sanPhamQLSP1 = new GUI.Screens.SanPhamQLSP();
            this.nhapHangQLSP1 = new GUI.Screens.NhapHangQLSP();
            this.gioHangQLSP1 = new GUI.Screens.GioHangQLSP();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(699, 640);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(273, 64);
            this.button3.TabIndex = 6;
            this.button3.Text = "Giỏ hàng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(359, 640);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(292, 64);
            this.button2.TabIndex = 5;
            this.button2.Text = "Nhập Hàng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 640);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sản phẩm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gioHangQLSP1);
            this.panel1.Controls.Add(this.nhapHangQLSP1);
            this.panel1.Controls.Add(this.sanPhamQLSP1);
            this.panel1.Location = new System.Drawing.Point(25, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 564);
            this.panel1.TabIndex = 7;
            // 
            // sanPhamQLSP1
            // 
            this.sanPhamQLSP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sanPhamQLSP1.Location = new System.Drawing.Point(0, 0);
            this.sanPhamQLSP1.Name = "sanPhamQLSP1";
            this.sanPhamQLSP1.Size = new System.Drawing.Size(960, 564);
            this.sanPhamQLSP1.TabIndex = 0;
            // 
            // nhapHangQLSP1
            // 
            this.nhapHangQLSP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhapHangQLSP1.Location = new System.Drawing.Point(0, 0);
            this.nhapHangQLSP1.Name = "nhapHangQLSP1";
            this.nhapHangQLSP1.Size = new System.Drawing.Size(960, 564);
            this.nhapHangQLSP1.TabIndex = 1;
            // 
            // gioHangQLSP1
            // 
            this.gioHangQLSP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gioHangQLSP1.Location = new System.Drawing.Point(0, 0);
            this.gioHangQLSP1.Name = "gioHangQLSP1";
            this.gioHangQLSP1.Size = new System.Drawing.Size(960, 564);
            this.gioHangQLSP1.TabIndex = 2;
            // 
            // QuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "QuanLySanPham";
            this.Size = new System.Drawing.Size(1015, 715);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private SanPhamQLSP sanPhamQLSP1;
        private GioHangQLSP gioHangQLSP1;
        private NhapHangQLSP nhapHangQLSP1;
    }
}
