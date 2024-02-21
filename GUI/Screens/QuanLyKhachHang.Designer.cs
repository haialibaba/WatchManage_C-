
namespace GUI.Screens
{
    partial class QuanLyKhachHang
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
            this.txtFind_KH = new System.Windows.Forms.TextBox();
            this.dataGridView_KH = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReload_KH = new System.Windows.Forms.PictureBox();
            this.btnSearch_KH = new System.Windows.Forms.PictureBox();
            this.btnAdd_KH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload_KH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch_KH)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFind_KH
            // 
            this.txtFind_KH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind_KH.Location = new System.Drawing.Point(18, 42);
            this.txtFind_KH.Name = "txtFind_KH";
            this.txtFind_KH.Size = new System.Drawing.Size(245, 21);
            this.txtFind_KH.TabIndex = 8;

            // 
            // dataGridView_KH
            // 
            this.dataGridView_KH.AllowUserToAddRows = false;
            this.dataGridView_KH.AllowUserToResizeColumns = false;
            this.dataGridView_KH.AllowUserToResizeRows = false;
            this.dataGridView_KH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_KH.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_KH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_KH.GridColor = System.Drawing.Color.White;
            this.dataGridView_KH.Location = new System.Drawing.Point(18, 99);
            this.dataGridView_KH.MultiSelect = false;
            this.dataGridView_KH.Name = "dataGridView_KH";
            this.dataGridView_KH.RowHeadersVisible = false;
            this.dataGridView_KH.RowHeadersWidth = 51;
            this.dataGridView_KH.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_KH.ShowEditingIcon = false;
            this.dataGridView_KH.Size = new System.Drawing.Size(725, 447);
            this.dataGridView_KH.TabIndex = 10;
            this.dataGridView_KH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_KH_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 11;
            // 
            // btnReload_KH
            // 
            this.btnReload_KH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.btnReload_KH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReload_KH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnReload_KH.Image = global::GUI.Properties.Resources.icons8_refresh_30;
            this.btnReload_KH.Location = new System.Drawing.Point(303, 42);
            this.btnReload_KH.Name = "btnReload_KH";
            this.btnReload_KH.Size = new System.Drawing.Size(29, 21);
            this.btnReload_KH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReload_KH.TabIndex = 13;
            this.btnReload_KH.TabStop = false;
            this.btnReload_KH.Click += new System.EventHandler(this.btnReload_KH_Click);
            // 
            // btnSearch_KH
            // 
            this.btnSearch_KH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.btnSearch_KH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch_KH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSearch_KH.Image = global::GUI.Properties.Resources.icons8_search_30;
            this.btnSearch_KH.Location = new System.Drawing.Point(262, 42);
            this.btnSearch_KH.Name = "btnSearch_KH";
            this.btnSearch_KH.Size = new System.Drawing.Size(29, 21);
            this.btnSearch_KH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearch_KH.TabIndex = 12;
            this.btnSearch_KH.TabStop = false;
            this.btnSearch_KH.Click += new System.EventHandler(this.btnSearch_KH_Click);
            // 
            // btnAdd_KH
            // 
            this.btnAdd_KH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.btnAdd_KH.FlatAppearance.BorderSize = 0;
            this.btnAdd_KH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_KH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_KH.ForeColor = System.Drawing.Color.White;
            this.btnAdd_KH.Image = global::GUI.Properties.Resources.icons8_add_30;
            this.btnAdd_KH.Location = new System.Drawing.Point(657, 35);
            this.btnAdd_KH.Name = "btnAdd_KH";
            this.btnAdd_KH.Size = new System.Drawing.Size(86, 34);
            this.btnAdd_KH.TabIndex = 9;
            this.btnAdd_KH.UseVisualStyleBackColor = false;
            this.btnAdd_KH.Click += new System.EventHandler(this.btnAdd_KH_Click);
            // 
            // QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReload_KH);
            this.Controls.Add(this.txtFind_KH);
            this.Controls.Add(this.btnSearch_KH);
            this.Controls.Add(this.btnAdd_KH);
            this.Controls.Add(this.dataGridView_KH);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanLyKhachHang";
            this.Size = new System.Drawing.Size(761, 581);
            this.Load += new System.EventHandler(this.QuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload_KH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch_KH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFind_KH;
        private System.Windows.Forms.PictureBox btnSearch_KH;
        private System.Windows.Forms.Button btnAdd_KH;
        private System.Windows.Forms.DataGridView dataGridView_KH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnReload_KH;
    }
}
