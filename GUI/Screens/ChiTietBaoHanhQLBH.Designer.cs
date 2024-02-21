
namespace GUI.Screens
{
    partial class ChiTietBaoHanhQLBH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietBaoHanhQLBH));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ncc = new System.Windows.Forms.DataGridView();
            this.btn_search_ncc = new System.Windows.Forms.Button();
            this.txt_search_ncc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ncc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Chi tiết bảo hành";
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
            this.dgv_ncc.TabIndex = 18;
            this.dgv_ncc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ncc_CellClick);
            // 
            // btn_search_ncc
            // 
            this.btn_search_ncc.Image = ((System.Drawing.Image)(resources.GetObject("btn_search_ncc.Image")));
            this.btn_search_ncc.Location = new System.Drawing.Point(251, 18);
            this.btn_search_ncc.Name = "btn_search_ncc";
            this.btn_search_ncc.Size = new System.Drawing.Size(60, 47);
            this.btn_search_ncc.TabIndex = 16;
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
            this.txt_search_ncc.Size = new System.Drawing.Size(245, 47);
            this.txt_search_ncc.TabIndex = 15;
            this.txt_search_ncc.Text = "Tìm theo số điện thoại";
            this.txt_search_ncc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_ncc_KeyDown);
            // 
            // ChiTietBaoHanhQLBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_ncc);
            this.Controls.Add(this.btn_search_ncc);
            this.Controls.Add(this.txt_search_ncc);
            this.Name = "ChiTietBaoHanhQLBH";
            this.Size = new System.Drawing.Size(956, 626);
            this.Load += new System.EventHandler(this.ChiTietBaoHanhQLBH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ncc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_ncc;
        private System.Windows.Forms.Button btn_search_ncc;
        private System.Windows.Forms.TextBox txt_search_ncc;
    }
}
