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
            this.TabControl_BaoCao = new System.Windows.Forms.TabControl();
            this.TabPage_HocKy = new System.Windows.Forms.TabPage();
            this.Button_PrintBCHocKy = new System.Windows.Forms.Button();
            this.GridView_BCHocKy = new System.Windows.Forms.DataGridView();
            this.TabPage_MonHoc = new System.Windows.Forms.TabPage();
            this.Button_PrintBCMonHoc = new System.Windows.Forms.Button();
            this.GridView_BCMonHoc = new System.Windows.Forms.DataGridView();
            this.Panel_Title = new System.Windows.Forms.Panel();
            this.Label_Title = new System.Windows.Forms.Label();
            this.Button_Close = new System.Windows.Forms.Button();
            this.TabControl_BaoCao.SuspendLayout();
            this.TabPage_HocKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_BCHocKy)).BeginInit();
            this.TabPage_MonHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_BCMonHoc)).BeginInit();
            this.Panel_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl_BaoCao
            // 
            this.TabControl_BaoCao.Controls.Add(this.TabPage_HocKy);
            this.TabControl_BaoCao.Controls.Add(this.TabPage_MonHoc);
            this.TabControl_BaoCao.Location = new System.Drawing.Point(3, 123);
            this.TabControl_BaoCao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabControl_BaoCao.Name = "TabControl_BaoCao";
            this.TabControl_BaoCao.SelectedIndex = 0;
            this.TabControl_BaoCao.Size = new System.Drawing.Size(1198, 568);
            this.TabControl_BaoCao.TabIndex = 0;
            // 
            // TabPage_HocKy
            // 
            this.TabPage_HocKy.Controls.Add(this.Button_PrintBCHocKy);
            this.TabPage_HocKy.Controls.Add(this.GridView_BCHocKy);
            this.TabPage_HocKy.Location = new System.Drawing.Point(4, 29);
            this.TabPage_HocKy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabPage_HocKy.Name = "TabPage_HocKy";
            this.TabPage_HocKy.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabPage_HocKy.Size = new System.Drawing.Size(1190, 535);
            this.TabPage_HocKy.TabIndex = 0;
            this.TabPage_HocKy.Text = "Báo Cáo Tổng Kết Học Kỳ";
            this.TabPage_HocKy.UseVisualStyleBackColor = true;
            // 
            // Button_PrintBCHocKy
            // 
            this.Button_PrintBCHocKy.Location = new System.Drawing.Point(543, 468);
            this.Button_PrintBCHocKy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_PrintBCHocKy.Name = "Button_PrintBCHocKy";
            this.Button_PrintBCHocKy.Size = new System.Drawing.Size(112, 43);
            this.Button_PrintBCHocKy.TabIndex = 1;
            this.Button_PrintBCHocKy.Text = "In";
            this.Button_PrintBCHocKy.UseVisualStyleBackColor = true;
            // 
            // GridView_BCHocKy
            // 
            this.GridView_BCHocKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_BCHocKy.Location = new System.Drawing.Point(9, 10);
            this.GridView_BCHocKy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridView_BCHocKy.Name = "GridView_BCHocKy";
            this.GridView_BCHocKy.RowHeadersWidth = 62;
            this.GridView_BCHocKy.Size = new System.Drawing.Size(1168, 436);
            this.GridView_BCHocKy.TabIndex = 0;
            // 
            // TabPage_MonHoc
            // 
            this.TabPage_MonHoc.Controls.Add(this.Button_PrintBCMonHoc);
            this.TabPage_MonHoc.Controls.Add(this.GridView_BCMonHoc);
            this.TabPage_MonHoc.Location = new System.Drawing.Point(4, 29);
            this.TabPage_MonHoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabPage_MonHoc.Name = "TabPage_MonHoc";
            this.TabPage_MonHoc.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabPage_MonHoc.Size = new System.Drawing.Size(1190, 535);
            this.TabPage_MonHoc.TabIndex = 1;
            this.TabPage_MonHoc.Text = "Báo Cáo Tổng Kết Môn Học";
            this.TabPage_MonHoc.UseVisualStyleBackColor = true;
            // 
            // Button_PrintBCMonHoc
            // 
            this.Button_PrintBCMonHoc.Location = new System.Drawing.Point(543, 468);
            this.Button_PrintBCMonHoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_PrintBCMonHoc.Name = "Button_PrintBCMonHoc";
            this.Button_PrintBCMonHoc.Size = new System.Drawing.Size(112, 43);
            this.Button_PrintBCMonHoc.TabIndex = 3;
            this.Button_PrintBCMonHoc.Text = "In";
            this.Button_PrintBCMonHoc.UseVisualStyleBackColor = true;
            // 
            // GridView_BCMonHoc
            // 
            this.GridView_BCMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_BCMonHoc.Location = new System.Drawing.Point(9, 9);
            this.GridView_BCMonHoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridView_BCMonHoc.Name = "GridView_BCMonHoc";
            this.GridView_BCMonHoc.RowHeadersWidth = 62;
            this.GridView_BCMonHoc.Size = new System.Drawing.Size(1168, 437);
            this.GridView_BCMonHoc.TabIndex = 2;
            // 
            // Panel_Title
            // 
            this.Panel_Title.Controls.Add(this.Label_Title);
            this.Panel_Title.Location = new System.Drawing.Point(230, 18);
            this.Panel_Title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel_Title.Name = "Panel_Title";
            this.Panel_Title.Size = new System.Drawing.Size(746, 77);
            this.Panel_Title.TabIndex = 2;
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Title.Location = new System.Drawing.Point(183, 15);
            this.Label_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(391, 40);
            this.Label_Title.TabIndex = 0;
            this.Label_Title.Text = "BÁO CÁO TỔNG KẾT";
            // 
            // Button_Close
            // 
            this.Button_Close.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.ExitButton;
            this.Button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Close.Cursor = System.Windows.Forms.Cursors.Default;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Close.Location = new System.Drawing.Point(1107, 18);
            this.Button_Close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(80, 77);
            this.Button_Close.TabIndex = 6;
            this.Button_Close.UseVisualStyleBackColor = true;
            // 
            // Form_BaoCaoTongKet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.Panel_Title);
            this.Controls.Add(this.TabControl_BaoCao);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_BaoCaoTongKet";
            this.Text = "Báo Cáo Tổng Kết";
            this.TabControl_BaoCao.ResumeLayout(false);
            this.TabPage_HocKy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_BCHocKy)).EndInit();
            this.TabPage_MonHoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_BCMonHoc)).EndInit();
            this.Panel_Title.ResumeLayout(false);
            this.Panel_Title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl_BaoCao;
        private System.Windows.Forms.TabPage TabPage_HocKy;
        private System.Windows.Forms.TabPage TabPage_MonHoc;
        private System.Windows.Forms.Panel Panel_Title;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.Button Button_PrintBCHocKy;
        private System.Windows.Forms.DataGridView GridView_BCHocKy;
        private System.Windows.Forms.Button Button_PrintBCMonHoc;
        private System.Windows.Forms.DataGridView GridView_BCMonHoc;
        private System.Windows.Forms.Button Button_Close;
    }
}