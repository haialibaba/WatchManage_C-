
namespace GUI.Popups
{
    partial class AddSanPhamNhaCungCap
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.cbb_producer = new System.Windows.Forms.ComboBox();
            this.cbb_category = new System.Windows.Forms.ComboBox();
            this.txt_prices = new System.Windows.Forms.TextBox();
            this.txt_origin = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(546, 319);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(122, 46);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "Lưu";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(25, 319);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(122, 46);
            this.btn_close.TabIndex = 17;
            this.btn_close.Text = "Thoát";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // cbb_producer
            // 
            this.cbb_producer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_producer.FormattingEnabled = true;
            this.cbb_producer.Location = new System.Drawing.Point(291, 262);
            this.cbb_producer.Name = "cbb_producer";
            this.cbb_producer.Size = new System.Drawing.Size(377, 28);
            this.cbb_producer.TabIndex = 16;
            this.cbb_producer.Tag = "";
            this.cbb_producer.Text = "Chọn nhà cung cấp";
            // 
            // cbb_category
            // 
            this.cbb_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_category.FormattingEnabled = true;
            this.cbb_category.Location = new System.Drawing.Point(25, 262);
            this.cbb_category.Name = "cbb_category";
            this.cbb_category.Size = new System.Drawing.Size(242, 28);
            this.cbb_category.TabIndex = 15;
            this.cbb_category.Text = "Chọn loại";
            // 
            // txt_prices
            // 
            this.txt_prices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prices.ForeColor = System.Drawing.Color.Gray;
            this.txt_prices.Location = new System.Drawing.Point(291, 130);
            this.txt_prices.Multiline = true;
            this.txt_prices.Name = "txt_prices";
            this.txt_prices.Size = new System.Drawing.Size(377, 47);
            this.txt_prices.TabIndex = 14;
            this.txt_prices.Text = "Nhập giá";
            // 
            // txt_origin
            // 
            this.txt_origin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_origin.ForeColor = System.Drawing.Color.Gray;
            this.txt_origin.Location = new System.Drawing.Point(291, 183);
            this.txt_origin.Multiline = true;
            this.txt_origin.Name = "txt_origin";
            this.txt_origin.Size = new System.Drawing.Size(377, 47);
            this.txt_origin.TabIndex = 13;
            this.txt_origin.Text = "Nhập xuất xứ";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.Gray;
            this.txt_name.Location = new System.Drawing.Point(291, 77);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(377, 47);
            this.txt_name.TabIndex = 12;
            this.txt_name.Text = "Nhập tên sản phẩm";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(291, 24);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(377, 47);
            this.txt_id.TabIndex = 11;
            this.txt_id.Text = "ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(24, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AddSanPhamNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 388);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.cbb_producer);
            this.Controls.Add(this.cbb_category);
            this.Controls.Add(this.txt_prices);
            this.Controls.Add(this.txt_origin);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(711, 435);
            this.MinimumSize = new System.Drawing.Size(711, 435);
            this.Name = "AddSanPhamNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm sản phẩm nhà cung cấp";
            this.Load += new System.EventHandler(this.AddSanPhamNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ComboBox cbb_producer;
        private System.Windows.Forms.ComboBox cbb_category;
        private System.Windows.Forms.TextBox txt_prices;
        private System.Windows.Forms.TextBox txt_origin;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}