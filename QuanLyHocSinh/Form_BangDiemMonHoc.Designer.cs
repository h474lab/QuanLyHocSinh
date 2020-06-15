namespace QuanLyHocSinh
{
    partial class Form_BangDiemMonHoc
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
            this.Panel_Title = new System.Windows.Forms.Panel();
            this.Label_Title = new System.Windows.Forms.Label();
            this.GroupBox_BoLoc = new System.Windows.Forms.GroupBox();
            this.ComboBox_MonHoc = new System.Windows.Forms.ComboBox();
            this.ComboBox_Lop = new System.Windows.Forms.ComboBox();
            this.Label_MonHoc = new System.Windows.Forms.Label();
            this.Label_Lop = new System.Windows.Forms.Label();
            this.ComboBox_NamHoc = new System.Windows.Forms.ComboBox();
            this.Label_NamHoc = new System.Windows.Forms.Label();
            this.ComboBox_HocKy = new System.Windows.Forms.ComboBox();
            this.Label_HocKy = new System.Windows.Forms.Label();
            this.GroupBox_BangDiem = new System.Windows.Forms.GroupBox();
            this.GridView_BangDiem = new System.Windows.Forms.DataGridView();
            this.MaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D1T = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel_Title.SuspendLayout();
            this.GroupBox_BoLoc.SuspendLayout();
            this.GroupBox_BangDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_BangDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Title
            // 
            this.Panel_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Panel_Title.Controls.Add(this.Label_Title);
            this.Panel_Title.Location = new System.Drawing.Point(208, 18);
            this.Panel_Title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel_Title.Name = "Panel_Title";
            this.Panel_Title.Size = new System.Drawing.Size(746, 77);
            this.Panel_Title.TabIndex = 2;
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Title.Location = new System.Drawing.Point(174, 14);
            this.Label_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(419, 40);
            this.Label_Title.TabIndex = 0;
            this.Label_Title.Text = "BẢNG ĐIỂM MÔN HỌC";
            // 
            // GroupBox_BoLoc
            // 
            this.GroupBox_BoLoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_BoLoc.Controls.Add(this.ComboBox_NamHoc);
            this.GroupBox_BoLoc.Controls.Add(this.Label_NamHoc);
            this.GroupBox_BoLoc.Controls.Add(this.ComboBox_MonHoc);
            this.GroupBox_BoLoc.Controls.Add(this.ComboBox_Lop);
            this.GroupBox_BoLoc.Controls.Add(this.Label_MonHoc);
            this.GroupBox_BoLoc.Controls.Add(this.Label_Lop);
            this.GroupBox_BoLoc.Controls.Add(this.ComboBox_HocKy);
            this.GroupBox_BoLoc.Controls.Add(this.Label_HocKy);
            this.GroupBox_BoLoc.Location = new System.Drawing.Point(18, 105);
            this.GroupBox_BoLoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox_BoLoc.Name = "GroupBox_BoLoc";
            this.GroupBox_BoLoc.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox_BoLoc.Size = new System.Drawing.Size(1108, 77);
            this.GroupBox_BoLoc.TabIndex = 8;
            this.GroupBox_BoLoc.TabStop = false;
            this.GroupBox_BoLoc.Text = "Bộ lọc";
            // 
            // ComboBox_MonHoc
            // 
            this.ComboBox_MonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_MonHoc.FormattingEnabled = true;
            this.ComboBox_MonHoc.Location = new System.Drawing.Point(877, 26);
            this.ComboBox_MonHoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBox_MonHoc.Name = "ComboBox_MonHoc";
            this.ComboBox_MonHoc.Size = new System.Drawing.Size(216, 28);
            this.ComboBox_MonHoc.TabIndex = 5;
            // 
            // ComboBox_Lop
            // 
            this.ComboBox_Lop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_Lop.FormattingEnabled = true;
            this.ComboBox_Lop.Location = new System.Drawing.Point(59, 26);
            this.ComboBox_Lop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBox_Lop.Name = "ComboBox_Lop";
            this.ComboBox_Lop.Size = new System.Drawing.Size(163, 28);
            this.ComboBox_Lop.TabIndex = 4;
            // 
            // Label_MonHoc
            // 
            this.Label_MonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_MonHoc.AutoSize = true;
            this.Label_MonHoc.Location = new System.Drawing.Point(790, 31);
            this.Label_MonHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_MonHoc.Name = "Label_MonHoc";
            this.Label_MonHoc.Size = new System.Drawing.Size(74, 20);
            this.Label_MonHoc.TabIndex = 2;
            this.Label_MonHoc.Text = "Môn học:";
            // 
            // Label_Lop
            // 
            this.Label_Lop.AutoSize = true;
            this.Label_Lop.Location = new System.Drawing.Point(8, 31);
            this.Label_Lop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Lop.Name = "Label_Lop";
            this.Label_Lop.Size = new System.Drawing.Size(40, 20);
            this.Label_Lop.TabIndex = 0;
            this.Label_Lop.Text = "Lớp:";
            // 
            // ComboBox_NamHoc
            // 
            this.ComboBox_NamHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_NamHoc.FormattingEnabled = true;
            this.ComboBox_NamHoc.Location = new System.Drawing.Point(572, 26);
            this.ComboBox_NamHoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBox_NamHoc.Name = "ComboBox_NamHoc";
            this.ComboBox_NamHoc.Size = new System.Drawing.Size(210, 28);
            this.ComboBox_NamHoc.TabIndex = 7;
            // 
            // Label_NamHoc
            // 
            this.Label_NamHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_NamHoc.AutoSize = true;
            this.Label_NamHoc.Location = new System.Drawing.Point(488, 31);
            this.Label_NamHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_NamHoc.Name = "Label_NamHoc";
            this.Label_NamHoc.Size = new System.Drawing.Size(76, 20);
            this.Label_NamHoc.TabIndex = 6;
            this.Label_NamHoc.Text = "Năm học:";
            // 
            // ComboBox_HocKy
            // 
            this.ComboBox_HocKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_HocKy.FormattingEnabled = true;
            this.ComboBox_HocKy.Location = new System.Drawing.Point(313, 26);
            this.ComboBox_HocKy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBox_HocKy.Name = "ComboBox_HocKy";
            this.ComboBox_HocKy.Size = new System.Drawing.Size(164, 28);
            this.ComboBox_HocKy.TabIndex = 3;
            // 
            // Label_HocKy
            // 
            this.Label_HocKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_HocKy.AutoSize = true;
            this.Label_HocKy.Location = new System.Drawing.Point(237, 31);
            this.Label_HocKy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_HocKy.Name = "Label_HocKy";
            this.Label_HocKy.Size = new System.Drawing.Size(61, 20);
            this.Label_HocKy.TabIndex = 1;
            this.Label_HocKy.Text = "Học kỳ:";
            // 
            // GroupBox_BangDiem
            // 
            this.GroupBox_BangDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_BangDiem.Controls.Add(this.GridView_BangDiem);
            this.GroupBox_BangDiem.Location = new System.Drawing.Point(18, 191);
            this.GroupBox_BangDiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox_BangDiem.Name = "GroupBox_BangDiem";
            this.GroupBox_BangDiem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox_BangDiem.Size = new System.Drawing.Size(1108, 455);
            this.GroupBox_BangDiem.TabIndex = 9;
            this.GroupBox_BangDiem.TabStop = false;
            this.GroupBox_BangDiem.Text = "Bảng điểm";
            // 
            // GridView_BangDiem
            // 
            this.GridView_BangDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridView_BangDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_BangDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHocSinh,
            this.HoTen,
            this.D15,
            this.D1T,
            this.DHK,
            this.DiemTB});
            this.GridView_BangDiem.Location = new System.Drawing.Point(9, 29);
            this.GridView_BangDiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridView_BangDiem.Name = "GridView_BangDiem";
            this.GridView_BangDiem.RowHeadersWidth = 62;
            this.GridView_BangDiem.Size = new System.Drawing.Size(1090, 416);
            this.GridView_BangDiem.TabIndex = 0;
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
            // D15
            // 
            this.D15.DataPropertyName = "1";
            this.D15.HeaderText = "Điểm 15 Phút";
            this.D15.MinimumWidth = 8;
            this.D15.Name = "D15";
            this.D15.Width = 150;
            // 
            // D1T
            // 
            this.D1T.DataPropertyName = "2";
            this.D1T.HeaderText = "Điểm 1 Tiết";
            this.D1T.MinimumWidth = 8;
            this.D1T.Name = "D1T";
            this.D1T.Width = 150;
            // 
            // DHK
            // 
            this.DHK.DataPropertyName = "3";
            this.DHK.HeaderText = "Điểm Học Kỳ";
            this.DHK.MinimumWidth = 8;
            this.DHK.Name = "DHK";
            this.DHK.Width = 150;
            // 
            // DiemTB
            // 
            this.DiemTB.DataPropertyName = "DiemTB";
            this.DiemTB.HeaderText = "Điểm Trung Bình";
            this.DiemTB.MinimumWidth = 8;
            this.DiemTB.Name = "DiemTB";
            this.DiemTB.Width = 150;
            // 
            // Form_BangDiemMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 665);
            this.Controls.Add(this.GroupBox_BangDiem);
            this.Controls.Add(this.GroupBox_BoLoc);
            this.Controls.Add(this.Panel_Title);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_BangDiemMonHoc";
            this.Text = "Bảng Điểm Môn Học";
            this.Panel_Title.ResumeLayout(false);
            this.Panel_Title.PerformLayout();
            this.GroupBox_BoLoc.ResumeLayout(false);
            this.GroupBox_BoLoc.PerformLayout();
            this.GroupBox_BangDiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_BangDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Title;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.GroupBox GroupBox_BoLoc;
        private System.Windows.Forms.ComboBox ComboBox_MonHoc;
        private System.Windows.Forms.ComboBox ComboBox_Lop;
        private System.Windows.Forms.ComboBox ComboBox_HocKy;
        private System.Windows.Forms.Label Label_MonHoc;
        private System.Windows.Forms.Label Label_HocKy;
        private System.Windows.Forms.Label Label_Lop;
        private System.Windows.Forms.GroupBox GroupBox_BangDiem;
        private System.Windows.Forms.DataGridView GridView_BangDiem;
        private System.Windows.Forms.ComboBox ComboBox_NamHoc;
        private System.Windows.Forms.Label Label_NamHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn D15;
        private System.Windows.Forms.DataGridViewTextBoxColumn D1T;
        private System.Windows.Forms.DataGridViewTextBoxColumn DHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTB;
    }
}