namespace GUI.Popups
{
    partial class ShowChiTietPN
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
            this.dataGridView_pn = new System.Windows.Forms.DataGridView();
            this.lbl_maHD = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_tenNCC = new System.Windows.Forms.Label();
            this.lbl_tenNV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pn)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_pn
            // 
            this.dataGridView_pn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_pn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pn.Location = new System.Drawing.Point(37, 146);
            this.dataGridView_pn.Name = "dataGridView_pn";
            this.dataGridView_pn.Size = new System.Drawing.Size(731, 271);
            this.dataGridView_pn.TabIndex = 8;
            this.dataGridView_pn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_pn_CellContentClick);
            // 
            // lbl_maHD
            // 
            this.lbl_maHD.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbl_maHD.Location = new System.Drawing.Point(393, 39);
            this.lbl_maHD.Name = "lbl_maHD";
            this.lbl_maHD.Size = new System.Drawing.Size(135, 24);
            this.lbl_maHD.TabIndex = 2;
            this.lbl_maHD.Text = "......";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label5.Location = new System.Drawing.Point(257, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã Hóa Đơn:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label4.Location = new System.Drawing.Point(33, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên Nhân Viên:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label3.Location = new System.Drawing.Point(484, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên NCC:";
            // 
            // lbl_tenNCC
            // 
            this.lbl_tenNCC.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbl_tenNCC.Location = new System.Drawing.Point(581, 96);
            this.lbl_tenNCC.Name = "lbl_tenNCC";
            this.lbl_tenNCC.Size = new System.Drawing.Size(187, 23);
            this.lbl_tenNCC.TabIndex = 6;
            this.lbl_tenNCC.Text = ".......";
            // 
            // lbl_tenNV
            // 
            this.lbl_tenNV.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbl_tenNV.Location = new System.Drawing.Point(172, 96);
            this.lbl_tenNV.Name = "lbl_tenNV";
            this.lbl_tenNV.Size = new System.Drawing.Size(100, 23);
            this.lbl_tenNV.TabIndex = 7;
            this.lbl_tenNV.Text = ".....";
            // 
            // ShowChiTietPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_pn);
            this.Controls.Add(this.lbl_maHD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_tenNCC);
            this.Controls.Add(this.lbl_tenNV);
            this.Name = "ShowChiTietPN";
            this.Text = "ShowChiTietPN";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_pn;
        private System.Windows.Forms.Label lbl_maHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_tenNCC;
        private System.Windows.Forms.Label lbl_tenNV;
    }
}