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
            this.ComboBox_HocKy = new System.Windows.Forms.ComboBox();
            this.Label_MonHoc = new System.Windows.Forms.Label();
            this.Label_HocKy = new System.Windows.Forms.Label();
            this.Label_Lop = new System.Windows.Forms.Label();
            this.GroupBox_BangDiem = new System.Windows.Forms.GroupBox();
            this.Button_Luu = new System.Windows.Forms.Button();
            this.GridView_BangDiem = new System.Windows.Forms.DataGridView();
            this.Button_Close = new System.Windows.Forms.Button();
            this.ComboBox_NamHoc = new System.Windows.Forms.ComboBox();
            this.Label_NamHoc = new System.Windows.Forms.Label();
            this.Panel_Title.SuspendLayout();
            this.GroupBox_BoLoc.SuspendLayout();
            this.GroupBox_BangDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_BangDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Title
            // 
            this.Panel_Title.Controls.Add(this.Label_Title);
            this.Panel_Title.Location = new System.Drawing.Point(139, 12);
            this.Panel_Title.Name = "Panel_Title";
            this.Panel_Title.Size = new System.Drawing.Size(497, 50);
            this.Panel_Title.TabIndex = 2;
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Title.Location = new System.Drawing.Point(116, 9);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(284, 29);
            this.Label_Title.TabIndex = 0;
            this.Label_Title.Text = "BẢNG ĐIỂM MÔN HỌC";
            // 
            // GroupBox_BoLoc
            // 
            this.GroupBox_BoLoc.Controls.Add(this.ComboBox_NamHoc);
            this.GroupBox_BoLoc.Controls.Add(this.Label_NamHoc);
            this.GroupBox_BoLoc.Controls.Add(this.ComboBox_MonHoc);
            this.GroupBox_BoLoc.Controls.Add(this.ComboBox_Lop);
            this.GroupBox_BoLoc.Controls.Add(this.ComboBox_HocKy);
            this.GroupBox_BoLoc.Controls.Add(this.Label_MonHoc);
            this.GroupBox_BoLoc.Controls.Add(this.Label_HocKy);
            this.GroupBox_BoLoc.Controls.Add(this.Label_Lop);
            this.GroupBox_BoLoc.Location = new System.Drawing.Point(12, 68);
            this.GroupBox_BoLoc.Name = "GroupBox_BoLoc";
            this.GroupBox_BoLoc.Size = new System.Drawing.Size(739, 50);
            this.GroupBox_BoLoc.TabIndex = 8;
            this.GroupBox_BoLoc.TabStop = false;
            this.GroupBox_BoLoc.Text = "Bộ lọc";
            // 
            // ComboBox_MonHoc
            // 
            this.ComboBox_MonHoc.FormattingEnabled = true;
            this.ComboBox_MonHoc.Location = new System.Drawing.Point(588, 17);
            this.ComboBox_MonHoc.Name = "ComboBox_MonHoc";
            this.ComboBox_MonHoc.Size = new System.Drawing.Size(145, 21);
            this.ComboBox_MonHoc.TabIndex = 5;
            // 
            // ComboBox_Lop
            // 
            this.ComboBox_Lop.FormattingEnabled = true;
            this.ComboBox_Lop.Location = new System.Drawing.Point(414, 17);
            this.ComboBox_Lop.Name = "ComboBox_Lop";
            this.ComboBox_Lop.Size = new System.Drawing.Size(110, 21);
            this.ComboBox_Lop.TabIndex = 4;
            // 
            // ComboBox_HocKy
            // 
            this.ComboBox_HocKy.FormattingEnabled = true;
            this.ComboBox_HocKy.Location = new System.Drawing.Point(57, 17);
            this.ComboBox_HocKy.Name = "ComboBox_HocKy";
            this.ComboBox_HocKy.Size = new System.Drawing.Size(111, 21);
            this.ComboBox_HocKy.TabIndex = 3;
            // 
            // Label_MonHoc
            // 
            this.Label_MonHoc.AutoSize = true;
            this.Label_MonHoc.Location = new System.Drawing.Point(530, 20);
            this.Label_MonHoc.Name = "Label_MonHoc";
            this.Label_MonHoc.Size = new System.Drawing.Size(52, 13);
            this.Label_MonHoc.TabIndex = 2;
            this.Label_MonHoc.Text = "Môn học:";
            // 
            // Label_HocKy
            // 
            this.Label_HocKy.AutoSize = true;
            this.Label_HocKy.Location = new System.Drawing.Point(7, 20);
            this.Label_HocKy.Name = "Label_HocKy";
            this.Label_HocKy.Size = new System.Drawing.Size(44, 13);
            this.Label_HocKy.TabIndex = 1;
            this.Label_HocKy.Text = "Học kỳ:";
            // 
            // Label_Lop
            // 
            this.Label_Lop.AutoSize = true;
            this.Label_Lop.Location = new System.Drawing.Point(380, 20);
            this.Label_Lop.Name = "Label_Lop";
            this.Label_Lop.Size = new System.Drawing.Size(28, 13);
            this.Label_Lop.TabIndex = 0;
            this.Label_Lop.Text = "Lớp:";
            // 
            // GroupBox_BangDiem
            // 
            this.GroupBox_BangDiem.Controls.Add(this.Button_Luu);
            this.GroupBox_BangDiem.Controls.Add(this.GridView_BangDiem);
            this.GroupBox_BangDiem.Location = new System.Drawing.Point(12, 124);
            this.GroupBox_BangDiem.Name = "GroupBox_BangDiem";
            this.GroupBox_BangDiem.Size = new System.Drawing.Size(739, 296);
            this.GroupBox_BangDiem.TabIndex = 9;
            this.GroupBox_BangDiem.TabStop = false;
            this.GroupBox_BangDiem.Text = "Bảng điểm";
            // 
            // Button_Luu
            // 
            this.Button_Luu.Location = new System.Drawing.Point(313, 252);
            this.Button_Luu.Name = "Button_Luu";
            this.Button_Luu.Size = new System.Drawing.Size(117, 38);
            this.Button_Luu.TabIndex = 1;
            this.Button_Luu.Text = "Lưu các thay đổi";
            this.Button_Luu.UseVisualStyleBackColor = true;
            // 
            // GridView_BangDiem
            // 
            this.GridView_BangDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_BangDiem.Location = new System.Drawing.Point(6, 19);
            this.GridView_BangDiem.Name = "GridView_BangDiem";
            this.GridView_BangDiem.Size = new System.Drawing.Size(727, 227);
            this.GridView_BangDiem.TabIndex = 0;
            // 
            // Button_Close
            // 
            this.Button_Close.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.ExitButton;
            this.Button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Close.Cursor = System.Windows.Forms.Cursors.Default;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Close.Location = new System.Drawing.Point(698, 12);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(53, 50);
            this.Button_Close.TabIndex = 6;
            this.Button_Close.UseVisualStyleBackColor = true;
            // 
            // ComboBox_NamHoc
            // 
            this.ComboBox_NamHoc.FormattingEnabled = true;
            this.ComboBox_NamHoc.Location = new System.Drawing.Point(233, 17);
            this.ComboBox_NamHoc.Name = "ComboBox_NamHoc";
            this.ComboBox_NamHoc.Size = new System.Drawing.Size(141, 21);
            this.ComboBox_NamHoc.TabIndex = 7;
            // 
            // Label_NamHoc
            // 
            this.Label_NamHoc.AutoSize = true;
            this.Label_NamHoc.Location = new System.Drawing.Point(174, 20);
            this.Label_NamHoc.Name = "Label_NamHoc";
            this.Label_NamHoc.Size = new System.Drawing.Size(53, 13);
            this.Label_NamHoc.TabIndex = 6;
            this.Label_NamHoc.Text = "Năm học:";
            // 
            // Form_BangDiemMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 432);
            this.Controls.Add(this.GroupBox_BangDiem);
            this.Controls.Add(this.GroupBox_BoLoc);
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.Panel_Title);
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
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.GroupBox GroupBox_BoLoc;
        private System.Windows.Forms.ComboBox ComboBox_MonHoc;
        private System.Windows.Forms.ComboBox ComboBox_Lop;
        private System.Windows.Forms.ComboBox ComboBox_HocKy;
        private System.Windows.Forms.Label Label_MonHoc;
        private System.Windows.Forms.Label Label_HocKy;
        private System.Windows.Forms.Label Label_Lop;
        private System.Windows.Forms.GroupBox GroupBox_BangDiem;
        private System.Windows.Forms.DataGridView GridView_BangDiem;
        private System.Windows.Forms.Button Button_Luu;
        private System.Windows.Forms.ComboBox ComboBox_NamHoc;
        private System.Windows.Forms.Label Label_NamHoc;
    }
}