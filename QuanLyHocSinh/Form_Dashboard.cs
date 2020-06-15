using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class Form_Dashboard : Form
    {
        public Form_Dashboard()
        {
            InitializeComponent();
        }

        private void SetButtonColor(int pos)
        {
            // Default color
            Color defaultColor = SystemColors.Control;

            // Color when focused
            Color focusedColor = SystemColors.ControlDark;

            AddStudentBtn.BackColor = defaultColor;
            SearchBtn.BackColor = defaultColor;
            ClassBtn.BackColor = defaultColor;
            ScoreBtn.BackColor = defaultColor;
            ReportBtn.BackColor = defaultColor;
            SettingsBtn.BackColor = defaultColor;
            switch (pos)
            {
                case 0:
                    AddStudentBtn.BackColor = focusedColor;
                    break;
                case 1:
                    SearchBtn.BackColor = focusedColor;
                    break;
                case 2:
                    ClassBtn.BackColor = focusedColor;
                    break;
                case 3:
                    ScoreBtn.BackColor = focusedColor;
                    break;
                case 4:
                    ReportBtn.BackColor = focusedColor;
                    break;
                case 5:
                    SettingsBtn.BackColor = focusedColor;
                    break;
            }
        }
        
        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            SetButtonColor(0);     
       
            Main_Panel.Controls.Clear();
            Form_TiepNhanHS form = new Form_TiepNhanHS();
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            Main_Panel.Controls.Add(form);
            form.Show();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SetButtonColor(1);

            Main_Panel.Controls.Clear();
        }

        private void ClassBtn_Click(object sender, EventArgs e)
        {
            SetButtonColor(2);

            Main_Panel.Controls.Clear();
            Form_LapDSLop form = new Form_LapDSLop();
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            Main_Panel.Controls.Add(form);
            form.Show();
        }

        private void ScoreBtn_Click(object sender, EventArgs e)
        {
            SetButtonColor(3);

            Main_Panel.Controls.Clear();
            Form_BangDiemMonHoc form = new Form_BangDiemMonHoc();
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            Main_Panel.Controls.Add(form);
            form.Show();
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            SetButtonColor(4);

            Main_Panel.Controls.Clear();
            Form_BaoCaoTongKet form = new Form_BaoCaoTongKet();
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            Main_Panel.Controls.Add(form);
            form.Show();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            SetButtonColor(5);

            Main_Panel.Controls.Clear();
            Form_ThietLap form = new Form_ThietLap();
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            Main_Panel.Controls.Add(form);
            form.Show();
        }
    }
}
