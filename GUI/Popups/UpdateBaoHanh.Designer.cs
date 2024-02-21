
namespace GUI.Popups
{
    partial class UpdateBaoHanh
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
            this.label1 = new System.Windows.Forms.Label();
            this.num_time = new System.Windows.Forms.NumericUpDown();
            this.cbb_product = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_time)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Số ngày";
            // 
            // num_time
            // 
            this.num_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_time.Location = new System.Drawing.Point(156, 147);
            this.num_time.Name = "num_time";
            this.num_time.Size = new System.Drawing.Size(294, 27);
            this.num_time.TabIndex = 33;
            // 
            // cbb_product
            // 
            this.cbb_product.DropDownHeight = 150;
            this.cbb_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_product.ForeColor = System.Drawing.Color.Black;
            this.cbb_product.FormattingEnabled = true;
            this.cbb_product.IntegralHeight = false;
            this.cbb_product.ItemHeight = 20;
            this.cbb_product.Location = new System.Drawing.Point(46, 99);
            this.cbb_product.Name = "cbb_product";
            this.cbb_product.Size = new System.Drawing.Size(404, 28);
            this.cbb_product.TabIndex = 32;
            this.cbb_product.Text = "Chọn sản phẩm";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(318, 212);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(133, 36);
            this.btn_add.TabIndex = 31;
            this.btn_add.Text = "Lưu";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(46, 212);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(133, 36);
            this.btn_close.TabIndex = 30;
            this.btn_close.Text = "Thoát";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(46, 29);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(405, 45);
            this.txt_id.TabIndex = 29;
            this.txt_id.Text = "ID";
            // 
            // UpdateBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 276);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_time);
            this.Controls.Add(this.cbb_product);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.txt_id);
            this.Name = "UpdateBaoHanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateBaoHanh";
            this.Load += new System.EventHandler(this.UpdateBaoHanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_time)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_time;
        private System.Windows.Forms.ComboBox cbb_product;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txt_id;
    }
}