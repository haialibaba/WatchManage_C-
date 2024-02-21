
namespace GUI.Screens
{
    partial class QuanLyBaoHanh
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
            this.chiTietBaoHanhQLBH1 = new GUI.Screens.ChiTietBaoHanhQLBH();
            this.baoHanhQLBH1 = new GUI.Screens.BaoHanhQLBH();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(526, 635);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(460, 62);
            this.button2.TabIndex = 6;
            this.button2.Text = "Chi tiết bảo hành";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 635);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(460, 62);
            this.button1.TabIndex = 5;
            this.button1.Text = "Bảo hành";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chiTietBaoHanhQLBH1);
            this.panel1.Controls.Add(this.baoHanhQLBH1);
            this.panel1.Location = new System.Drawing.Point(30, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 626);
            this.panel1.TabIndex = 7;
            // 
            // chiTietBaoHanhQLBH1
            // 
            this.chiTietBaoHanhQLBH1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chiTietBaoHanhQLBH1.Location = new System.Drawing.Point(0, 0);
            this.chiTietBaoHanhQLBH1.Name = "chiTietBaoHanhQLBH1";
            this.chiTietBaoHanhQLBH1.Size = new System.Drawing.Size(956, 626);
            this.chiTietBaoHanhQLBH1.TabIndex = 1;
            this.chiTietBaoHanhQLBH1.Load += new System.EventHandler(this.chiTietBaoHanhQLBH1_Load);
            // 
            // baoHanhQLBH1
            // 
            this.baoHanhQLBH1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baoHanhQLBH1.Location = new System.Drawing.Point(0, 0);
            this.baoHanhQLBH1.Name = "baoHanhQLBH1";
            this.baoHanhQLBH1.Size = new System.Drawing.Size(956, 626);
            this.baoHanhQLBH1.TabIndex = 0;
            // 
            // QuanLyBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "QuanLyBaoHanh";
            this.Size = new System.Drawing.Size(1015, 715);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private BaoHanhQLBH baoHanhQLBH1;
        private ChiTietBaoHanhQLBH chiTietBaoHanhQLBH1;
    }
}
