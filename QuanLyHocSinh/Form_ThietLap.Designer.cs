namespace QuanLyHocSinh
{
    partial class Form_ThietLap
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
            this.GroupBox_ThayDoiQD = new System.Windows.Forms.GroupBox();
            this.TextBox_DiemDatMon = new System.Windows.Forms.TextBox();
            this.Label_DiemDatMon = new System.Windows.Forms.Label();
            this.Button_Luu = new System.Windows.Forms.Button();
            this.Label_2 = new System.Windows.Forms.Label();
            this.TextBox_DiemMax = new System.Windows.Forms.TextBox();
            this.TextBox_DiemMin = new System.Windows.Forms.TextBox();
            this.TextBox_DiemDat = new System.Windows.Forms.TextBox();
            this.Label_DiemDat = new System.Windows.Forms.Label();
            this.Label_KhoangDiem = new System.Windows.Forms.Label();
            this.TextBox_SiSoMax = new System.Windows.Forms.TextBox();
            this.Label_SiSoMax = new System.Windows.Forms.Label();
            this.Label_1 = new System.Windows.Forms.Label();
            this.TextBox_TuoiMax = new System.Windows.Forms.TextBox();
            this.TextBox_TuoiMin = new System.Windows.Forms.TextBox();
            this.Label_Tuoi = new System.Windows.Forms.Label();
            this.GroupBox_DSMonHoc = new System.Windows.Forms.GroupBox();
            this.GridView_DSMonHoc = new System.Windows.Forms.DataGridView();
            this.GroupBox_DSLop = new System.Windows.Forms.GroupBox();
            this.GridView_DSLop = new System.Windows.Forms.DataGridView();
            this.GroupBox_ThaoTacLop = new System.Windows.Forms.GroupBox();
            this.ComboBox_KhoiLop = new System.Windows.Forms.ComboBox();
            this.Button_XoaLop = new System.Windows.Forms.Button();
            this.Button_SuaLop = new System.Windows.Forms.Button();
            this.TextBox_TenLop = new System.Windows.Forms.TextBox();
            this.Label_KhoiLop = new System.Windows.Forms.Label();
            this.Label_TenLop = new System.Windows.Forms.Label();
            this.Button_ThemLop = new System.Windows.Forms.Button();
            this.GroupBox_ThaoTacMonHoc = new System.Windows.Forms.GroupBox();
            this.TextBox_TenMonHoc = new System.Windows.Forms.TextBox();
            this.Button_XoaMon = new System.Windows.Forms.Button();
            this.Label_TenMonHoc = new System.Windows.Forms.Label();
            this.Button_ThemMon = new System.Windows.Forms.Button();
            this.Button_SuaMon = new System.Windows.Forms.Button();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhoiLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel_Title.SuspendLayout();
            this.GroupBox_ThayDoiQD.SuspendLayout();
            this.GroupBox_DSMonHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_DSMonHoc)).BeginInit();
            this.GroupBox_DSLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_DSLop)).BeginInit();
            this.GroupBox_ThaoTacLop.SuspendLayout();
            this.GroupBox_ThaoTacMonHoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Title
            // 
            this.Panel_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Panel_Title.Controls.Add(this.Label_Title);
            this.Panel_Title.Location = new System.Drawing.Point(154, 12);
            this.Panel_Title.Name = "Panel_Title";
            this.Panel_Title.Size = new System.Drawing.Size(497, 50);
            this.Panel_Title.TabIndex = 3;
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Title.Location = new System.Drawing.Point(185, 10);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(143, 29);
            this.Label_Title.TabIndex = 0;
            this.Label_Title.Text = "THIẾT LẬP";
            // 
            // GroupBox_ThayDoiQD
            // 
            this.GroupBox_ThayDoiQD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_ThayDoiQD.Controls.Add(this.TextBox_DiemDatMon);
            this.GroupBox_ThayDoiQD.Controls.Add(this.Label_DiemDatMon);
            this.GroupBox_ThayDoiQD.Controls.Add(this.Button_Luu);
            this.GroupBox_ThayDoiQD.Controls.Add(this.Label_2);
            this.GroupBox_ThayDoiQD.Controls.Add(this.TextBox_DiemMax);
            this.GroupBox_ThayDoiQD.Controls.Add(this.TextBox_DiemMin);
            this.GroupBox_ThayDoiQD.Controls.Add(this.TextBox_DiemDat);
            this.GroupBox_ThayDoiQD.Controls.Add(this.Label_DiemDat);
            this.GroupBox_ThayDoiQD.Controls.Add(this.Label_KhoangDiem);
            this.GroupBox_ThayDoiQD.Controls.Add(this.TextBox_SiSoMax);
            this.GroupBox_ThayDoiQD.Controls.Add(this.Label_SiSoMax);
            this.GroupBox_ThayDoiQD.Controls.Add(this.Label_1);
            this.GroupBox_ThayDoiQD.Controls.Add(this.TextBox_TuoiMax);
            this.GroupBox_ThayDoiQD.Controls.Add(this.TextBox_TuoiMin);
            this.GroupBox_ThayDoiQD.Controls.Add(this.Label_Tuoi);
            this.GroupBox_ThayDoiQD.Location = new System.Drawing.Point(548, 69);
            this.GroupBox_ThayDoiQD.Name = "GroupBox_ThayDoiQD";
            this.GroupBox_ThayDoiQD.Size = new System.Drawing.Size(240, 172);
            this.GroupBox_ThayDoiQD.TabIndex = 4;
            this.GroupBox_ThayDoiQD.TabStop = false;
            this.GroupBox_ThayDoiQD.Text = "Thay đổi quy định";
            // 
            // TextBox_DiemDatMon
            // 
            this.TextBox_DiemDatMon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_DiemDatMon.Location = new System.Drawing.Point(87, 116);
            this.TextBox_DiemDatMon.Name = "TextBox_DiemDatMon";
            this.TextBox_DiemDatMon.Size = new System.Drawing.Size(142, 20);
            this.TextBox_DiemDatMon.TabIndex = 20;
            // 
            // Label_DiemDatMon
            // 
            this.Label_DiemDatMon.AutoSize = true;
            this.Label_DiemDatMon.Location = new System.Drawing.Point(7, 118);
            this.Label_DiemDatMon.Name = "Label_DiemDatMon";
            this.Label_DiemDatMon.Size = new System.Drawing.Size(76, 13);
            this.Label_DiemDatMon.TabIndex = 19;
            this.Label_DiemDatMon.Text = "Điểm đạt môn:";
            // 
            // Button_Luu
            // 
            this.Button_Luu.BackColor = System.Drawing.Color.RoyalBlue;
            this.Button_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Luu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_Luu.Location = new System.Drawing.Point(87, 142);
            this.Button_Luu.Name = "Button_Luu";
            this.Button_Luu.Size = new System.Drawing.Size(75, 23);
            this.Button_Luu.TabIndex = 18;
            this.Button_Luu.Text = "Lưu";
            this.Button_Luu.UseVisualStyleBackColor = false;
            this.Button_Luu.Click += new System.EventHandler(this.Button_Luu_Click);
            // 
            // Label_2
            // 
            this.Label_2.AutoSize = true;
            this.Label_2.Location = new System.Drawing.Point(152, 70);
            this.Label_2.Name = "Label_2";
            this.Label_2.Size = new System.Drawing.Size(10, 13);
            this.Label_2.TabIndex = 12;
            this.Label_2.Text = "-";
            // 
            // TextBox_DiemMax
            // 
            this.TextBox_DiemMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_DiemMax.Location = new System.Drawing.Point(179, 67);
            this.TextBox_DiemMax.Name = "TextBox_DiemMax";
            this.TextBox_DiemMax.Size = new System.Drawing.Size(49, 20);
            this.TextBox_DiemMax.TabIndex = 11;
            // 
            // TextBox_DiemMin
            // 
            this.TextBox_DiemMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_DiemMin.Location = new System.Drawing.Point(86, 67);
            this.TextBox_DiemMin.Name = "TextBox_DiemMin";
            this.TextBox_DiemMin.Size = new System.Drawing.Size(49, 20);
            this.TextBox_DiemMin.TabIndex = 10;
            // 
            // TextBox_DiemDat
            // 
            this.TextBox_DiemDat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_DiemDat.Location = new System.Drawing.Point(86, 92);
            this.TextBox_DiemDat.Name = "TextBox_DiemDat";
            this.TextBox_DiemDat.Size = new System.Drawing.Size(142, 20);
            this.TextBox_DiemDat.TabIndex = 9;
            // 
            // Label_DiemDat
            // 
            this.Label_DiemDat.AutoSize = true;
            this.Label_DiemDat.Location = new System.Drawing.Point(6, 94);
            this.Label_DiemDat.Name = "Label_DiemDat";
            this.Label_DiemDat.Size = new System.Drawing.Size(53, 13);
            this.Label_DiemDat.TabIndex = 8;
            this.Label_DiemDat.Text = "Điểm đạt:";
            // 
            // Label_KhoangDiem
            // 
            this.Label_KhoangDiem.AutoSize = true;
            this.Label_KhoangDiem.Location = new System.Drawing.Point(6, 70);
            this.Label_KhoangDiem.Name = "Label_KhoangDiem";
            this.Label_KhoangDiem.Size = new System.Drawing.Size(73, 13);
            this.Label_KhoangDiem.TabIndex = 6;
            this.Label_KhoangDiem.Text = "Khoảng điểm:";
            // 
            // TextBox_SiSoMax
            // 
            this.TextBox_SiSoMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_SiSoMax.Location = new System.Drawing.Point(86, 44);
            this.TextBox_SiSoMax.Name = "TextBox_SiSoMax";
            this.TextBox_SiSoMax.Size = new System.Drawing.Size(142, 20);
            this.TextBox_SiSoMax.TabIndex = 5;
            // 
            // Label_SiSoMax
            // 
            this.Label_SiSoMax.AutoSize = true;
            this.Label_SiSoMax.Location = new System.Drawing.Point(6, 47);
            this.Label_SiSoMax.Name = "Label_SiSoMax";
            this.Label_SiSoMax.Size = new System.Drawing.Size(66, 13);
            this.Label_SiSoMax.TabIndex = 4;
            this.Label_SiSoMax.Text = "Sĩ số tối đa:";
            // 
            // Label_1
            // 
            this.Label_1.AutoSize = true;
            this.Label_1.Location = new System.Drawing.Point(152, 22);
            this.Label_1.Name = "Label_1";
            this.Label_1.Size = new System.Drawing.Size(10, 13);
            this.Label_1.TabIndex = 3;
            this.Label_1.Text = "-";
            // 
            // TextBox_TuoiMax
            // 
            this.TextBox_TuoiMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_TuoiMax.Location = new System.Drawing.Point(179, 19);
            this.TextBox_TuoiMax.Name = "TextBox_TuoiMax";
            this.TextBox_TuoiMax.Size = new System.Drawing.Size(49, 20);
            this.TextBox_TuoiMax.TabIndex = 2;
            // 
            // TextBox_TuoiMin
            // 
            this.TextBox_TuoiMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_TuoiMin.Location = new System.Drawing.Point(86, 19);
            this.TextBox_TuoiMin.Name = "TextBox_TuoiMin";
            this.TextBox_TuoiMin.Size = new System.Drawing.Size(49, 20);
            this.TextBox_TuoiMin.TabIndex = 1;
            // 
            // Label_Tuoi
            // 
            this.Label_Tuoi.AutoSize = true;
            this.Label_Tuoi.Location = new System.Drawing.Point(6, 22);
            this.Label_Tuoi.Name = "Label_Tuoi";
            this.Label_Tuoi.Size = new System.Drawing.Size(74, 13);
            this.Label_Tuoi.TabIndex = 0;
            this.Label_Tuoi.Text = "Tuổi học sinh:";
            // 
            // GroupBox_DSMonHoc
            // 
            this.GroupBox_DSMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_DSMonHoc.Controls.Add(this.GridView_DSMonHoc);
            this.GroupBox_DSMonHoc.Location = new System.Drawing.Point(6, 292);
            this.GroupBox_DSMonHoc.Name = "GroupBox_DSMonHoc";
            this.GroupBox_DSMonHoc.Size = new System.Drawing.Size(536, 141);
            this.GroupBox_DSMonHoc.TabIndex = 5;
            this.GroupBox_DSMonHoc.TabStop = false;
            this.GroupBox_DSMonHoc.Text = "Danh sách môn học";
            // 
            // GridView_DSMonHoc
            // 
            this.GridView_DSMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridView_DSMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_DSMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMonHoc,
            this.TenMonHoc});
            this.GridView_DSMonHoc.Location = new System.Drawing.Point(6, 19);
            this.GridView_DSMonHoc.Name = "GridView_DSMonHoc";
            this.GridView_DSMonHoc.RowHeadersWidth = 62;
            this.GridView_DSMonHoc.Size = new System.Drawing.Size(524, 116);
            this.GridView_DSMonHoc.TabIndex = 6;
            // 
            // GroupBox_DSLop
            // 
            this.GroupBox_DSLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_DSLop.Controls.Add(this.GridView_DSLop);
            this.GroupBox_DSLop.Location = new System.Drawing.Point(6, 69);
            this.GroupBox_DSLop.Name = "GroupBox_DSLop";
            this.GroupBox_DSLop.Size = new System.Drawing.Size(536, 217);
            this.GroupBox_DSLop.TabIndex = 7;
            this.GroupBox_DSLop.TabStop = false;
            this.GroupBox_DSLop.Text = "Danh sách lớp";
            // 
            // GridView_DSLop
            // 
            this.GridView_DSLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridView_DSLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_DSLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLop,
            this.TenLop,
            this.SiSo,
            this.MaKhoiLop});
            this.GridView_DSLop.Location = new System.Drawing.Point(6, 19);
            this.GridView_DSLop.Name = "GridView_DSLop";
            this.GridView_DSLop.RowHeadersWidth = 62;
            this.GridView_DSLop.Size = new System.Drawing.Size(524, 192);
            this.GridView_DSLop.TabIndex = 6;
            // 
            // GroupBox_ThaoTacLop
            // 
            this.GroupBox_ThaoTacLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_ThaoTacLop.Controls.Add(this.ComboBox_KhoiLop);
            this.GroupBox_ThaoTacLop.Controls.Add(this.Button_XoaLop);
            this.GroupBox_ThaoTacLop.Controls.Add(this.Button_SuaLop);
            this.GroupBox_ThaoTacLop.Controls.Add(this.TextBox_TenLop);
            this.GroupBox_ThaoTacLop.Controls.Add(this.Label_KhoiLop);
            this.GroupBox_ThaoTacLop.Controls.Add(this.Label_TenLop);
            this.GroupBox_ThaoTacLop.Controls.Add(this.Button_ThemLop);
            this.GroupBox_ThaoTacLop.Location = new System.Drawing.Point(548, 247);
            this.GroupBox_ThaoTacLop.Name = "GroupBox_ThaoTacLop";
            this.GroupBox_ThaoTacLop.Size = new System.Drawing.Size(240, 100);
            this.GroupBox_ThaoTacLop.TabIndex = 8;
            this.GroupBox_ThaoTacLop.TabStop = false;
            this.GroupBox_ThaoTacLop.Text = "Thao tác lớp";
            // 
            // ComboBox_KhoiLop
            // 
            this.ComboBox_KhoiLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_KhoiLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_KhoiLop.FormattingEnabled = true;
            this.ComboBox_KhoiLop.Location = new System.Drawing.Point(86, 42);
            this.ComboBox_KhoiLop.Name = "ComboBox_KhoiLop";
            this.ComboBox_KhoiLop.Size = new System.Drawing.Size(142, 21);
            this.ComboBox_KhoiLop.TabIndex = 18;
            // 
            // Button_XoaLop
            // 
            this.Button_XoaLop.BackColor = System.Drawing.Color.RoyalBlue;
            this.Button_XoaLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_XoaLop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_XoaLop.Location = new System.Drawing.Point(160, 68);
            this.Button_XoaLop.Name = "Button_XoaLop";
            this.Button_XoaLop.Size = new System.Drawing.Size(75, 23);
            this.Button_XoaLop.TabIndex = 17;
            this.Button_XoaLop.Text = "Xóa";
            this.Button_XoaLop.UseVisualStyleBackColor = false;
            this.Button_XoaLop.Click += new System.EventHandler(this.Button_XoaLop_Click);
            // 
            // Button_SuaLop
            // 
            this.Button_SuaLop.BackColor = System.Drawing.Color.RoyalBlue;
            this.Button_SuaLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_SuaLop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_SuaLop.Location = new System.Drawing.Point(83, 68);
            this.Button_SuaLop.Name = "Button_SuaLop";
            this.Button_SuaLop.Size = new System.Drawing.Size(75, 23);
            this.Button_SuaLop.TabIndex = 16;
            this.Button_SuaLop.Text = "Chỉnh sửa";
            this.Button_SuaLop.UseVisualStyleBackColor = false;
            this.Button_SuaLop.Click += new System.EventHandler(this.Button_SuaLop_Click);
            // 
            // TextBox_TenLop
            // 
            this.TextBox_TenLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_TenLop.Location = new System.Drawing.Point(86, 19);
            this.TextBox_TenLop.Name = "TextBox_TenLop";
            this.TextBox_TenLop.Size = new System.Drawing.Size(142, 20);
            this.TextBox_TenLop.TabIndex = 12;
            // 
            // Label_KhoiLop
            // 
            this.Label_KhoiLop.AutoSize = true;
            this.Label_KhoiLop.Location = new System.Drawing.Point(6, 45);
            this.Label_KhoiLop.Name = "Label_KhoiLop";
            this.Label_KhoiLop.Size = new System.Drawing.Size(48, 13);
            this.Label_KhoiLop.TabIndex = 9;
            this.Label_KhoiLop.Text = "Khối lớp:";
            // 
            // Label_TenLop
            // 
            this.Label_TenLop.AutoSize = true;
            this.Label_TenLop.Location = new System.Drawing.Point(6, 22);
            this.Label_TenLop.Name = "Label_TenLop";
            this.Label_TenLop.Size = new System.Drawing.Size(46, 13);
            this.Label_TenLop.TabIndex = 8;
            this.Label_TenLop.Text = "Tên lớp:";
            // 
            // Button_ThemLop
            // 
            this.Button_ThemLop.BackColor = System.Drawing.Color.RoyalBlue;
            this.Button_ThemLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ThemLop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_ThemLop.Location = new System.Drawing.Point(6, 68);
            this.Button_ThemLop.Name = "Button_ThemLop";
            this.Button_ThemLop.Size = new System.Drawing.Size(75, 23);
            this.Button_ThemLop.TabIndex = 0;
            this.Button_ThemLop.Text = "Thêm";
            this.Button_ThemLop.UseVisualStyleBackColor = false;
            this.Button_ThemLop.Click += new System.EventHandler(this.Button_ThemLop_Click);
            // 
            // GroupBox_ThaoTacMonHoc
            // 
            this.GroupBox_ThaoTacMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_ThaoTacMonHoc.Controls.Add(this.TextBox_TenMonHoc);
            this.GroupBox_ThaoTacMonHoc.Controls.Add(this.Button_XoaMon);
            this.GroupBox_ThaoTacMonHoc.Controls.Add(this.Label_TenMonHoc);
            this.GroupBox_ThaoTacMonHoc.Controls.Add(this.Button_ThemMon);
            this.GroupBox_ThaoTacMonHoc.Controls.Add(this.Button_SuaMon);
            this.GroupBox_ThaoTacMonHoc.Location = new System.Drawing.Point(548, 353);
            this.GroupBox_ThaoTacMonHoc.Name = "GroupBox_ThaoTacMonHoc";
            this.GroupBox_ThaoTacMonHoc.Size = new System.Drawing.Size(240, 80);
            this.GroupBox_ThaoTacMonHoc.TabIndex = 9;
            this.GroupBox_ThaoTacMonHoc.TabStop = false;
            this.GroupBox_ThaoTacMonHoc.Text = "Thao tác môn học";
            // 
            // TextBox_TenMonHoc
            // 
            this.TextBox_TenMonHoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_TenMonHoc.Location = new System.Drawing.Point(86, 22);
            this.TextBox_TenMonHoc.Name = "TextBox_TenMonHoc";
            this.TextBox_TenMonHoc.Size = new System.Drawing.Size(142, 20);
            this.TextBox_TenMonHoc.TabIndex = 19;
            // 
            // Button_XoaMon
            // 
            this.Button_XoaMon.BackColor = System.Drawing.Color.RoyalBlue;
            this.Button_XoaMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_XoaMon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_XoaMon.Location = new System.Drawing.Point(161, 48);
            this.Button_XoaMon.Name = "Button_XoaMon";
            this.Button_XoaMon.Size = new System.Drawing.Size(75, 23);
            this.Button_XoaMon.TabIndex = 20;
            this.Button_XoaMon.Text = "Xóa";
            this.Button_XoaMon.UseVisualStyleBackColor = false;
            this.Button_XoaMon.Click += new System.EventHandler(this.Button_XoaMon_Click);
            // 
            // Label_TenMonHoc
            // 
            this.Label_TenMonHoc.AutoSize = true;
            this.Label_TenMonHoc.Location = new System.Drawing.Point(6, 25);
            this.Label_TenMonHoc.Name = "Label_TenMonHoc";
            this.Label_TenMonHoc.Size = new System.Drawing.Size(73, 13);
            this.Label_TenMonHoc.TabIndex = 18;
            this.Label_TenMonHoc.Text = "Tên môn học:";
            // 
            // Button_ThemMon
            // 
            this.Button_ThemMon.BackColor = System.Drawing.Color.RoyalBlue;
            this.Button_ThemMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ThemMon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_ThemMon.Location = new System.Drawing.Point(7, 48);
            this.Button_ThemMon.Name = "Button_ThemMon";
            this.Button_ThemMon.Size = new System.Drawing.Size(75, 23);
            this.Button_ThemMon.TabIndex = 18;
            this.Button_ThemMon.Text = "Thêm";
            this.Button_ThemMon.UseVisualStyleBackColor = false;
            this.Button_ThemMon.Click += new System.EventHandler(this.Button_ThemMon_Click);
            // 
            // Button_SuaMon
            // 
            this.Button_SuaMon.BackColor = System.Drawing.Color.RoyalBlue;
            this.Button_SuaMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_SuaMon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_SuaMon.Location = new System.Drawing.Point(84, 48);
            this.Button_SuaMon.Name = "Button_SuaMon";
            this.Button_SuaMon.Size = new System.Drawing.Size(75, 23);
            this.Button_SuaMon.TabIndex = 19;
            this.Button_SuaMon.Text = "Chỉnh sửa";
            this.Button_SuaMon.UseVisualStyleBackColor = false;
            this.Button_SuaMon.Click += new System.EventHandler(this.Button_SuaMon_Click);
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã Lớp";
            this.MaLop.MinimumWidth = 8;
            this.MaLop.Name = "MaLop";
            this.MaLop.ReadOnly = true;
            this.MaLop.Visible = false;
            this.MaLop.Width = 150;
            // 
            // TenLop
            // 
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.HeaderText = "Tên Lớp";
            this.TenLop.MinimumWidth = 8;
            this.TenLop.Name = "TenLop";
            this.TenLop.ReadOnly = true;
            this.TenLop.Width = 150;
            // 
            // SiSo
            // 
            this.SiSo.DataPropertyName = "SiSo";
            this.SiSo.HeaderText = "Sĩ Số";
            this.SiSo.MinimumWidth = 8;
            this.SiSo.Name = "SiSo";
            this.SiSo.ReadOnly = true;
            this.SiSo.Visible = false;
            this.SiSo.Width = 150;
            // 
            // MaKhoiLop
            // 
            this.MaKhoiLop.DataPropertyName = "MaKhoiLop";
            this.MaKhoiLop.HeaderText = "Mã Khối Lớp";
            this.MaKhoiLop.MinimumWidth = 8;
            this.MaKhoiLop.Name = "MaKhoiLop";
            this.MaKhoiLop.ReadOnly = true;
            this.MaKhoiLop.Visible = false;
            this.MaKhoiLop.Width = 150;
            // 
            // MaMonHoc
            // 
            this.MaMonHoc.DataPropertyName = "MaMonHoc";
            this.MaMonHoc.HeaderText = "Mã Môn Học";
            this.MaMonHoc.MinimumWidth = 8;
            this.MaMonHoc.Name = "MaMonHoc";
            this.MaMonHoc.ReadOnly = true;
            this.MaMonHoc.Visible = false;
            this.MaMonHoc.Width = 150;
            // 
            // TenMonHoc
            // 
            this.TenMonHoc.DataPropertyName = "TenMonHoc";
            this.TenMonHoc.HeaderText = "Tên Môn Học";
            this.TenMonHoc.MinimumWidth = 8;
            this.TenMonHoc.Name = "TenMonHoc";
            this.TenMonHoc.ReadOnly = true;
            this.TenMonHoc.Width = 150;
            // 
            // Form_ThietLap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(796, 440);
            this.Controls.Add(this.GroupBox_ThaoTacMonHoc);
            this.Controls.Add(this.GroupBox_ThaoTacLop);
            this.Controls.Add(this.GroupBox_DSLop);
            this.Controls.Add(this.GroupBox_DSMonHoc);
            this.Controls.Add(this.GroupBox_ThayDoiQD);
            this.Controls.Add(this.Panel_Title);
            this.Name = "Form_ThietLap";
            this.Text = "Thiết lập";
            this.Panel_Title.ResumeLayout(false);
            this.Panel_Title.PerformLayout();
            this.GroupBox_ThayDoiQD.ResumeLayout(false);
            this.GroupBox_ThayDoiQD.PerformLayout();
            this.GroupBox_DSMonHoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_DSMonHoc)).EndInit();
            this.GroupBox_DSLop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_DSLop)).EndInit();
            this.GroupBox_ThaoTacLop.ResumeLayout(false);
            this.GroupBox_ThaoTacLop.PerformLayout();
            this.GroupBox_ThaoTacMonHoc.ResumeLayout(false);
            this.GroupBox_ThaoTacMonHoc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Title;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.GroupBox GroupBox_ThayDoiQD;
        private System.Windows.Forms.Label Label_KhoangDiem;
        private System.Windows.Forms.TextBox TextBox_SiSoMax;
        private System.Windows.Forms.Label Label_SiSoMax;
        private System.Windows.Forms.Label Label_1;
        private System.Windows.Forms.TextBox TextBox_TuoiMax;
        private System.Windows.Forms.TextBox TextBox_TuoiMin;
        private System.Windows.Forms.Label Label_Tuoi;
        private System.Windows.Forms.GroupBox GroupBox_DSMonHoc;
        private System.Windows.Forms.DataGridView GridView_DSMonHoc;
        private System.Windows.Forms.GroupBox GroupBox_DSLop;
        private System.Windows.Forms.DataGridView GridView_DSLop;
        private System.Windows.Forms.GroupBox GroupBox_ThaoTacLop;
        private System.Windows.Forms.Button Button_ThemLop;
        private System.Windows.Forms.Button Button_XoaLop;
        private System.Windows.Forms.Button Button_SuaLop;
        private System.Windows.Forms.TextBox TextBox_TenLop;
        private System.Windows.Forms.Label Label_KhoiLop;
        private System.Windows.Forms.Label Label_TenLop;
        private System.Windows.Forms.GroupBox GroupBox_ThaoTacMonHoc;
        private System.Windows.Forms.Button Button_XoaMon;
        private System.Windows.Forms.Button Button_ThemMon;
        private System.Windows.Forms.Button Button_SuaMon;
        private System.Windows.Forms.TextBox TextBox_TenMonHoc;
        private System.Windows.Forms.Label Label_TenMonHoc;
        private System.Windows.Forms.Button Button_Luu;
        private System.Windows.Forms.Label Label_2;
        private System.Windows.Forms.TextBox TextBox_DiemMax;
        private System.Windows.Forms.TextBox TextBox_DiemMin;
        private System.Windows.Forms.TextBox TextBox_DiemDat;
        private System.Windows.Forms.Label Label_DiemDat;
        private System.Windows.Forms.ComboBox ComboBox_KhoiLop;
        private System.Windows.Forms.TextBox TextBox_DiemDatMon;
        private System.Windows.Forms.Label Label_DiemDatMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoiLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonHoc;
    }
}