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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboBox_Lop = new System.Windows.Forms.ComboBox();
            this.Label_Lop = new System.Windows.Forms.Label();
            this.ComboBox_NamHoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_HoTen = new System.Windows.Forms.TextBox();
            this.Label_HoTen = new System.Windows.Forms.Label();
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
            this.GridView_DSHocSinh.AllowUserToAddRows = false;
            this.GridView_DSHocSinh.AllowUserToDeleteRows = false;
            this.GridView_DSHocSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridView_DSHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_DSHocSinh.Location = new System.Drawing.Point(8, 19);
            this.GridView_DSHocSinh.Name = "GridView_DSHocSinh";
            this.GridView_DSHocSinh.ReadOnly = true;
            this.GridView_DSHocSinh.RowHeadersWidth = 62;
            this.GridView_DSHocSinh.Size = new System.Drawing.Size(871, 353);
            this.GridView_DSHocSinh.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ComboBox_Lop);
            this.groupBox1.Controls.Add(this.Label_Lop);
            this.groupBox1.Controls.Add(this.ComboBox_NamHoc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TextBox_HoTen);
            this.groupBox1.Controls.Add(this.Label_HoTen);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 52);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tra cứu";
            // 
            // ComboBox_Lop
            // 
            this.ComboBox_Lop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_Lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Lop.FormattingEnabled = true;
            this.ComboBox_Lop.Location = new System.Drawing.Point(309, 19);
            this.ComboBox_Lop.Name = "ComboBox_Lop";
            this.ComboBox_Lop.Size = new System.Drawing.Size(213, 21);
            this.ComboBox_Lop.TabIndex = 5;
            // 
            // Label_Lop
            // 
            this.Label_Lop.AutoSize = true;
            this.Label_Lop.Location = new System.Drawing.Point(275, 23);
            this.Label_Lop.Name = "Label_Lop";
            this.Label_Lop.Size = new System.Drawing.Size(28, 13);
            this.Label_Lop.TabIndex = 4;
            this.Label_Lop.Text = "Lớp:";
            // 
            // ComboBox_NamHoc
            // 
            this.ComboBox_NamHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_NamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_NamHoc.FormattingEnabled = true;
            this.ComboBox_NamHoc.Location = new System.Drawing.Point(587, 19);
            this.ComboBox_NamHoc.Name = "ComboBox_NamHoc";
            this.ComboBox_NamHoc.Size = new System.Drawing.Size(292, 21);
            this.ComboBox_NamHoc.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Năm học:";
            // 
            // TextBox_HoTen
            // 
            this.TextBox_HoTen.Location = new System.Drawing.Point(70, 19);
            this.TextBox_HoTen.Name = "TextBox_HoTen";
            this.TextBox_HoTen.Size = new System.Drawing.Size(199, 20);
            this.TextBox_HoTen.TabIndex = 1;
            // 
            // Label_HoTen
            // 
            this.Label_HoTen.AutoSize = true;
            this.Label_HoTen.Location = new System.Drawing.Point(3, 22);
            this.Label_HoTen.Name = "Label_HoTen";
            this.Label_HoTen.Size = new System.Drawing.Size(61, 13);
            this.Label_HoTen.TabIndex = 0;
            this.Label_HoTen.Text = "Họ và Tên:";
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextBox_HoTen;
        private System.Windows.Forms.Label Label_HoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBox_NamHoc;
        private System.Windows.Forms.ComboBox ComboBox_Lop;
        private System.Windows.Forms.Label Label_Lop;
    }
}