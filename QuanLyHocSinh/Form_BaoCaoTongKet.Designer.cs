namespace QuanLyHocSinh
{
    partial class Form_BaoCaoTongKet
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
            this.TabPage_MonHoc = new System.Windows.Forms.TabPage();
            this.GridView_BCMonHoc = new System.Windows.Forms.DataGridView();
            this.Button_PrintBCMonHoc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Label_HocKy_MH = new System.Windows.Forms.Label();
            this.ComboBox_HocKy_MH = new System.Windows.Forms.ComboBox();
            this.Label_MonHoc_MH = new System.Windows.Forms.Label();
            this.ComboBox_MonHoc_MH = new System.Windows.Forms.ComboBox();
            this.Label_NamHoc_MH = new System.Windows.Forms.Label();
            this.ComboBox_NamHoc_MH = new System.Windows.Forms.ComboBox();
            this.TabPage_HocKy = new System.Windows.Forms.TabPage();
            this.GridView_BCHocKy = new System.Windows.Forms.DataGridView();
            this.Button_PrintBCHocKy = new System.Windows.Forms.Button();
            this.GroupBox_BoLoc = new System.Windows.Forms.GroupBox();
            this.Label_HocKy_HK = new System.Windows.Forms.Label();
            this.ComboBox_HocKy_HK = new System.Windows.Forms.ComboBox();
            this.Label_NamHoc_HK = new System.Windows.Forms.Label();
            this.ComboBox_NamHoc_HK = new System.Windows.Forms.ComboBox();
            this.TabControl_BaoCao = new System.Windows.Forms.TabControl();
            this.Panel_Title.SuspendLayout();
            this.TabPage_MonHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_BCMonHoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.TabPage_HocKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_BCHocKy)).BeginInit();
            this.GroupBox_BoLoc.SuspendLayout();
            this.TabControl_BaoCao.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Title
            // 
            this.Panel_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Panel_Title.Controls.Add(this.Label_Title);
            this.Panel_Title.Location = new System.Drawing.Point(153, 12);
            this.Panel_Title.Name = "Panel_Title";
            this.Panel_Title.Size = new System.Drawing.Size(497, 50);
            this.Panel_Title.TabIndex = 2;
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Title.Location = new System.Drawing.Point(122, 10);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(267, 29);
            this.Label_Title.TabIndex = 0;
            this.Label_Title.Text = "BÁO CÁO TỔNG KẾT";
            // 
            // TabPage_MonHoc
            // 
            this.TabPage_MonHoc.BackColor = System.Drawing.Color.LightCyan;
            this.TabPage_MonHoc.Controls.Add(this.groupBox1);
            this.TabPage_MonHoc.Controls.Add(this.Button_PrintBCMonHoc);
            this.TabPage_MonHoc.Controls.Add(this.GridView_BCMonHoc);
            this.TabPage_MonHoc.Location = new System.Drawing.Point(4, 22);
            this.TabPage_MonHoc.Name = "TabPage_MonHoc";
            this.TabPage_MonHoc.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_MonHoc.Size = new System.Drawing.Size(791, 343);
            this.TabPage_MonHoc.TabIndex = 1;
            this.TabPage_MonHoc.Text = "Báo Cáo Tổng Kết Môn Học";
            // 
            // GridView_BCMonHoc
            // 
            this.GridView_BCMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridView_BCMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_BCMonHoc.Location = new System.Drawing.Point(6, 62);
            this.GridView_BCMonHoc.Name = "GridView_BCMonHoc";
            this.GridView_BCMonHoc.RowHeadersWidth = 62;
            this.GridView_BCMonHoc.Size = new System.Drawing.Size(779, 236);
            this.GridView_BCMonHoc.TabIndex = 2;
            // 
            // Button_PrintBCMonHoc
            // 
            this.Button_PrintBCMonHoc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button_PrintBCMonHoc.Location = new System.Drawing.Point(362, 304);
            this.Button_PrintBCMonHoc.Name = "Button_PrintBCMonHoc";
            this.Button_PrintBCMonHoc.Size = new System.Drawing.Size(75, 28);
            this.Button_PrintBCMonHoc.TabIndex = 3;
            this.Button_PrintBCMonHoc.Text = "In";
            this.Button_PrintBCMonHoc.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ComboBox_NamHoc_MH);
            this.groupBox1.Controls.Add(this.Label_NamHoc_MH);
            this.groupBox1.Controls.Add(this.ComboBox_MonHoc_MH);
            this.groupBox1.Controls.Add(this.Label_MonHoc_MH);
            this.groupBox1.Controls.Add(this.ComboBox_HocKy_MH);
            this.groupBox1.Controls.Add(this.Label_HocKy_MH);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 50);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bộ lọc";
            // 
            // Label_HocKy_MH
            // 
            this.Label_HocKy_MH.AutoSize = true;
            this.Label_HocKy_MH.Location = new System.Drawing.Point(7, 22);
            this.Label_HocKy_MH.Name = "Label_HocKy_MH";
            this.Label_HocKy_MH.Size = new System.Drawing.Size(44, 13);
            this.Label_HocKy_MH.TabIndex = 1;
            this.Label_HocKy_MH.Text = "Học kỳ:";
            // 
            // ComboBox_HocKy_MH
            // 
            this.ComboBox_HocKy_MH.FormattingEnabled = true;
            this.ComboBox_HocKy_MH.Location = new System.Drawing.Point(58, 19);
            this.ComboBox_HocKy_MH.Name = "ComboBox_HocKy_MH";
            this.ComboBox_HocKy_MH.Size = new System.Drawing.Size(142, 21);
            this.ComboBox_HocKy_MH.TabIndex = 3;
            // 
            // Label_MonHoc_MH
            // 
            this.Label_MonHoc_MH.AutoSize = true;
            this.Label_MonHoc_MH.Location = new System.Drawing.Point(408, 22);
            this.Label_MonHoc_MH.Name = "Label_MonHoc_MH";
            this.Label_MonHoc_MH.Size = new System.Drawing.Size(52, 13);
            this.Label_MonHoc_MH.TabIndex = 2;
            this.Label_MonHoc_MH.Text = "Môn học:";
            // 
            // ComboBox_MonHoc_MH
            // 
            this.ComboBox_MonHoc_MH.FormattingEnabled = true;
            this.ComboBox_MonHoc_MH.Location = new System.Drawing.Point(466, 19);
            this.ComboBox_MonHoc_MH.Name = "ComboBox_MonHoc_MH";
            this.ComboBox_MonHoc_MH.Size = new System.Drawing.Size(145, 21);
            this.ComboBox_MonHoc_MH.TabIndex = 5;
            // 
            // Label_NamHoc_MH
            // 
            this.Label_NamHoc_MH.AutoSize = true;
            this.Label_NamHoc_MH.Location = new System.Drawing.Point(206, 22);
            this.Label_NamHoc_MH.Name = "Label_NamHoc_MH";
            this.Label_NamHoc_MH.Size = new System.Drawing.Size(53, 13);
            this.Label_NamHoc_MH.TabIndex = 6;
            this.Label_NamHoc_MH.Text = "Năm học:";
            // 
            // ComboBox_NamHoc_MH
            // 
            this.ComboBox_NamHoc_MH.FormattingEnabled = true;
            this.ComboBox_NamHoc_MH.Location = new System.Drawing.Point(262, 19);
            this.ComboBox_NamHoc_MH.Name = "ComboBox_NamHoc_MH";
            this.ComboBox_NamHoc_MH.Size = new System.Drawing.Size(141, 21);
            this.ComboBox_NamHoc_MH.TabIndex = 7;
            // 
            // TabPage_HocKy
            // 
            this.TabPage_HocKy.BackColor = System.Drawing.Color.LightCyan;
            this.TabPage_HocKy.Controls.Add(this.GroupBox_BoLoc);
            this.TabPage_HocKy.Controls.Add(this.Button_PrintBCHocKy);
            this.TabPage_HocKy.Controls.Add(this.GridView_BCHocKy);
            this.TabPage_HocKy.Location = new System.Drawing.Point(4, 22);
            this.TabPage_HocKy.Name = "TabPage_HocKy";
            this.TabPage_HocKy.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_HocKy.Size = new System.Drawing.Size(791, 343);
            this.TabPage_HocKy.TabIndex = 0;
            this.TabPage_HocKy.Text = "Báo Cáo Tổng Kết Học Kỳ";
            // 
            // GridView_BCHocKy
            // 
            this.GridView_BCHocKy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridView_BCHocKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_BCHocKy.Location = new System.Drawing.Point(6, 62);
            this.GridView_BCHocKy.Name = "GridView_BCHocKy";
            this.GridView_BCHocKy.RowHeadersWidth = 62;
            this.GridView_BCHocKy.Size = new System.Drawing.Size(779, 236);
            this.GridView_BCHocKy.TabIndex = 0;
            // 
            // Button_PrintBCHocKy
            // 
            this.Button_PrintBCHocKy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button_PrintBCHocKy.Location = new System.Drawing.Point(362, 304);
            this.Button_PrintBCHocKy.Name = "Button_PrintBCHocKy";
            this.Button_PrintBCHocKy.Size = new System.Drawing.Size(75, 28);
            this.Button_PrintBCHocKy.TabIndex = 1;
            this.Button_PrintBCHocKy.Text = "In";
            this.Button_PrintBCHocKy.UseVisualStyleBackColor = true;
            // 
            // GroupBox_BoLoc
            // 
            this.GroupBox_BoLoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_BoLoc.Controls.Add(this.ComboBox_NamHoc_HK);
            this.GroupBox_BoLoc.Controls.Add(this.Label_NamHoc_HK);
            this.GroupBox_BoLoc.Controls.Add(this.ComboBox_HocKy_HK);
            this.GroupBox_BoLoc.Controls.Add(this.Label_HocKy_HK);
            this.GroupBox_BoLoc.Location = new System.Drawing.Point(6, 6);
            this.GroupBox_BoLoc.Name = "GroupBox_BoLoc";
            this.GroupBox_BoLoc.Size = new System.Drawing.Size(779, 50);
            this.GroupBox_BoLoc.TabIndex = 9;
            this.GroupBox_BoLoc.TabStop = false;
            this.GroupBox_BoLoc.Text = "Bộ lọc";
            // 
            // Label_HocKy_HK
            // 
            this.Label_HocKy_HK.AutoSize = true;
            this.Label_HocKy_HK.Location = new System.Drawing.Point(6, 20);
            this.Label_HocKy_HK.Name = "Label_HocKy_HK";
            this.Label_HocKy_HK.Size = new System.Drawing.Size(44, 13);
            this.Label_HocKy_HK.TabIndex = 1;
            this.Label_HocKy_HK.Text = "Học kỳ:";
            // 
            // ComboBox_HocKy_HK
            // 
            this.ComboBox_HocKy_HK.FormattingEnabled = true;
            this.ComboBox_HocKy_HK.Location = new System.Drawing.Point(57, 17);
            this.ComboBox_HocKy_HK.Name = "ComboBox_HocKy_HK";
            this.ComboBox_HocKy_HK.Size = new System.Drawing.Size(163, 21);
            this.ComboBox_HocKy_HK.TabIndex = 3;
            // 
            // Label_NamHoc_HK
            // 
            this.Label_NamHoc_HK.AutoSize = true;
            this.Label_NamHoc_HK.Location = new System.Drawing.Point(226, 20);
            this.Label_NamHoc_HK.Name = "Label_NamHoc_HK";
            this.Label_NamHoc_HK.Size = new System.Drawing.Size(53, 13);
            this.Label_NamHoc_HK.TabIndex = 6;
            this.Label_NamHoc_HK.Text = "Năm học:";
            // 
            // ComboBox_NamHoc_HK
            // 
            this.ComboBox_NamHoc_HK.FormattingEnabled = true;
            this.ComboBox_NamHoc_HK.Location = new System.Drawing.Point(285, 17);
            this.ComboBox_NamHoc_HK.Name = "ComboBox_NamHoc_HK";
            this.ComboBox_NamHoc_HK.Size = new System.Drawing.Size(166, 21);
            this.ComboBox_NamHoc_HK.TabIndex = 7;
            // 
            // TabControl_BaoCao
            // 
            this.TabControl_BaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl_BaoCao.Controls.Add(this.TabPage_HocKy);
            this.TabControl_BaoCao.Controls.Add(this.TabPage_MonHoc);
            this.TabControl_BaoCao.Location = new System.Drawing.Point(2, 80);
            this.TabControl_BaoCao.Name = "TabControl_BaoCao";
            this.TabControl_BaoCao.SelectedIndex = 0;
            this.TabControl_BaoCao.Size = new System.Drawing.Size(799, 369);
            this.TabControl_BaoCao.TabIndex = 0;
            // 
            // Form_BaoCaoTongKet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Panel_Title);
            this.Controls.Add(this.TabControl_BaoCao);
            this.Name = "Form_BaoCaoTongKet";
            this.Text = "Báo Cáo Tổng Kết";
            this.Panel_Title.ResumeLayout(false);
            this.Panel_Title.PerformLayout();
            this.TabPage_MonHoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_BCMonHoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TabPage_HocKy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_BCHocKy)).EndInit();
            this.GroupBox_BoLoc.ResumeLayout(false);
            this.GroupBox_BoLoc.PerformLayout();
            this.TabControl_BaoCao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel_Title;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.TabPage TabPage_MonHoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComboBox_NamHoc_MH;
        private System.Windows.Forms.Label Label_NamHoc_MH;
        private System.Windows.Forms.ComboBox ComboBox_MonHoc_MH;
        private System.Windows.Forms.Label Label_MonHoc_MH;
        private System.Windows.Forms.ComboBox ComboBox_HocKy_MH;
        private System.Windows.Forms.Label Label_HocKy_MH;
        private System.Windows.Forms.Button Button_PrintBCMonHoc;
        private System.Windows.Forms.DataGridView GridView_BCMonHoc;
        private System.Windows.Forms.TabPage TabPage_HocKy;
        private System.Windows.Forms.GroupBox GroupBox_BoLoc;
        private System.Windows.Forms.ComboBox ComboBox_NamHoc_HK;
        private System.Windows.Forms.Label Label_NamHoc_HK;
        private System.Windows.Forms.ComboBox ComboBox_HocKy_HK;
        private System.Windows.Forms.Label Label_HocKy_HK;
        private System.Windows.Forms.Button Button_PrintBCHocKy;
        private System.Windows.Forms.DataGridView GridView_BCHocKy;
        private System.Windows.Forms.TabControl TabControl_BaoCao;
    }
}