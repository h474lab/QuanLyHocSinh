namespace QuanLyHocSinh
{
    partial class Form_Dashboard
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
            this.OptionsPanel = new System.Windows.Forms.Panel();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.ReportBtn = new System.Windows.Forms.Button();
            this.ScoreBtn = new System.Windows.Forms.Button();
            this.ClassBtn = new System.Windows.Forms.Button();
            this.AddStudentBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.OptionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.Controls.Add(this.SettingsBtn);
            this.OptionsPanel.Controls.Add(this.ReportBtn);
            this.OptionsPanel.Controls.Add(this.ScoreBtn);
            this.OptionsPanel.Controls.Add(this.ClassBtn);
            this.OptionsPanel.Controls.Add(this.AddStudentBtn);
            this.OptionsPanel.Controls.Add(this.SearchBtn);
            this.OptionsPanel.Location = new System.Drawing.Point(13, 18);
            this.OptionsPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(155, 795);
            this.OptionsPanel.TabIndex = 0;
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.SettingsButton;
            this.SettingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.Location = new System.Drawing.Point(21, 643);
            this.SettingsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(112, 115);
            this.SettingsBtn.TabIndex = 5;
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // ReportBtn
            // 
            this.ReportBtn.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.ReportButton;
            this.ReportBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportBtn.Location = new System.Drawing.Point(21, 518);
            this.ReportBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Size = new System.Drawing.Size(112, 115);
            this.ReportBtn.TabIndex = 4;
            this.ReportBtn.UseVisualStyleBackColor = true;
            this.ReportBtn.Click += new System.EventHandler(this.ReportBtn_Click);
            // 
            // ScoreBtn
            // 
            this.ScoreBtn.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.ScoreButton_1_;
            this.ScoreBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoreBtn.Location = new System.Drawing.Point(21, 393);
            this.ScoreBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScoreBtn.Name = "ScoreBtn";
            this.ScoreBtn.Size = new System.Drawing.Size(112, 115);
            this.ScoreBtn.TabIndex = 3;
            this.ScoreBtn.UseVisualStyleBackColor = true;
            this.ScoreBtn.Click += new System.EventHandler(this.ScoreBtn_Click);
            // 
            // ClassBtn
            // 
            this.ClassBtn.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.ClassroomButton;
            this.ClassBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClassBtn.Location = new System.Drawing.Point(21, 268);
            this.ClassBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClassBtn.Name = "ClassBtn";
            this.ClassBtn.Size = new System.Drawing.Size(112, 115);
            this.ClassBtn.TabIndex = 2;
            this.ClassBtn.UseVisualStyleBackColor = true;
            this.ClassBtn.Click += new System.EventHandler(this.ClassBtn_Click);
            // 
            // AddStudentBtn
            // 
            this.AddStudentBtn.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.AddStudentButton;
            this.AddStudentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudentBtn.Location = new System.Drawing.Point(21, 18);
            this.AddStudentBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddStudentBtn.Name = "AddStudentBtn";
            this.AddStudentBtn.Size = new System.Drawing.Size(112, 115);
            this.AddStudentBtn.TabIndex = 1;
            this.AddStudentBtn.UseVisualStyleBackColor = true;
            this.AddStudentBtn.Click += new System.EventHandler(this.AddStudentBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.SearchButton_1_;
            this.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Location = new System.Drawing.Point(21, 143);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(112, 115);
            this.SearchBtn.TabIndex = 0;
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // Main_Panel
            // 
            this.Main_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_Panel.Location = new System.Drawing.Point(175, 18);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(1329, 795);
            this.Main_Panel.TabIndex = 1;
            // 
            // Form_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 825);
            this.Controls.Add(this.Main_Panel);
            this.Controls.Add(this.OptionsPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Dashboard";
            this.Text = "Quản Lý Học Sinh";
            this.OptionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OptionsPanel;
        private System.Windows.Forms.Button AddStudentBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button ClassBtn;
        private System.Windows.Forms.Button ScoreBtn;
        private System.Windows.Forms.Button ReportBtn;
        private System.Windows.Forms.Button SettingsBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel Main_Panel;
    }
}

