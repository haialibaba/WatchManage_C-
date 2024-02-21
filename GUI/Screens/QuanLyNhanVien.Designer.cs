
namespace GUI.Screens
{
    partial class QuanLyNhanVien
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
            this.dataGridView_NV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFind_NV = new System.Windows.Forms.TextBox();
            this.btnAdd_NV = new System.Windows.Forms.Button();
            this.btnSearch_NV = new System.Windows.Forms.PictureBox();
            this.btnReload_NV = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch_NV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload_NV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_NV
            // 
            this.dataGridView_NV.AllowUserToAddRows = false;
            this.dataGridView_NV.AllowUserToResizeColumns = false;
            this.dataGridView_NV.AllowUserToResizeRows = false;
            this.dataGridView_NV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_NV.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_NV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NV.GridColor = System.Drawing.Color.White;
            this.dataGridView_NV.Location = new System.Drawing.Point(18, 99);
            this.dataGridView_NV.MultiSelect = false;
            this.dataGridView_NV.Name = "dataGridView_NV";
            this.dataGridView_NV.RowHeadersVisible = false;
            this.dataGridView_NV.RowHeadersWidth = 51;
            this.dataGridView_NV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_NV.ShowEditingIcon = false;
            this.dataGridView_NV.Size = new System.Drawing.Size(725, 447);
            this.dataGridView_NV.TabIndex = 3;
            this.dataGridView_NV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_NV_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 258);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 4;
            // 
            // txtFind_NV
            // 
            this.txtFind_NV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind_NV.Location = new System.Drawing.Point(18, 42);
            this.txtFind_NV.Name = "txtFind_NV";
            this.txtFind_NV.Size = new System.Drawing.Size(245, 21);
            this.txtFind_NV.TabIndex = 5;

            // 
            // btnAdd_NV
            // 
            this.btnAdd_NV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.btnAdd_NV.FlatAppearance.BorderSize = 0;
            this.btnAdd_NV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_NV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_NV.ForeColor = System.Drawing.Color.White;
            this.btnAdd_NV.Image = global::GUI.Properties.Resources.icons8_add_30;
            this.btnAdd_NV.Location = new System.Drawing.Point(657, 35);
            this.btnAdd_NV.Name = "btnAdd_NV";
            this.btnAdd_NV.Size = new System.Drawing.Size(86, 34);
            this.btnAdd_NV.TabIndex = 6;
            this.btnAdd_NV.UseVisualStyleBackColor = false;
            this.btnAdd_NV.Click += new System.EventHandler(this.btnAdd_NV_Click);
            // 
            // btnSearch_NV
            // 
            this.btnSearch_NV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.btnSearch_NV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch_NV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSearch_NV.Image = global::GUI.Properties.Resources.icons8_search_30;
            this.btnSearch_NV.Location = new System.Drawing.Point(262, 42);
            this.btnSearch_NV.Name = "btnSearch_NV";
            this.btnSearch_NV.Size = new System.Drawing.Size(29, 21);
            this.btnSearch_NV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearch_NV.TabIndex = 7;
            this.btnSearch_NV.TabStop = false;
            this.btnSearch_NV.Click += new System.EventHandler(this.btnSearch_NV_Click);
            // 
            // btnReload_NV
            // 
            this.btnReload_NV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.btnReload_NV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReload_NV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnReload_NV.Image = global::GUI.Properties.Resources.icons8_refresh_30;
            this.btnReload_NV.Location = new System.Drawing.Point(303, 42);
            this.btnReload_NV.Name = "btnReload_NV";
            this.btnReload_NV.Size = new System.Drawing.Size(29, 21);
            this.btnReload_NV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReload_NV.TabIndex = 8;
            this.btnReload_NV.TabStop = false;
            this.btnReload_NV.Click += new System.EventHandler(this.btnReload_NV_Click);
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReload_NV);
            this.Controls.Add(this.dataGridView_NV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFind_NV);
            this.Controls.Add(this.btnSearch_NV);
            this.Controls.Add(this.btnAdd_NV);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanLyNhanVien";
            this.Size = new System.Drawing.Size(761, 581);
            this.Load += new System.EventHandler(this.QuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch_NV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload_NV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_NV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFind_NV;
        private System.Windows.Forms.PictureBox btnSearch_NV;
        private System.Windows.Forms.Button btnAdd_NV;
        private System.Windows.Forms.PictureBox btnReload_NV;
    }
}
