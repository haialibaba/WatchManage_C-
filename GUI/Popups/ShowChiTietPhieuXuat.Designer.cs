namespace GUI.Popups
{
    partial class ShowChiTietPhieuXuat
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
            this.dataGridView_ctpx = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_IdCustomer = new System.Windows.Forms.Label();
            this.lbl_NameCustomer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ctpx)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ctpx
            // 
            this.dataGridView_ctpx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ctpx.Location = new System.Drawing.Point(25, 74);
            this.dataGridView_ctpx.Name = "dataGridView_ctpx";
            this.dataGridView_ctpx.Size = new System.Drawing.Size(658, 282);
            this.dataGridView_ctpx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID_Customer:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name_Customer:";
            // 
            // lbl_IdCustomer
            // 
            this.lbl_IdCustomer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdCustomer.Location = new System.Drawing.Point(142, 30);
            this.lbl_IdCustomer.Name = "lbl_IdCustomer";
            this.lbl_IdCustomer.Size = new System.Drawing.Size(160, 23);
            this.lbl_IdCustomer.TabIndex = 1;
            this.lbl_IdCustomer.Text = "0339917822";
            // 
            // lbl_NameCustomer
            // 
            this.lbl_NameCustomer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NameCustomer.Location = new System.Drawing.Point(484, 30);
            this.lbl_NameCustomer.Name = "lbl_NameCustomer";
            this.lbl_NameCustomer.Size = new System.Drawing.Size(199, 23);
            this.lbl_NameCustomer.TabIndex = 1;
            this.lbl_NameCustomer.Text = "Đặng Công Định";
            // 
            // ShowChiTietPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 368);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_NameCustomer);
            this.Controls.Add(this.lbl_IdCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_ctpx);
            this.Name = "ShowChiTietPhieuXuat";
            this.Text = "ShowChiTietPhieu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ctpx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ctpx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_IdCustomer;
        private System.Windows.Forms.Label lbl_NameCustomer;
    }
}