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
            this.SoThuTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.SoThuTu_Cho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Em = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GTinh_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Panel_Tittle.Location = new System.Drawing.Point(101, 12);
            this.Panel_Tittle.Name = "Panel_Tittle";
            this.Panel_Tittle.Size = new System.Drawing.Size(497, 50);
            this.Panel_Tittle.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(137, 10);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(272, 29);
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
            this.GroupBox_DSLop.Location = new System.Drawing.Point(13, 130);
            this.GroupBox_DSLop.Name = "GroupBox_DSLop";
            this.GroupBox_DSLop.Size = new System.Drawing.Size(713, 206);
            this.GroupBox_DSLop.TabIndex = 6;
            this.GroupBox_DSLop.TabStop = false;
            this.GroupBox_DSLop.Text = "Danh sách lớp";
            // 
            // Button_Xoa
            // 
            this.Button_Xoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button_Xoa.BackColor = System.Drawing.Color.RoyalBlue;
            this.Button_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Xoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_Xoa.Location = new System.Drawing.Point(290, 166);
            this.Button_Xoa.Name = "Button_Xoa";
            this.Button_Xoa.Size = new System.Drawing.Size(149, 29);
            this.Button_Xoa.TabIndex = 1;
            this.Button_Xoa.Text = "Xóa khỏi danh sách lớp";
            this.Button_Xoa.UseVisualStyleBackColor = false;
            this.Button_Xoa.Click += new System.EventHandler(this.Button_Xoa_Click);
            // 
            // GridView_DSLop
            // 
            this.GridView_DSLop.AllowUserToAddRows = false;
            this.GridView_DSLop.AllowUserToDeleteRows = false;
            this.GridView_DSLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridView_DSLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_DSLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoThuTu,
            this.MaHocSinh,
            this.HoTen,
            this.GioiTinh,
            this.NgaySinh,
            this.DiaChi,
            this.Email,
            this.GioiTinh_1});
            this.GridView_DSLop.Location = new System.Drawing.Point(6, 19);
            this.GridView_DSLop.Name = "GridView_DSLop";
            this.GridView_DSLop.ReadOnly = true;
            this.GridView_DSLop.RowHeadersWidth = 62;
            this.GridView_DSLop.Size = new System.Drawing.Size(701, 140);
            this.GridView_DSLop.TabIndex = 0;
            // 
            // SoThuTu
            // 
            this.SoThuTu.DataPropertyName = "SoThuTu";
            this.SoThuTu.HeaderText = "Số Thứ Tự";
            this.SoThuTu.Name = "SoThuTu";
            this.SoThuTu.ReadOnly = true;
            // 
            // MaHocSinh
            // 
            this.MaHocSinh.DataPropertyName = "MaHocSinh";
            this.MaHocSinh.HeaderText = "Mã Học Sinh";
            this.MaHocSinh.Name = "MaHocSinh";
            this.MaHocSinh.ReadOnly = true;
            this.MaHocSinh.Visible = false;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ và Tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GT";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GioiTinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // GioiTinh_1
            // 
            this.GioiTinh_1.DataPropertyName = "GioiTinh";
            this.GioiTinh_1.HeaderText = "Giới Tính";
            this.GioiTinh_1.Name = "GioiTinh_1";
            this.GioiTinh_1.ReadOnly = true;
            this.GioiTinh_1.Visible = false;
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
            this.GroupBox_ChonLop.Location = new System.Drawing.Point(13, 68);
            this.GroupBox_ChonLop.Name = "GroupBox_ChonLop";
            this.GroupBox_ChonLop.Size = new System.Drawing.Size(713, 56);
            this.GroupBox_ChonLop.TabIndex = 7;
            this.GroupBox_ChonLop.TabStop = false;
            this.GroupBox_ChonLop.Text = "Chọn lớp";
            // 
            // ComboBox_NamHoc
            // 
            this.ComboBox_NamHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_NamHoc.BackColor = System.Drawing.SystemColors.Window;
            this.ComboBox_NamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_NamHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_NamHoc.FormattingEnabled = true;
            this.ComboBox_NamHoc.Location = new System.Drawing.Point(404, 21);
            this.ComboBox_NamHoc.Name = "ComboBox_NamHoc";
            this.ComboBox_NamHoc.Size = new System.Drawing.Size(153, 21);
            this.ComboBox_NamHoc.TabIndex = 14;
            // 
            // Label_NamHoc
            // 
            this.Label_NamHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_NamHoc.AutoSize = true;
            this.Label_NamHoc.Location = new System.Drawing.Point(345, 25);
            this.Label_NamHoc.Name = "Label_NamHoc";
            this.Label_NamHoc.Size = new System.Drawing.Size(53, 13);
            this.Label_NamHoc.TabIndex = 13;
            this.Label_NamHoc.Text = "Năm học:";
            // 
            // TextBox_SiSo
            // 
            this.TextBox_SiSo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_SiSo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_SiSo.Location = new System.Drawing.Point(605, 22);
            this.TextBox_SiSo.Name = "TextBox_SiSo";
            this.TextBox_SiSo.ReadOnly = true;
            this.TextBox_SiSo.Size = new System.Drawing.Size(100, 20);
            this.TextBox_SiSo.TabIndex = 12;
            this.TextBox_SiSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label_SiSo
            // 
            this.Label_SiSo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_SiSo.AutoSize = true;
            this.Label_SiSo.Location = new System.Drawing.Point(563, 25);
            this.Label_SiSo.Name = "Label_SiSo";
            this.Label_SiSo.Size = new System.Drawing.Size(36, 13);
            this.Label_SiSo.TabIndex = 11;
            this.Label_SiSo.Text = "Sĩ số:";
            // 
            // ComboBox_HocKy
            // 
            this.ComboBox_HocKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_HocKy.BackColor = System.Drawing.SystemColors.Window;
            this.ComboBox_HocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_HocKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_HocKy.FormattingEnabled = true;
            this.ComboBox_HocKy.Location = new System.Drawing.Point(230, 22);
            this.ComboBox_HocKy.Name = "ComboBox_HocKy";
            this.ComboBox_HocKy.Size = new System.Drawing.Size(109, 21);
            this.ComboBox_HocKy.TabIndex = 10;
            // 
            // Label_HocKy
            // 
            this.Label_HocKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_HocKy.AutoSize = true;
            this.Label_HocKy.Location = new System.Drawing.Point(180, 25);
            this.Label_HocKy.Name = "Label_HocKy";
            this.Label_HocKy.Size = new System.Drawing.Size(44, 13);
            this.Label_HocKy.TabIndex = 9;
            this.Label_HocKy.Text = "Học kỳ:";
            // 
            // ComboBox_Lop
            // 
            this.ComboBox_Lop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_Lop.BackColor = System.Drawing.SystemColors.Window;
            this.ComboBox_Lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Lop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Lop.FormattingEnabled = true;
            this.ComboBox_Lop.Location = new System.Drawing.Point(43, 22);
            this.ComboBox_Lop.Name = "ComboBox_Lop";
            this.ComboBox_Lop.Size = new System.Drawing.Size(131, 21);
            this.ComboBox_Lop.TabIndex = 8;
            // 
            // Label_Lop
            // 
            this.Label_Lop.AutoSize = true;
            this.Label_Lop.Location = new System.Drawing.Point(9, 25);
            this.Label_Lop.Name = "Label_Lop";
            this.Label_Lop.Size = new System.Drawing.Size(28, 13);
            this.Label_Lop.TabIndex = 0;
            this.Label_Lop.Text = "Lớp:";
            // 
            // GroupBox_DanhSachCho
            // 
            this.GroupBox_DanhSachCho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_DanhSachCho.Controls.Add(this.Button_Them);
            this.GroupBox_DanhSachCho.Controls.Add(this.GridView_DSCho);
            this.GroupBox_DanhSachCho.Location = new System.Drawing.Point(301, 342);
            this.GroupBox_DanhSachCho.Name = "GroupBox_DanhSachCho";
            this.GroupBox_DanhSachCho.Size = new System.Drawing.Size(425, 186);
            this.GroupBox_DanhSachCho.TabIndex = 8;
            this.GroupBox_DanhSachCho.TabStop = false;
            this.GroupBox_DanhSachCho.Text = "Danh sách chờ";
            // 
            // Button_Them
            // 
            this.Button_Them.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button_Them.BackColor = System.Drawing.Color.RoyalBlue;
            this.Button_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Them.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_Them.Location = new System.Drawing.Point(167, 145);
            this.Button_Them.Name = "Button_Them";
            this.Button_Them.Size = new System.Drawing.Size(88, 29);
            this.Button_Them.TabIndex = 2;
            this.Button_Them.Text = "Thêm vào lớp";
            this.Button_Them.UseVisualStyleBackColor = false;
            this.Button_Them.Click += new System.EventHandler(this.Button_Them_Click);
            // 
            // GridView_DSCho
            // 
            this.GridView_DSCho.AllowUserToAddRows = false;
            this.GridView_DSCho.AllowUserToDeleteRows = false;
            this.GridView_DSCho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridView_DSCho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_DSCho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoThuTu_Cho,
            this.MaHS,
            this.HTen,
            this.GTinh,
            this.NSinh,
            this.DChi,
            this.Em,
            this.GTinh_1});
            this.GridView_DSCho.Location = new System.Drawing.Point(6, 19);
            this.GridView_DSCho.Name = "GridView_DSCho";
            this.GridView_DSCho.ReadOnly = true;
            this.GridView_DSCho.RowHeadersWidth = 62;
            this.GridView_DSCho.Size = new System.Drawing.Size(413, 121);
            this.GridView_DSCho.TabIndex = 0;
            // 
            // SoThuTu_Cho
            // 
            this.SoThuTu_Cho.DataPropertyName = "SoThuTu";
            this.SoThuTu_Cho.HeaderText = "Số Thứ Tự";
            this.SoThuTu_Cho.Name = "SoThuTu_Cho";
            this.SoThuTu_Cho.ReadOnly = true;
            // 
            // MaHS
            // 
            this.MaHS.DataPropertyName = "MaHocSinh";
            this.MaHS.HeaderText = "Mã Học Sinh";
            this.MaHS.Name = "MaHS";
            this.MaHS.ReadOnly = true;
            // 
            // HTen
            // 
            this.HTen.DataPropertyName = "HoTen";
            this.HTen.HeaderText = "Họ và Tên";
            this.HTen.Name = "HTen";
            this.HTen.ReadOnly = true;
            // 
            // GTinh
            // 
            this.GTinh.DataPropertyName = "GT";
            this.GTinh.HeaderText = "Giới Tính";
            this.GTinh.Name = "GTinh";
            this.GTinh.ReadOnly = true;
            this.GTinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GTinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NSinh
            // 
            this.NSinh.DataPropertyName = "NgaySinh";
            this.NSinh.HeaderText = "Ngày Sinh";
            this.NSinh.Name = "NSinh";
            this.NSinh.ReadOnly = true;
            // 
            // DChi
            // 
            this.DChi.DataPropertyName = "DiaChi";
            this.DChi.HeaderText = "Địa Chỉ";
            this.DChi.Name = "DChi";
            this.DChi.ReadOnly = true;
            // 
            // Em
            // 
            this.Em.DataPropertyName = "Email";
            this.Em.HeaderText = "Email";
            this.Em.Name = "Em";
            this.Em.ReadOnly = true;
            // 
            // GTinh_1
            // 
            this.GTinh_1.DataPropertyName = "GioiTinh";
            this.GTinh_1.HeaderText = "Giới Tính";
            this.GTinh_1.Name = "GTinh_1";
            this.GTinh_1.ReadOnly = true;
            this.GTinh_1.Visible = false;
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
            this.GroupBox_BoLoc.Location = new System.Drawing.Point(13, 342);
            this.GroupBox_BoLoc.Name = "GroupBox_BoLoc";
            this.GroupBox_BoLoc.Size = new System.Drawing.Size(282, 186);
            this.GroupBox_BoLoc.TabIndex = 9;
            this.GroupBox_BoLoc.TabStop = false;
            this.GroupBox_BoLoc.Text = "Bộ lọc";
            // 
            // DateTimePicker_NgaySinh
            // 
            this.DateTimePicker_NgaySinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePicker_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker_NgaySinh.Location = new System.Drawing.Point(82, 79);
            this.DateTimePicker_NgaySinh.Name = "DateTimePicker_NgaySinh";
            this.DateTimePicker_NgaySinh.RightToLeftLayout = true;
            this.DateTimePicker_NgaySinh.Size = new System.Drawing.Size(194, 20);
            this.DateTimePicker_NgaySinh.TabIndex = 14;
            // 
            // RadioButton_Nu
            // 
            this.RadioButton_Nu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioButton_Nu.AutoSize = true;
            this.RadioButton_Nu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RadioButton_Nu.Location = new System.Drawing.Point(161, 112);
            this.RadioButton_Nu.Name = "RadioButton_Nu";
            this.RadioButton_Nu.Size = new System.Drawing.Size(38, 17);
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
            this.RadioButton_CaHai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RadioButton_CaHai.Location = new System.Drawing.Point(221, 111);
            this.RadioButton_CaHai.Name = "RadioButton_CaHai";
            this.RadioButton_CaHai.Size = new System.Drawing.Size(54, 17);
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
            this.RadioButton_Nam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RadioButton_Nam.Location = new System.Drawing.Point(82, 112);
            this.RadioButton_Nam.Name = "RadioButton_Nam";
            this.RadioButton_Nam.Size = new System.Drawing.Size(46, 17);
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
            this.Button_TimKiem.BackColor = System.Drawing.Color.RoyalBlue;
            this.Button_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_TimKiem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_TimKiem.Location = new System.Drawing.Point(110, 143);
            this.Button_TimKiem.Name = "Button_TimKiem";
            this.Button_TimKiem.Size = new System.Drawing.Size(75, 32);
            this.Button_TimKiem.TabIndex = 10;
            this.Button_TimKiem.Text = "Tìm kiếm";
            this.Button_TimKiem.UseVisualStyleBackColor = false;
            // 
            // TextBox_HoTen
            // 
            this.TextBox_HoTen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_HoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_HoTen.Location = new System.Drawing.Point(82, 52);
            this.TextBox_HoTen.Name = "TextBox_HoTen";
            this.TextBox_HoTen.Size = new System.Drawing.Size(194, 20);
            this.TextBox_HoTen.TabIndex = 5;
            // 
            // TextBox_MaHS
            // 
            this.TextBox_MaHS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_MaHS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_MaHS.Location = new System.Drawing.Point(82, 23);
            this.TextBox_MaHS.Name = "TextBox_MaHS";
            this.TextBox_MaHS.Size = new System.Drawing.Size(194, 20);
            this.TextBox_MaHS.TabIndex = 4;
            // 
            // Label_GioiTinh
            // 
            this.Label_GioiTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_GioiTinh.AutoSize = true;
            this.Label_GioiTinh.Location = new System.Drawing.Point(6, 116);
            this.Label_GioiTinh.Name = "Label_GioiTinh";
            this.Label_GioiTinh.Size = new System.Drawing.Size(50, 13);
            this.Label_GioiTinh.TabIndex = 3;
            this.Label_GioiTinh.Text = "Giới tính:";
            // 
            // Label_NgaySinh
            // 
            this.Label_NgaySinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_NgaySinh.AutoSize = true;
            this.Label_NgaySinh.Location = new System.Drawing.Point(6, 85);
            this.Label_NgaySinh.Name = "Label_NgaySinh";
            this.Label_NgaySinh.Size = new System.Drawing.Size(57, 13);
            this.Label_NgaySinh.TabIndex = 2;
            this.Label_NgaySinh.Text = "Ngày sinh:";
            // 
            // Label_MaHS
            // 
            this.Label_MaHS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_MaHS.AutoSize = true;
            this.Label_MaHS.Location = new System.Drawing.Point(6, 26);
            this.Label_MaHS.Name = "Label_MaHS";
            this.Label_MaHS.Size = new System.Drawing.Size(70, 13);
            this.Label_MaHS.TabIndex = 1;
            this.Label_MaHS.Text = "Mã Học sinh:";
            // 
            // Label_HoTen
            // 
            this.Label_HoTen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_HoTen.AutoSize = true;
            this.Label_HoTen.Location = new System.Drawing.Point(6, 55);
            this.Label_HoTen.Name = "Label_HoTen";
            this.Label_HoTen.Size = new System.Drawing.Size(61, 13);
            this.Label_HoTen.TabIndex = 0;
            this.Label_HoTen.Text = "Họ và Tên:";
            // 
            // Form_LapDSLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(738, 536);
            this.Controls.Add(this.GroupBox_BoLoc);
            this.Controls.Add(this.GroupBox_DanhSachCho);
            this.Controls.Add(this.GroupBox_ChonLop);
            this.Controls.Add(this.GroupBox_DSLop);
            this.Controls.Add(this.Panel_Tittle);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn SoThuTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoThuTu_Cho;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Em;
        private System.Windows.Forms.DataGridViewTextBoxColumn GTinh_1;
    }
}