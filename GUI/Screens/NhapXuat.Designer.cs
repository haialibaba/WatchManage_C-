
namespace GUI.Screens
{
    partial class NhapXuat
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
            this.btn_pnhap = new System.Windows.Forms.Button();
            this.btn_pxuat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucXuat1 = new GUI.Screens.UCXuat();
            this.ucNhap1 = new GUI.Screens.UCNhap();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_pnhap
            // 
            this.btn_pnhap.Location = new System.Drawing.Point(392, 522);
            this.btn_pnhap.Name = "btn_pnhap";
            this.btn_pnhap.Size = new System.Drawing.Size(366, 48);
            this.btn_pnhap.TabIndex = 3;
            this.btn_pnhap.Text = "Phiếu Nhập";
            this.btn_pnhap.UseVisualStyleBackColor = true;
            this.btn_pnhap.Click += new System.EventHandler(this.btn_pnhap_Click);
            // 
            // btn_pxuat
            // 
            this.btn_pxuat.Location = new System.Drawing.Point(3, 522);
            this.btn_pxuat.Name = "btn_pxuat";
            this.btn_pxuat.Size = new System.Drawing.Size(357, 48);
            this.btn_pxuat.TabIndex = 2;
            this.btn_pxuat.Text = "Phiếu Xuất";
            this.btn_pxuat.UseVisualStyleBackColor = true;
            this.btn_pxuat.Click += new System.EventHandler(this.btn_pxuat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucNhap1);
            this.panel1.Controls.Add(this.ucXuat1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 507);
            this.panel1.TabIndex = 4;
            // 
            // ucXuat1
            // 
            this.ucXuat1.Location = new System.Drawing.Point(0, -2);
            this.ucXuat1.Margin = new System.Windows.Forms.Padding(2);
            this.ucXuat1.Name = "ucXuat1";
            this.ucXuat1.Size = new System.Drawing.Size(761, 507);
            this.ucXuat1.TabIndex = 0;
            // 
            // ucNhap1
            // 
            this.ucNhap1.Location = new System.Drawing.Point(0, -2);
            this.ucNhap1.Margin = new System.Windows.Forms.Padding(2);
            this.ucNhap1.Name = "ucNhap1";
            this.ucNhap1.Size = new System.Drawing.Size(761, 507);
            this.ucNhap1.TabIndex = 1;
            // 
            // NhapXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_pnhap);
            this.Controls.Add(this.btn_pxuat);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NhapXuat";
            this.Size = new System.Drawing.Size(761, 581);
            this.Load += new System.EventHandler(this.NhapXuat_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_pnhap;
        private System.Windows.Forms.Button btn_pxuat;
        private System.Windows.Forms.Panel panel1;
        private UCXuat ucXuat1;
        private UCNhap ucNhap1;
    }
}
