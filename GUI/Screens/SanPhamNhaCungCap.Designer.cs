
namespace GUI.Screens
{
    partial class SanPhamNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPhamNhaCungCap));
            this.dgv_spncc = new System.Windows.Forms.DataGridView();
            this.btn_add_spncc = new System.Windows.Forms.Button();
            this.btn_search_spncc = new System.Windows.Forms.Button();
            this.txt_search_spncc = new System.Windows.Forms.TextBox();
            this.cbb_category = new System.Windows.Forms.ComboBox();
            this.cbb_producer = new System.Windows.Forms.ComboBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_import = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_spncc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_spncc
            // 
            this.dgv_spncc.AllowUserToDeleteRows = false;
            this.dgv_spncc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_spncc.GridColor = System.Drawing.Color.White;
            this.dgv_spncc.Location = new System.Drawing.Point(0, 98);
            this.dgv_spncc.Name = "dgv_spncc";
            this.dgv_spncc.ReadOnly = true;
            this.dgv_spncc.RowHeadersWidth = 51;
            this.dgv_spncc.RowTemplate.Height = 24;
            this.dgv_spncc.Size = new System.Drawing.Size(956, 510);
            this.dgv_spncc.TabIndex = 11;
            this.dgv_spncc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_spncc_CellClick);
            this.dgv_spncc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_spncc_CellContentClick);
            // 
            // btn_add_spncc
            // 
            this.btn_add_spncc.Location = new System.Drawing.Point(798, 18);
            this.btn_add_spncc.Name = "btn_add_spncc";
            this.btn_add_spncc.Size = new System.Drawing.Size(160, 47);
            this.btn_add_spncc.TabIndex = 10;
            this.btn_add_spncc.Text = "Thêm";
            this.btn_add_spncc.UseVisualStyleBackColor = true;
            this.btn_add_spncc.Click += new System.EventHandler(this.btn_add_spncc_Click);
            // 
            // btn_search_spncc
            // 
            this.btn_search_spncc.Image = ((System.Drawing.Image)(resources.GetObject("btn_search_spncc.Image")));
            this.btn_search_spncc.Location = new System.Drawing.Point(272, 18);
            this.btn_search_spncc.Name = "btn_search_spncc";
            this.btn_search_spncc.Size = new System.Drawing.Size(51, 47);
            this.btn_search_spncc.TabIndex = 9;
            this.btn_search_spncc.UseVisualStyleBackColor = true;
            this.btn_search_spncc.Click += new System.EventHandler(this.btn_search_spncc_Click);
            // 
            // txt_search_spncc
            // 
            this.txt_search_spncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_spncc.ForeColor = System.Drawing.Color.Gray;
            this.txt_search_spncc.Location = new System.Drawing.Point(2, 18);
            this.txt_search_spncc.Multiline = true;
            this.txt_search_spncc.Name = "txt_search_spncc";
            this.txt_search_spncc.Size = new System.Drawing.Size(245, 30);
            this.txt_search_spncc.TabIndex = 8;
            this.txt_search_spncc.Text = "Tìm kiếm theo ID, tên";
            this.txt_search_spncc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_spncc_KeyDown);
            // 
            // cbb_category
            // 
            this.cbb_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_category.FormattingEnabled = true;
            this.cbb_category.Location = new System.Drawing.Point(3, 54);
            this.cbb_category.Name = "cbb_category";
            this.cbb_category.Size = new System.Drawing.Size(96, 28);
            this.cbb_category.TabIndex = 12;
            this.cbb_category.Text = "Chọn loại";
            // 
            // cbb_producer
            // 
            this.cbb_producer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_producer.FormattingEnabled = true;
            this.cbb_producer.Location = new System.Drawing.Point(105, 54);
            this.cbb_producer.Name = "cbb_producer";
            this.cbb_producer.Size = new System.Drawing.Size(142, 28);
            this.cbb_producer.TabIndex = 13;
            this.cbb_producer.Text = "Chọn nhà cung cấp";
            this.cbb_producer.SelectedIndexChanged += new System.EventHandler(this.cbb_producer_SelectedIndexChanged);
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(421, 18);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(160, 47);
            this.btn_export.TabIndex = 14;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(602, 18);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(160, 47);
            this.btn_import.TabIndex = 15;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // SanPhamNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.cbb_producer);
            this.Controls.Add(this.cbb_category);
            this.Controls.Add(this.dgv_spncc);
            this.Controls.Add(this.btn_add_spncc);
            this.Controls.Add(this.btn_search_spncc);
            this.Controls.Add(this.txt_search_spncc);
            this.Name = "SanPhamNhaCungCap";
            this.Size = new System.Drawing.Size(956, 626);
            this.Load += new System.EventHandler(this.SanPhamNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_spncc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_spncc;
        private System.Windows.Forms.Button btn_add_spncc;
        private System.Windows.Forms.Button btn_search_spncc;
        private System.Windows.Forms.TextBox txt_search_spncc;
        private System.Windows.Forms.ComboBox cbb_category;
        private System.Windows.Forms.ComboBox cbb_producer;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_import;
    }
}
