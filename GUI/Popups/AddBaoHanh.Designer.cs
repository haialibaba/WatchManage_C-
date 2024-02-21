
namespace GUI.Popups
{
    partial class AddBaoHanh
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
            this.cbb_product = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.num_time = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_time)).BeginInit();
            this.SuspendLayout();
            // 
            // cbb_product
            // 
            this.cbb_product.DropDownHeight = 150;
            this.cbb_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_product.ForeColor = System.Drawing.Color.Black;
            this.cbb_product.FormattingEnabled = true;
            this.cbb_product.IntegralHeight = false;
            this.cbb_product.ItemHeight = 20;
            this.cbb_product.Location = new System.Drawing.Point(45, 87);
            this.cbb_product.Name = "cbb_product";
            this.cbb_product.Size = new System.Drawing.Size(404, 28);
            this.cbb_product.TabIndex = 26;
            this.cbb_product.Text = "Chọn sản phẩm";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(317, 200);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(133, 36);
            this.btn_add.TabIndex = 25;
            this.btn_add.Text = "Lưu";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(45, 200);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(133, 36);
            this.btn_close.TabIndex = 24;
            this.btn_close.Text = "Thoát";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(45, 17);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(405, 45);
            this.txt_id.TabIndex = 23;
            this.txt_id.Text = "ID";
            // 
            // num_time
            // 
            this.num_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_time.Location = new System.Drawing.Point(155, 135);
            this.num_time.Name = "num_time";
            this.num_time.Size = new System.Drawing.Size(294, 27);
            this.num_time.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Số ngày";
            // 
            // AddBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 250);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_time);
            this.Controls.Add(this.cbb_product);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.txt_id);
            this.Name = "AddBaoHanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm bảo hành";
            this.Load += new System.EventHandler(this.AddBaoHanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_time)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbb_product;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.NumericUpDown num_time;
        private System.Windows.Forms.Label label1;
    }
}