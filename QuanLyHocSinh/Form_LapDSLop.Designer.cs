namespace QuanLyHocSinh
{
    partial class Form_LapDSLop
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
            this.GroupBox_DSLop = new System.Windows.Forms.GroupBox();
            this.Button_Xoa = new System.Windows.Forms.Button();
            this.GridView_DSLop = new System.Windows.Forms.DataGridView();
            this.GroupBox_ChonLop = new System.Windows.Forms.GroupBox();
            this.ComboBox_NamHoc = new System.Windows.Forms.ComboBox();
            this.Label_NamHoc = new System.Windows.Forms.Label();
            this.TextBox_SiSo = new System.Windows.Forms.TextBox();
            this.Label_SiSo = new System.Windows.Forms.Label();
            this.ComboBox_HocKy = new System.Windows.Forms.ComboBox();
            this.Label_HocKy = new System.Windows.Forms.Label();
            this.ComboBox_Lop = new System.Windows.Forms.ComboBox();
            this.Label_Lop = new System.Windows.Forms.Label();
            this.GroupBox_DanhSachCho = new System.Windows.Forms.GroupBox();
            this.Button_Them = new System.Windows.Forms.Button();
            this.GridView_DSCho = new System.Windows.Forms.DataGridView();
            this.GroupBox_BoLoc = new System.Windows.Forms.GroupBox();
            this.DateTimePicker_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.RadioButton_Nu = new System.Windows.Forms.RadioButton();
            this.RadioButton_CaHai = new System.Windows.Forms.RadioButton();
            this.RadioButton_Nam = new System.Windows.Forms.RadioButton();
            this.Button_TimKiem = new System.Windows.Forms.Button();
            this.TextBox_HoTen = new System.Windows.Forms.TextBox();
            this.TextBox_MaHS = new System.Windows.Forms.TextBox();
            this.Label_GioiTinh = new System.Windows.Forms.Label();
            this.Label_NgaySinh = new System.Windows.Forms.Label();
            this.Label_MaHS = new System.Windows.Forms.Label();
            this.Label_HoTen = new System.Windows.Forms.Label();
            this.Panel_Tittle.SuspendLayout();
            this.GroupBox_DSLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_DSLop)).BeginInit();
            this.GroupBox_ChonLop.SuspendLayout();
            this.GroupBox_DanhSachCho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_DSCho)).BeginInit();
            this.GroupBox_BoLoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Tittle
            // 
            this.Panel_Tittle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Panel_Tittle.Controls.Add(this.Title);
            this.Panel_Tittle.Location = new System.Drawing.Point(152, 18);
            this.Panel_Tittle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel_Tittle.Name = "Panel_Tittle";
            this.Panel_Tittle.Size = new System.Drawing.Size(746, 77);
            this.Panel_Tittle.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(206, 15);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(406, 40);
            this.Title.TabIndex = 0;
            this.Title.Text = "LẬP DANH SÁCH LỚP";
            // 
            // GroupBox_DSLop
            // 
            this.GroupBox_DSLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_DSLop.Controls.Add(this.Button_Xoa);
            this.GroupBox_DSLop.Controls.Add(this.GridView_DSLop);
            this.GroupBox_DSLop.Location = new System.Drawing.Point(20, 200);
            this.GroupBox_DSLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox_DSLop.Name = "GroupBox_DSLop";
            this.GroupBox_DSLop.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox_DSLop.Size = new System.Drawing.Size(1070, 317);
            this.GroupBox_DSLop.TabIndex = 6;
            this.GroupBox_DSLop.TabStop = false;
            this.GroupBox_DSLop.Text = "Danh sách lớp";
            // 
            // Button_Xoa
            // 
            this.Button_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Xoa.Location = new System.Drawing.Point(435, 255);
            this.Button_Xoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Xoa.Name = "Button_Xoa";
            this.Button_Xoa.Size = new System.Drawing.Size(224, 45);
            this.Button_Xoa.TabIndex = 1;
            this.Button_Xoa.Text = "Xóa khỏi danh sách lớp";
            this.Button_Xoa.UseVisualStyleBackColor = true;
            this.Button_Xoa.Click += new System.EventHandler(this.Button_Xoa_Click);
            // 
            // GridView_DSLop
            // 
            this.GridView_DSLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridView_DSLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_DSLop.Location = new System.Drawing.Point(9, 29);
            this.GridView_DSLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridView_DSLop.Name = "GridView_DSLop";
            this.GridView_DSLop.RowHeadersWidth = 62;
            this.GridView_DSLop.Size = new System.Drawing.Size(1052, 215);
            this.GridView_DSLop.TabIndex = 0;
            // 
            // GroupBox_ChonLop
            // 
            this.GroupBox_ChonLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_ChonLop.Controls.Add(this.ComboBox_NamHoc);
            this.GroupBox_ChonLop.Controls.Add(this.Label_NamHoc);
            this.GroupBox_ChonLop.Controls.Add(this.TextBox_SiSo);
            this.GroupBox_ChonLop.Controls.Add(this.Label_SiSo);
            this.GroupBox_ChonLop.Controls.Add(this.ComboBox_HocKy);
            this.GroupBox_ChonLop.Controls.Add(this.Label_HocKy);
            this.GroupBox_ChonLop.Controls.Add(this.ComboBox_Lop);
            this.GroupBox_ChonLop.Controls.Add(this.Label_Lop);
            this.GroupBox_ChonLop.Location = new System.Drawing.Point(20, 105);
            this.GroupBox_ChonLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox_ChonLop.Name = "GroupBox_ChonLop";
            this.GroupBox_ChonLop.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox_ChonLop.Size = new System.Drawing.Size(1070, 86);
            this.GroupBox_ChonLop.TabIndex = 7;
            this.GroupBox_ChonLop.TabStop = false;
            this.GroupBox_ChonLop.Text = "Chọn lớp";
            // 
            // ComboBox_NamHoc
            // 
            this.ComboBox_NamHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_NamHoc.FormattingEnabled = true;
            this.ComboBox_NamHoc.Location = new System.Drawing.Point(606, 32);
            this.ComboBox_NamHoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBox_NamHoc.Name = "ComboBox_NamHoc";
            this.ComboBox_NamHoc.Size = new System.Drawing.Size(228, 28);
            this.ComboBox_NamHoc.TabIndex = 14;
            // 
            // Label_NamHoc
            // 
            this.Label_NamHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_NamHoc.AutoSize = true;
            this.Label_NamHoc.Location = new System.Drawing.Point(518, 38);
            this.Label_NamHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_NamHoc.Name = "Label_NamHoc";
            this.Label_NamHoc.Size = new System.Drawing.Size(76, 20);
            this.Label_NamHoc.TabIndex = 13;
            this.Label_NamHoc.Text = "Năm học:";
            // 
            // TextBox_SiSo
            // 
            this.TextBox_SiSo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_SiSo.Location = new System.Drawing.Point(908, 34);
            this.TextBox_SiSo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_SiSo.Name = "TextBox_SiSo";
            this.TextBox_SiSo.ReadOnly = true;
            this.TextBox_SiSo.Size = new System.Drawing.Size(148, 26);
            this.TextBox_SiSo.TabIndex = 12;
            this.TextBox_SiSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label_SiSo
            // 
            this.Label_SiSo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_SiSo.AutoSize = true;
            this.Label_SiSo.Location = new System.Drawing.Point(844, 38);
            this.Label_SiSo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SiSo.Name = "Label_SiSo";
            this.Label_SiSo.Size = new System.Drawing.Size(48, 20);
            this.Label_SiSo.TabIndex = 11;
            this.Label_SiSo.Text = "Sĩ số:";
            // 
            // ComboBox_HocKy
            // 
            this.ComboBox_HocKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_HocKy.FormattingEnabled = true;
            this.ComboBox_HocKy.Location = new System.Drawing.Point(345, 34);
            this.ComboBox_HocKy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBox_HocKy.Name = "ComboBox_HocKy";
            this.ComboBox_HocKy.Size = new System.Drawing.Size(162, 28);
            this.ComboBox_HocKy.TabIndex = 10;
            // 
            // Label_HocKy
            // 
            this.Label_HocKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_HocKy.AutoSize = true;
            this.Label_HocKy.Location = new System.Drawing.Point(270, 38);
            this.Label_HocKy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_HocKy.Name = "Label_HocKy";
            this.Label_HocKy.Size = new System.Drawing.Size(61, 20);
            this.Label_HocKy.TabIndex = 9;
            this.Label_HocKy.Text = "Học kỳ:";
            // 
            // ComboBox_Lop
            // 
            this.ComboBox_Lop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_Lop.FormattingEnabled = true;
            this.ComboBox_Lop.Location = new System.Drawing.Point(64, 34);
            this.ComboBox_Lop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBox_Lop.Name = "ComboBox_Lop";
            this.ComboBox_Lop.Size = new System.Drawing.Size(194, 28);
            this.ComboBox_Lop.TabIndex = 8;
            // 
            // Label_Lop
            // 
            this.Label_Lop.AutoSize = true;
            this.Label_Lop.Location = new System.Drawing.Point(14, 38);
            this.Label_Lop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Lop.Name = "Label_Lop";
            this.Label_Lop.Size = new System.Drawing.Size(40, 20);
            this.Label_Lop.TabIndex = 0;
            this.Label_Lop.Text = "Lớp:";
            // 
            // GroupBox_DanhSachCho
            // 
            this.GroupBox_DanhSachCho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_DanhSachCho.Controls.Add(this.Button_Them);
            this.GroupBox_DanhSachCho.Controls.Add(this.GridView_DSCho);
            this.GroupBox_DanhSachCho.Location = new System.Drawing.Point(452, 526);
            this.GroupBox_DanhSachCho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox_DanhSachCho.Name = "GroupBox_DanhSachCho";
            this.GroupBox_DanhSachCho.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox_DanhSachCho.Size = new System.Drawing.Size(638, 286);
            this.GroupBox_DanhSachCho.TabIndex = 8;
            this.GroupBox_DanhSachCho.TabStop = false;
            this.GroupBox_DanhSachCho.Text = "Danh sách chờ";
            // 
            // Button_Them
            // 
            this.Button_Them.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button_Them.Location = new System.Drawing.Point(250, 223);
            this.Button_Them.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Them.Name = "Button_Them";
            this.Button_Them.Size = new System.Drawing.Size(132, 45);
            this.Button_Them.TabIndex = 2;
            this.Button_Them.Text = "Thêm vào lớp";
            this.Button_Them.UseVisualStyleBackColor = true;
            this.Button_Them.Click += new System.EventHandler(this.Button_Them_Click);
            // 
            // GridView_DSCho
            // 
            this.GridView_DSCho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridView_DSCho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_DSCho.Location = new System.Drawing.Point(9, 29);
            this.GridView_DSCho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridView_DSCho.Name = "GridView_DSCho";
            this.GridView_DSCho.RowHeadersWidth = 62;
            this.GridView_DSCho.Size = new System.Drawing.Size(620, 186);
            this.GridView_DSCho.TabIndex = 0;
            // 
            // GroupBox_BoLoc
            // 
            this.GroupBox_BoLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupBox_BoLoc.Controls.Add(this.DateTimePicker_NgaySinh);
            this.GroupBox_BoLoc.Controls.Add(this.RadioButton_Nu);
            this.GroupBox_BoLoc.Controls.Add(this.RadioButton_CaHai);
            this.GroupBox_BoLoc.Controls.Add(this.RadioButton_Nam);
            this.GroupBox_BoLoc.Controls.Add(this.Button_TimKiem);
            this.GroupBox_BoLoc.Controls.Add(this.TextBox_HoTen);
            this.GroupBox_BoLoc.Controls.Add(this.TextBox_MaHS);
            this.GroupBox_BoLoc.Controls.Add(this.Label_GioiTinh);
            this.GroupBox_BoLoc.Controls.Add(this.Label_NgaySinh);
            this.GroupBox_BoLoc.Controls.Add(this.Label_MaHS);
            this.GroupBox_BoLoc.Controls.Add(this.Label_HoTen);
            this.GroupBox_BoLoc.Location = new System.Drawing.Point(20, 526);
            this.GroupBox_BoLoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox_BoLoc.Name = "GroupBox_BoLoc";
            this.GroupBox_BoLoc.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox_BoLoc.Size = new System.Drawing.Size(423, 286);
            this.GroupBox_BoLoc.TabIndex = 9;
            this.GroupBox_BoLoc.TabStop = false;
            this.GroupBox_BoLoc.Text = "Bộ lọc";
            // 
            // DateTimePicker_NgaySinh
            // 
            this.DateTimePicker_NgaySinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePicker_NgaySinh.Location = new System.Drawing.Point(123, 122);
            this.DateTimePicker_NgaySinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateTimePicker_NgaySinh.Name = "DateTimePicker_NgaySinh";
            this.DateTimePicker_NgaySinh.Size = new System.Drawing.Size(289, 26);
            this.DateTimePicker_NgaySinh.TabIndex = 14;
            // 
            // RadioButton_Nu
            // 
            this.RadioButton_Nu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioButton_Nu.AutoSize = true;
            this.RadioButton_Nu.Location = new System.Drawing.Point(242, 172);
            this.RadioButton_Nu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadioButton_Nu.Name = "RadioButton_Nu";
            this.RadioButton_Nu.Size = new System.Drawing.Size(54, 24);
            this.RadioButton_Nu.TabIndex = 13;
            this.RadioButton_Nu.TabStop = true;
            this.RadioButton_Nu.Text = "Nữ";
            this.RadioButton_Nu.UseVisualStyleBackColor = true;
            // 
            // RadioButton_CaHai
            // 
            this.RadioButton_CaHai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioButton_CaHai.AutoSize = true;
            this.RadioButton_CaHai.Location = new System.Drawing.Point(332, 171);
            this.RadioButton_CaHai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadioButton_CaHai.Name = "RadioButton_CaHai";
            this.RadioButton_CaHai.Size = new System.Drawing.Size(79, 24);
            this.RadioButton_CaHai.TabIndex = 12;
            this.RadioButton_CaHai.TabStop = true;
            this.RadioButton_CaHai.Text = "Cả hai";
            this.RadioButton_CaHai.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Nam
            // 
            this.RadioButton_Nam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioButton_Nam.AutoSize = true;
            this.RadioButton_Nam.Location = new System.Drawing.Point(123, 172);
            this.RadioButton_Nam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadioButton_Nam.Name = "RadioButton_Nam";
            this.RadioButton_Nam.Size = new System.Drawing.Size(67, 24);
            this.RadioButton_Nam.TabIndex = 11;
            this.RadioButton_Nam.TabStop = true;
            this.RadioButton_Nam.Text = "Nam";
            this.RadioButton_Nam.UseVisualStyleBackColor = true;
            // 
            // Button_TimKiem
            // 
            this.Button_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_TimKiem.Location = new System.Drawing.Point(165, 220);
            this.Button_TimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_TimKiem.Name = "Button_TimKiem";
            this.Button_TimKiem.Size = new System.Drawing.Size(112, 49);
            this.Button_TimKiem.TabIndex = 10;
            this.Button_TimKiem.Text = "Tìm kiếm";
            this.Button_TimKiem.UseVisualStyleBackColor = true;
            // 
            // TextBox_HoTen
            // 
            this.TextBox_HoTen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_HoTen.Location = new System.Drawing.Point(123, 80);
            this.TextBox_HoTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_HoTen.Name = "TextBox_HoTen";
            this.TextBox_HoTen.Size = new System.Drawing.Size(289, 26);
            this.TextBox_HoTen.TabIndex = 5;
            // 
            // TextBox_MaHS
            // 
            this.TextBox_MaHS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_MaHS.Location = new System.Drawing.Point(123, 35);
            this.TextBox_MaHS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_MaHS.Name = "TextBox_MaHS";
            this.TextBox_MaHS.Size = new System.Drawing.Size(289, 26);
            this.TextBox_MaHS.TabIndex = 4;
            // 
            // Label_GioiTinh
            // 
            this.Label_GioiTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_GioiTinh.AutoSize = true;
            this.Label_GioiTinh.Location = new System.Drawing.Point(9, 178);
            this.Label_GioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_GioiTinh.Name = "Label_GioiTinh";
            this.Label_GioiTinh.Size = new System.Drawing.Size(71, 20);
            this.Label_GioiTinh.TabIndex = 3;
            this.Label_GioiTinh.Text = "Giới tính:";
            // 
            // Label_NgaySinh
            // 
            this.Label_NgaySinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_NgaySinh.AutoSize = true;
            this.Label_NgaySinh.Location = new System.Drawing.Point(9, 131);
            this.Label_NgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_NgaySinh.Name = "Label_NgaySinh";
            this.Label_NgaySinh.Size = new System.Drawing.Size(82, 20);
            this.Label_NgaySinh.TabIndex = 2;
            this.Label_NgaySinh.Text = "Ngày sinh:";
            // 
            // Label_MaHS
            // 
            this.Label_MaHS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_MaHS.AutoSize = true;
            this.Label_MaHS.Location = new System.Drawing.Point(9, 40);
            this.Label_MaHS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_MaHS.Name = "Label_MaHS";
            this.Label_MaHS.Size = new System.Drawing.Size(101, 20);
            this.Label_MaHS.TabIndex = 1;
            this.Label_MaHS.Text = "Mã Học sinh:";
            // 
            // Label_HoTen
            // 
            this.Label_HoTen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_HoTen.AutoSize = true;
            this.Label_HoTen.Location = new System.Drawing.Point(9, 85);
            this.Label_HoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_HoTen.Name = "Label_HoTen";
            this.Label_HoTen.Size = new System.Drawing.Size(85, 20);
            this.Label_HoTen.TabIndex = 0;
            this.Label_HoTen.Text = "Họ và Tên:";
            // 
            // Form_LapDSLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 825);
            this.Controls.Add(this.GroupBox_BoLoc);
            this.Controls.Add(this.GroupBox_DanhSachCho);
            this.Controls.Add(this.GroupBox_ChonLop);
            this.Controls.Add(this.GroupBox_DSLop);
            this.Controls.Add(this.Panel_Tittle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_LapDSLop";
            this.Text = " Lập Danh Sách Lớp";
            this.Panel_Tittle.ResumeLayout(false);
            this.Panel_Tittle.PerformLayout();
            this.GroupBox_DSLop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_DSLop)).EndInit();
            this.GroupBox_ChonLop.ResumeLayout(false);
            this.GroupBox_ChonLop.PerformLayout();
            this.GroupBox_DanhSachCho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_DSCho)).EndInit();
            this.GroupBox_BoLoc.ResumeLayout(false);
            this.GroupBox_BoLoc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Tittle;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.GroupBox GroupBox_DSLop;
        private System.Windows.Forms.DataGridView GridView_DSLop;
        private System.Windows.Forms.GroupBox GroupBox_ChonLop;
        private System.Windows.Forms.Label Label_Lop;
        private System.Windows.Forms.ComboBox ComboBox_HocKy;
        private System.Windows.Forms.Label Label_HocKy;
        private System.Windows.Forms.ComboBox ComboBox_Lop;
        private System.Windows.Forms.TextBox TextBox_SiSo;
        private System.Windows.Forms.Label Label_SiSo;
        private System.Windows.Forms.GroupBox GroupBox_DanhSachCho;
        private System.Windows.Forms.DataGridView GridView_DSCho;
        private System.Windows.Forms.GroupBox GroupBox_BoLoc;
        private System.Windows.Forms.Label Label_HoTen;
        private System.Windows.Forms.Label Label_NgaySinh;
        private System.Windows.Forms.Label Label_MaHS;
        private System.Windows.Forms.Button Button_Xoa;
        private System.Windows.Forms.Button Button_Them;
        private System.Windows.Forms.Button Button_TimKiem;
        private System.Windows.Forms.TextBox TextBox_HoTen;
        private System.Windows.Forms.TextBox TextBox_MaHS;
        private System.Windows.Forms.Label Label_GioiTinh;
        private System.Windows.Forms.DateTimePicker DateTimePicker_NgaySinh;
        private System.Windows.Forms.RadioButton RadioButton_Nu;
        private System.Windows.Forms.RadioButton RadioButton_CaHai;
        private System.Windows.Forms.RadioButton RadioButton_Nam;
        private System.Windows.Forms.ComboBox ComboBox_NamHoc;
        private System.Windows.Forms.Label Label_NamHoc;
    }
}