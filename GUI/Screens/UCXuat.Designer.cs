
namespace GUI.Screens
{
    partial class UCXuat
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
            this.dataGridView_Xuat = new System.Windows.Forms.DataGridView();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Xuat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Xuat
            // 
            this.dataGridView_Xuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Xuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Xuat.Location = new System.Drawing.Point(0, 65);
            this.dataGridView_Xuat.Name = "dataGridView_Xuat";
            this.dataGridView_Xuat.RowHeadersWidth = 51;
            this.dataGridView_Xuat.Size = new System.Drawing.Size(761, 442);
            this.dataGridView_Xuat.TabIndex = 1;
            this.dataGridView_Xuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Xuat_CellClick);
            this.dataGridView_Xuat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Xuat_CellContentClick);
            // 
            // dtp_start
            // 
            this.dtp_start.CustomFormat = "dd-MM-yyyy";
            this.dtp_start.Location = new System.Drawing.Point(43, 35);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(182, 20);
            this.dtp_start.TabIndex = 2;
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(290, 35);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(185, 20);
            this.dtp_end.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(585, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 20);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label2.Location = new System.Drawing.Point(319, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngày Kết Thúc";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ngày Bắt Đầu";
            // 
            // UCXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtp_end);
            this.Controls.Add(this.dtp_start);
            this.Controls.Add(this.dataGridView_Xuat);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCXuat";
            this.Size = new System.Drawing.Size(761, 507);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Xuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView_Xuat;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
