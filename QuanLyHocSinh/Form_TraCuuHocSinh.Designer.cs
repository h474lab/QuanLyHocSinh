namespace QuanLyHocSinh
{
    partial class Form_TraCuuHocSinh
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
            this.Panel_Tittle = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.GroupBox_DSHocSinh = new System.Windows.Forms.GroupBox();
            this.GridView_DSHocSinh = new System.Windows.Forms.DataGridView();
            this.MaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Panel_Tittle.SuspendLayout();
            this.GroupBox_DSHocSinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_DSHocSinh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Tittle
            // 
            this.Panel_Tittle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Panel_Tittle.Controls.Add(this.Title);
            this.Panel_Tittle.Location = new System.Drawing.Point(208, 12);
            this.Panel_Tittle.Name = "Panel_Tittle";
            this.Panel_Tittle.Size = new System.Drawing.Size(497, 50);
            this.Panel_Tittle.TabIndex = 2;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(108, 11);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(291, 29);
            this.Title.TabIndex = 0;
            this.Title.Text = "DANH SÁCH HỌC SINH";
            // 
            // GroupBox_DSHocSinh
            // 
            this.GroupBox_DSHocSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_DSHocSinh.Controls.Add(this.GridView_DSHocSinh);
            this.GroupBox_DSHocSinh.Location = new System.Drawing.Point(12, 135);
            this.GroupBox_DSHocSinh.Name = "GroupBox_DSHocSinh";
            this.GroupBox_DSHocSinh.Size = new System.Drawing.Size(887, 378);
            this.GroupBox_DSHocSinh.TabIndex = 3;
            this.GroupBox_DSHocSinh.TabStop = false;
            this.GroupBox_DSHocSinh.Text = "Danh sách học sinh";
            // 
            // GridView_DSHocSinh
            // 
            this.GridView_DSHocSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridView_DSHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_DSHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHocSinh,
            this.HoTen,
            this.GioiTinh,
            this.NgaySinh,
            this.DiaChi,
            this.Email});
            this.GridView_DSHocSinh.Location = new System.Drawing.Point(8, 19);
            this.GridView_DSHocSinh.Name = "GridView_DSHocSinh";
            this.GridView_DSHocSinh.RowHeadersWidth = 62;
            this.GridView_DSHocSinh.Size = new System.Drawing.Size(871, 353);
            this.GridView_DSHocSinh.TabIndex = 0;
            // 
            // MaHocSinh
            // 
            this.MaHocSinh.DataPropertyName = "MaHocSinh";
            this.MaHocSinh.HeaderText = "Mã Học Sinh";
            this.MaHocSinh.MinimumWidth = 8;
            this.MaHocSinh.Name = "MaHocSinh";
            this.MaHocSinh.Width = 150;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ và Tên";
            this.HoTen.MinimumWidth = 8;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 150;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 8;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GioiTinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.GioiTinh.Width = 150;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 8;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            this.NgaySinh.Width = 150;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 8;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 150;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 52);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tra cứu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và Tên:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Form_TraCuuHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(911, 525);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBox_DSHocSinh);
            this.Controls.Add(this.Panel_Tittle);
            this.Name = "Form_TraCuuHocSinh";
            this.Text = "Form_TraCuuHocSinh";
            this.Panel_Tittle.ResumeLayout(false);
            this.Panel_Tittle.PerformLayout();
            this.GroupBox_DSHocSinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_DSHocSinh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Tittle;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.GroupBox GroupBox_DSHocSinh;
        private System.Windows.Forms.DataGridView GridView_DSHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}