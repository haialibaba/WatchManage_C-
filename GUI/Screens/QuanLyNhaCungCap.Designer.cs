
namespace GUI.Screens
{
    partial class QuanLyNhaCungCap
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
            this.nhaCungCap1 = new GUI.Screens.NhaCungCap();
            this.sanPhamNhaCungCap1 = new GUI.Screens.SanPhamNhaCungCap();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(527, 639);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(460, 62);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sản phẩm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 639);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(460, 62);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nhà cung cấp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sanPhamNhaCungCap1);
            this.panel1.Controls.Add(this.nhaCungCap1);
            this.panel1.Location = new System.Drawing.Point(31, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 626);
            this.panel1.TabIndex = 5;
            // 
            // nhaCungCap1
            // 
            this.nhaCungCap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhaCungCap1.Location = new System.Drawing.Point(0, 0);
            this.nhaCungCap1.Name = "nhaCungCap1";
            this.nhaCungCap1.Size = new System.Drawing.Size(956, 626);
            this.nhaCungCap1.TabIndex = 0;
            // 
            // sanPhamNhaCungCap1
            // 
            this.sanPhamNhaCungCap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sanPhamNhaCungCap1.Location = new System.Drawing.Point(0, 0);
            this.sanPhamNhaCungCap1.Name = "sanPhamNhaCungCap1";
            this.sanPhamNhaCungCap1.Size = new System.Drawing.Size(956, 626);
            this.sanPhamNhaCungCap1.TabIndex = 1;
            // 
            // QuanLyNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "QuanLyNhaCungCap";
            this.Size = new System.Drawing.Size(1015, 715);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private NhaCungCap nhaCungCap1;
        private SanPhamNhaCungCap sanPhamNhaCungCap1;
    }
}
