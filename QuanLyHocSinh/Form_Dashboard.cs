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

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            Form_TiepNhanHS form = new Form_TiepNhanHS();
            form.Show();
        }

        private void ClassBtn_Click(object sender, EventArgs e)
        {
            Form_LapDSLop form = new Form_LapDSLop();
            form.Show();
        }

        private void ScoreBtn_Click(object sender, EventArgs e)
        {
            Form_BangDiemMonHoc form = new Form_BangDiemMonHoc();
            form.Show();
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            Form_BaoCaoTongKet form = new Form_BaoCaoTongKet();
            form.Show();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            Form_ThietLap form = new Form_ThietLap();
            form.Show();
        }
    }
}
