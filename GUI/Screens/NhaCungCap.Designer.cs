
namespace GUI.Screens
{
    partial class NhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhaCungCap));
            this.dgv_ncc = new System.Windows.Forms.DataGridView();
            this.btn_add_ncc = new System.Windows.Forms.Button();
            this.btn_search_ncc = new System.Windows.Forms.Button();
            this.txt_search_ncc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ncc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ncc
            // 
            this.dgv_ncc.AllowUserToDeleteRows = false;
            this.dgv_ncc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ncc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ncc.GridColor = System.Drawing.Color.White;
            this.dgv_ncc.Location = new System.Drawing.Point(0, 98);
            this.dgv_ncc.Name = "dgv_ncc";
            this.dgv_ncc.ReadOnly = true;
            this.dgv_ncc.RowHeadersWidth = 51;
            this.dgv_ncc.RowTemplate.Height = 24;
            this.dgv_ncc.Size = new System.Drawing.Size(956, 510);
            this.dgv_ncc.TabIndex = 8;
            this.dgv_ncc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ncc_CellClick);
            this.dgv_ncc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ncc_CellContentClick);
            // 
            // btn_add_ncc
            // 
            this.btn_add_ncc.Location = new System.Drawing.Point(796, 18);
            this.btn_add_ncc.Name = "btn_add_ncc";
            this.btn_add_ncc.Size = new System.Drawing.Size(160, 47);
            this.btn_add_ncc.TabIndex = 7;
            this.btn_add_ncc.Text = "Thêm";
            this.btn_add_ncc.UseVisualStyleBackColor = true;
            this.btn_add_ncc.Click += new System.EventHandler(this.btn_add_ncc_Click);
            // 
            // btn_search_ncc
            // 
            this.btn_search_ncc.Image = ((System.Drawing.Image)(resources.GetObject("btn_search_ncc.Image")));
            this.btn_search_ncc.Location = new System.Drawing.Point(371, 18);
            this.btn_search_ncc.Name = "btn_search_ncc";
            this.btn_search_ncc.Size = new System.Drawing.Size(60, 47);
            this.btn_search_ncc.TabIndex = 6;
            this.btn_search_ncc.UseVisualStyleBackColor = true;
            this.btn_search_ncc.Click += new System.EventHandler(this.btn_search_ncc_Click);
            // 
            // txt_search_ncc
            // 
            this.txt_search_ncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_ncc.ForeColor = System.Drawing.Color.Gray;
            this.txt_search_ncc.Location = new System.Drawing.Point(0, 18);
            this.txt_search_ncc.Multiline = true;
            this.txt_search_ncc.Name = "txt_search_ncc";
            this.txt_search_ncc.Size = new System.Drawing.Size(365, 47);
            this.txt_search_ncc.TabIndex = 5;
            this.txt_search_ncc.Text = "Tìm kiếm theo ID, tên, sdt...";
            this.txt_search_ncc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_ncc_KeyDown);
            // 
            // NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_ncc);
            this.Controls.Add(this.btn_add_ncc);
            this.Controls.Add(this.btn_search_ncc);
            this.Controls.Add(this.txt_search_ncc);
            this.Name = "NhaCungCap";
            this.Size = new System.Drawing.Size(956, 626);
            this.Load += new System.EventHandler(this.NhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ncc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_ncc;
        private System.Windows.Forms.Button btn_add_ncc;
        private System.Windows.Forms.Button btn_search_ncc;
        private System.Windows.Forms.TextBox txt_search_ncc;
    }
}
