namespace QuanLyHocSinh
{
    partial class Form_TiepNhanHS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TiepNhanHS));
            this.Panel_Title = new System.Windows.Forms.Panel();
            this.Label_Title = new System.Windows.Forms.Label();
            this.GroupBox_ThongTin = new System.Windows.Forms.GroupBox();
            this.TextBox_Email = new System.Windows.Forms.TextBox();
            this.Label_Email = new System.Windows.Forms.Label();
            this.TextBox_DiaChi = new System.Windows.Forms.TextBox();
            this.Label_DiaChi = new System.Windows.Forms.Label();
            this.DateTimePicker_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.Label_NgaySinh = new System.Windows.Forms.Label();
            this.RadioButton_Nu = new System.Windows.Forms.RadioButton();
            this.RadioButton_Nam = new System.Windows.Forms.RadioButton();
            this.Label_GioiTinh = new System.Windows.Forms.Label();
            this.TextBox_HoTen = new System.Windows.Forms.TextBox();
            this.Label_HoTen = new System.Windows.Forms.Label();
            this.GroupBox_DSHocSinh = new System.Windows.Forms.GroupBox();
            this.GridView_DSHocSinh = new System.Windows.Forms.DataGridView();
            this.GroupBox_ThaoTac = new System.Windows.Forms.GroupBox();
            this.Button_Sua = new System.Windows.Forms.Button();
            this.Button_Xoa = new System.Windows.Forms.Button();
            this.Button_Them = new System.Windows.Forms.Button();
            this.Button_Close = new System.Windows.Forms.Button();
            this.errorProvider_HoTen = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkedProvider_HoTen = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_NgaySinh = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkedProvider_NgaySinh = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_DiaChi = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkedProvider_DiaChi = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_Email = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkedProvider_Email = new System.Windows.Forms.ErrorProvider(this.components);
            this.Panel_Title.SuspendLayout();
            this.GroupBox_ThongTin.SuspendLayout();
            this.GroupBox_DSHocSinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_DSHocSinh)).BeginInit();
            this.GroupBox_ThaoTac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_HoTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedProvider_HoTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_NgaySinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedProvider_NgaySinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_DiaChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedProvider_DiaChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedProvider_Email)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Title
            // 
            this.Panel_Title.Controls.Add(this.Label_Title);
            this.Panel_Title.Location = new System.Drawing.Point(88, 18);
            this.Panel_Title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel_Title.Name = "Panel_Title";
            this.Panel_Title.Size = new System.Drawing.Size(746, 77);
            this.Panel_Title.TabIndex = 0;
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Title.Location = new System.Drawing.Point(176, 15);
            this.Label_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(411, 40);
            this.Label_Title.TabIndex = 0;
            this.Label_Title.Text = "TIẾP NHẬN HỌC SINH";
            // 
            // GroupBox_ThongTin
            // 
            this.GroupBox_ThongTin.Controls.Add(this.TextBox_Email);
            this.GroupBox_ThongTin.Controls.Add(this.Label_Email);
            this.GroupBox_ThongTin.Controls.Add(this.TextBox_DiaChi);
            this.GroupBox_ThongTin.Controls.Add(this.Label_DiaChi);
            this.GroupBox_ThongTin.Controls.Add(this.DateTimePicker_NgaySinh);
            this.GroupBox_ThongTin.Controls.Add(this.Label_NgaySinh);
            this.GroupBox_ThongTin.Controls.Add(this.RadioButton_Nu);
            this.GroupBox_ThongTin.Controls.Add(this.RadioButton_Nam);
            this.GroupBox_ThongTin.Controls.Add(this.Label_GioiTinh);
            this.GroupBox_ThongTin.Controls.Add(this.TextBox_HoTen);
            this.GroupBox_ThongTin.Controls.Add(this.Label_HoTen);
            this.GroupBox_ThongTin.Location = new System.Drawing.Point(18, 105);
            this.GroupBox_ThongTin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox_ThongTin.Name = "GroupBox_ThongTin";
            this.GroupBox_ThongTin.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox_ThongTin.Size = new System.Drawing.Size(812, 209);
            this.GroupBox_ThongTin.TabIndex = 1;
            this.GroupBox_ThongTin.TabStop = false;
            this.GroupBox_ThongTin.Text = "Thông tin cá nhân";
            // 
            // TextBox_Email
            // 
            this.TextBox_Email.Location = new System.Drawing.Point(126, 162);
            this.TextBox_Email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_Email.Name = "TextBox_Email";
            this.TextBox_Email.Size = new System.Drawing.Size(586, 26);
            this.TextBox_Email.TabIndex = 10;
            // 
            // Label_Email
            // 
            this.Label_Email.AutoSize = true;
            this.Label_Email.Location = new System.Drawing.Point(9, 166);
            this.Label_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Email.Name = "Label_Email";
            this.Label_Email.Size = new System.Drawing.Size(52, 20);
            this.Label_Email.TabIndex = 9;
            this.Label_Email.Text = "Email:";
            // 
            // TextBox_DiaChi
            // 
            this.TextBox_DiaChi.Location = new System.Drawing.Point(126, 115);
            this.TextBox_DiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_DiaChi.Name = "TextBox_DiaChi";
            this.TextBox_DiaChi.Size = new System.Drawing.Size(586, 26);
            this.TextBox_DiaChi.TabIndex = 8;
            // 
            // Label_DiaChi
            // 
            this.Label_DiaChi.AutoSize = true;
            this.Label_DiaChi.Location = new System.Drawing.Point(9, 120);
            this.Label_DiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_DiaChi.Name = "Label_DiaChi";
            this.Label_DiaChi.Size = new System.Drawing.Size(61, 20);
            this.Label_DiaChi.TabIndex = 7;
            this.Label_DiaChi.Text = "Địa chỉ:";
            // 
            // DateTimePicker_NgaySinh
            // 
            this.DateTimePicker_NgaySinh.Location = new System.Drawing.Point(414, 71);
            this.DateTimePicker_NgaySinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateTimePicker_NgaySinh.Name = "DateTimePicker_NgaySinh";
            this.DateTimePicker_NgaySinh.Size = new System.Drawing.Size(298, 26);
            this.DateTimePicker_NgaySinh.TabIndex = 6;
            this.DateTimePicker_NgaySinh.Validating += new System.ComponentModel.CancelEventHandler(this.DateTimePicker_NgaySinh_Validating);
            // 
            // Label_NgaySinh
            // 
            this.Label_NgaySinh.AutoSize = true;
            this.Label_NgaySinh.Location = new System.Drawing.Point(320, 74);
            this.Label_NgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_NgaySinh.Name = "Label_NgaySinh";
            this.Label_NgaySinh.Size = new System.Drawing.Size(82, 20);
            this.Label_NgaySinh.TabIndex = 5;
            this.Label_NgaySinh.Text = "Ngày sinh:";
            // 
            // RadioButton_Nu
            // 
            this.RadioButton_Nu.AutoSize = true;
            this.RadioButton_Nu.Location = new System.Drawing.Point(225, 71);
            this.RadioButton_Nu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadioButton_Nu.Name = "RadioButton_Nu";
            this.RadioButton_Nu.Size = new System.Drawing.Size(54, 24);
            this.RadioButton_Nu.TabIndex = 4;
            this.RadioButton_Nu.TabStop = true;
            this.RadioButton_Nu.Text = "Nữ";
            this.RadioButton_Nu.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Nam
            // 
            this.RadioButton_Nam.AutoSize = true;
            this.RadioButton_Nam.Location = new System.Drawing.Point(126, 71);
            this.RadioButton_Nam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadioButton_Nam.Name = "RadioButton_Nam";
            this.RadioButton_Nam.Size = new System.Drawing.Size(67, 24);
            this.RadioButton_Nam.TabIndex = 3;
            this.RadioButton_Nam.TabStop = true;
            this.RadioButton_Nam.Text = "Nam";
            this.RadioButton_Nam.UseVisualStyleBackColor = true;
            // 
            // Label_GioiTinh
            // 
            this.Label_GioiTinh.AutoSize = true;
            this.Label_GioiTinh.Location = new System.Drawing.Point(9, 74);
            this.Label_GioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_GioiTinh.Name = "Label_GioiTinh";
            this.Label_GioiTinh.Size = new System.Drawing.Size(71, 20);
            this.Label_GioiTinh.TabIndex = 2;
            this.Label_GioiTinh.Text = "Giới tính:";
            // 
            // TextBox_HoTen
            // 
            this.TextBox_HoTen.Location = new System.Drawing.Point(126, 26);
            this.TextBox_HoTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_HoTen.Name = "TextBox_HoTen";
            this.TextBox_HoTen.Size = new System.Drawing.Size(586, 26);
            this.TextBox_HoTen.TabIndex = 1;
            this.TextBox_HoTen.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_HoTen_Validating);
            // 
            // Label_HoTen
            // 
            this.Label_HoTen.AutoSize = true;
            this.Label_HoTen.Location = new System.Drawing.Point(9, 31);
            this.Label_HoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_HoTen.Name = "Label_HoTen";
            this.Label_HoTen.Size = new System.Drawing.Size(81, 20);
            this.Label_HoTen.TabIndex = 0;
            this.Label_HoTen.Text = "Họ và tên:";
            // 
            // GroupBox_DSHocSinh
            // 
            this.GroupBox_DSHocSinh.Controls.Add(this.GridView_DSHocSinh);
            this.GroupBox_DSHocSinh.Location = new System.Drawing.Point(18, 323);
            this.GroupBox_DSHocSinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox_DSHocSinh.Name = "GroupBox_DSHocSinh";
            this.GroupBox_DSHocSinh.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox_DSHocSinh.Size = new System.Drawing.Size(957, 508);
            this.GroupBox_DSHocSinh.TabIndex = 2;
            this.GroupBox_DSHocSinh.TabStop = false;
            this.GroupBox_DSHocSinh.Text = "Danh sách học sinh";
            // 
            // GridView_DSHocSinh
            // 
            this.GridView_DSHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_DSHocSinh.Location = new System.Drawing.Point(12, 29);
            this.GridView_DSHocSinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridView_DSHocSinh.Name = "GridView_DSHocSinh";
            this.GridView_DSHocSinh.RowHeadersWidth = 62;
            this.GridView_DSHocSinh.Size = new System.Drawing.Size(933, 469);
            this.GridView_DSHocSinh.TabIndex = 0;
            // 
            // GroupBox_ThaoTac
            // 
            this.GroupBox_ThaoTac.Controls.Add(this.Button_Sua);
            this.GroupBox_ThaoTac.Controls.Add(this.Button_Xoa);
            this.GroupBox_ThaoTac.Controls.Add(this.Button_Them);
            this.GroupBox_ThaoTac.Location = new System.Drawing.Point(838, 105);
            this.GroupBox_ThaoTac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox_ThaoTac.Name = "GroupBox_ThaoTac";
            this.GroupBox_ThaoTac.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox_ThaoTac.Size = new System.Drawing.Size(136, 209);
            this.GroupBox_ThaoTac.TabIndex = 3;
            this.GroupBox_ThaoTac.TabStop = false;
            this.GroupBox_ThaoTac.Text = "Thao tác";
            // 
            // Button_Sua
            // 
            this.Button_Sua.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.AddButton;
            this.Button_Sua.Location = new System.Drawing.Point(12, 89);
            this.Button_Sua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Sua.Name = "Button_Sua";
            this.Button_Sua.Size = new System.Drawing.Size(112, 46);
            this.Button_Sua.TabIndex = 2;
            this.Button_Sua.Text = "Chỉnh sửa";
            this.Button_Sua.UseVisualStyleBackColor = true;
            this.Button_Sua.Click += new System.EventHandler(this.Button_Sua_Click);
            // 
            // Button_Xoa
            // 
            this.Button_Xoa.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.AddButton;
            this.Button_Xoa.Location = new System.Drawing.Point(12, 149);
            this.Button_Xoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Xoa.Name = "Button_Xoa";
            this.Button_Xoa.Size = new System.Drawing.Size(112, 46);
            this.Button_Xoa.TabIndex = 1;
            this.Button_Xoa.Text = "Xóa";
            this.Button_Xoa.UseVisualStyleBackColor = true;
            this.Button_Xoa.Click += new System.EventHandler(this.Button_Xoa_Click);
            // 
            // Button_Them
            // 
            this.Button_Them.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.AddButton;
            this.Button_Them.Location = new System.Drawing.Point(12, 31);
            this.Button_Them.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Them.Name = "Button_Them";
            this.Button_Them.Size = new System.Drawing.Size(112, 46);
            this.Button_Them.TabIndex = 0;
            this.Button_Them.Text = "Thêm";
            this.Button_Them.UseVisualStyleBackColor = true;
            this.Button_Them.Click += new System.EventHandler(this.Button_Them_Click);
            // 
            // Button_Close
            // 
            this.Button_Close.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.ExitButton;
            this.Button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Close.Cursor = System.Windows.Forms.Cursors.Default;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Close.Location = new System.Drawing.Point(896, 18);
            this.Button_Close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(80, 77);
            this.Button_Close.TabIndex = 4;
            this.Button_Close.UseVisualStyleBackColor = true;
            // 
            // errorProvider_HoTen
            // 
            this.errorProvider_HoTen.ContainerControl = this;
            // 
            // checkedProvider_HoTen
            // 
            this.checkedProvider_HoTen.ContainerControl = this;
            this.checkedProvider_HoTen.Icon = ((System.Drawing.Icon)(resources.GetObject("checkedProvider_HoTen.Icon")));
            // 
            // errorProvider_NgaySinh
            // 
            this.errorProvider_NgaySinh.ContainerControl = this;
            // 
            // checkedProvider_NgaySinh
            // 
            this.checkedProvider_NgaySinh.ContainerControl = this;
            this.checkedProvider_NgaySinh.Icon = ((System.Drawing.Icon)(resources.GetObject("checkedProvider_NgaySinh.Icon")));
            // 
            // errorProvider_DiaChi
            // 
            this.errorProvider_DiaChi.ContainerControl = this;
            // 
            // checkedProvider_DiaChi
            // 
            this.checkedProvider_DiaChi.ContainerControl = this;
            this.checkedProvider_DiaChi.Icon = ((System.Drawing.Icon)(resources.GetObject("checkedProvider_DiaChi.Icon")));
            // 
            // errorProvider_Email
            // 
            this.errorProvider_Email.ContainerControl = this;
            // 
            // checkedProvider_Email
            // 
            this.checkedProvider_Email.ContainerControl = this;
            this.checkedProvider_Email.Icon = ((System.Drawing.Icon)(resources.GetObject("checkedProvider_Email.Icon")));
            // 
            // Form_TiepNhanHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 846);
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.GroupBox_ThaoTac);
            this.Controls.Add(this.GroupBox_DSHocSinh);
            this.Controls.Add(this.GroupBox_ThongTin);
            this.Controls.Add(this.Panel_Title);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_TiepNhanHS";
            this.Text = "Tiếp Nhận Học Sinh";
            this.Panel_Title.ResumeLayout(false);
            this.Panel_Title.PerformLayout();
            this.GroupBox_ThongTin.ResumeLayout(false);
            this.GroupBox_ThongTin.PerformLayout();
            this.GroupBox_DSHocSinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_DSHocSinh)).EndInit();
            this.GroupBox_ThaoTac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_HoTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedProvider_HoTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_NgaySinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedProvider_NgaySinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_DiaChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedProvider_DiaChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedProvider_Email)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Title;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.GroupBox GroupBox_ThongTin;
        private System.Windows.Forms.DateTimePicker DateTimePicker_NgaySinh;
        private System.Windows.Forms.Label Label_NgaySinh;
        private System.Windows.Forms.RadioButton RadioButton_Nu;
        private System.Windows.Forms.RadioButton RadioButton_Nam;
        private System.Windows.Forms.Label Label_GioiTinh;
        private System.Windows.Forms.TextBox TextBox_HoTen;
        private System.Windows.Forms.Label Label_HoTen;
        private System.Windows.Forms.TextBox TextBox_Email;
        private System.Windows.Forms.Label Label_Email;
        private System.Windows.Forms.TextBox TextBox_DiaChi;
        private System.Windows.Forms.Label Label_DiaChi;
        private System.Windows.Forms.GroupBox GroupBox_DSHocSinh;
        private System.Windows.Forms.DataGridView GridView_DSHocSinh;
        private System.Windows.Forms.GroupBox GroupBox_ThaoTac;
        private System.Windows.Forms.Button Button_Sua;
        private System.Windows.Forms.Button Button_Xoa;
        private System.Windows.Forms.Button Button_Them;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.ErrorProvider errorProvider_HoTen;
        private System.Windows.Forms.ErrorProvider checkedProvider_HoTen;
        private System.Windows.Forms.ErrorProvider errorProvider_NgaySinh;
        private System.Windows.Forms.ErrorProvider checkedProvider_NgaySinh;
        private System.Windows.Forms.ErrorProvider errorProvider_DiaChi;
        private System.Windows.Forms.ErrorProvider checkedProvider_DiaChi;
        private System.Windows.Forms.ErrorProvider errorProvider_Email;
        private System.Windows.Forms.ErrorProvider checkedProvider_Email;
    }
}