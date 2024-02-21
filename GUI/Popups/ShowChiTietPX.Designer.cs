namespace GUI.Popups
{
    partial class ShowChiTietPX
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
            this.lbl_tenNV = new System.Windows.Forms.Label();
            this.lbl_tenKH = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_maHD = new System.Windows.Forms.Label();
            this.dataGridView_px = new System.Windows.Forms.DataGridView();
            this.btn_export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_px)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tenNV
            // 
            this.lbl_tenNV.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbl_tenNV.Location = new System.Drawing.Point(184, 92);
            this.lbl_tenNV.Name = "lbl_tenNV";
            this.lbl_tenNV.Size = new System.Drawing.Size(100, 23);
            this.lbl_tenNV.TabIndex = 0;
            this.lbl_tenNV.Text = ".....";
            // 
            // lbl_tenKH
            // 
            this.lbl_tenKH.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbl_tenKH.Location = new System.Drawing.Point(618, 92);
            this.lbl_tenKH.Name = "lbl_tenKH";
            this.lbl_tenKH.Size = new System.Drawing.Size(162, 23);
            this.lbl_tenKH.TabIndex = 0;
            this.lbl_tenKH.Text = ".......";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label3.Location = new System.Drawing.Point(454, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Khách Hàng:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label4.Location = new System.Drawing.Point(45, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên Nhân Viên:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label5.Location = new System.Drawing.Point(269, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Hóa Đơn:";
            // 
            // lbl_maHD
            // 
            this.lbl_maHD.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbl_maHD.Location = new System.Drawing.Point(405, 35);
            this.lbl_maHD.Name = "lbl_maHD";
            this.lbl_maHD.Size = new System.Drawing.Size(135, 24);
            this.lbl_maHD.TabIndex = 0;
            this.lbl_maHD.Text = "......";
            // 
            // dataGridView_px
            // 
            this.dataGridView_px.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_px.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_px.Location = new System.Drawing.Point(49, 137);
            this.dataGridView_px.Name = "dataGridView_px";
            this.dataGridView_px.Size = new System.Drawing.Size(731, 271);
            this.dataGridView_px.TabIndex = 1;
            this.dataGridView_px.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_px_CellContentClick);
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(674, 419);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(106, 28);
            this.btn_export.TabIndex = 2;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // ShowChiTietPX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 459);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.dataGridView_px);
            this.Controls.Add(this.lbl_maHD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_tenKH);
            this.Controls.Add(this.lbl_tenNV);
            this.MaximizeBox = false;
            this.Name = "ShowChiTietPX";
            this.Text = "ShowChiTietPhieuXuat";
            this.Load += new System.EventHandler(this.ShowChiTietPX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_px)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_tenNV;
        private System.Windows.Forms.Label lbl_tenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_maHD;
        private System.Windows.Forms.DataGridView dataGridView_px;
        private System.Windows.Forms.Button btn_export;
    }
}