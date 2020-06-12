using DTO;
using BUS;
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
    public partial class Form_ThietLap : Form
    {
        BUS_ThamSo thamso = new BUS_ThamSo();
        public Form_ThietLap()
        {
            InitializeComponent();

            SetQuyDinh();
        }
        void SetQuyDinh()
        {
            ThamSo temp = thamso.GetThamSo();
            TextBox_TuoiMin.Text = temp.TuoiToiThieu.ToString();
            TextBox_TuoiMax.Text = temp.TuoiToiDa.ToString();
            TextBox_SiSoMax.Text = temp.SiSoToiDa.ToString();
            TextBox_DiemMin.Text = temp.DiemToiThieu.ToString();
            TextBox_DiemMax.Text = temp.DiemToiDa.ToString();
            TextBox_DiemDat.Text = temp.DiemDat.ToString();
        }
        private int Check()
        {
            if (TextBox_TuoiMin.Text == "" || TextBox_TuoiMax.Text == "" || TextBox_SiSoMax.Text == "" ||
                TextBox_DiemMin.Text == "" || TextBox_DiemMax.Text == "" || TextBox_DiemDat.Text == "")
                return 0;
            int TuoiMin = int.Parse(TextBox_TuoiMin.Text);
            int TuoiMax = int.Parse(TextBox_TuoiMax.Text);
            int SiSoMax = int.Parse(TextBox_SiSoMax.Text);
            double DiemMin = double.Parse(TextBox_DiemMin.Text);
            double DiemMax = double.Parse(TextBox_DiemMax.Text);
            double DiemDat = double.Parse(TextBox_DiemDat.Text);
            if (TuoiMin <= 0 || TuoiMax <= 0 || SiSoMax <= 0 || DiemMin < 0 || DiemMax <= 0 || DiemDat < 0 ||
                TuoiMax - TuoiMin < 0 || DiemMax - DiemMin < 0 || DiemDat > DiemMax || DiemDat < DiemMin)
            {
                MessageBox.Show("Không thể lưu", "Các tham số không thỏa điều kiện", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            return 1;
        }
        private void Button_Luu_Click(object sender, EventArgs e)
        {
            if (Check() == 1)
            {
                int TuoiMin = int.Parse(TextBox_TuoiMin.Text);
                int TuoiMax = int.Parse(TextBox_TuoiMax.Text);
                int SiSoMax = int.Parse(TextBox_SiSoMax.Text);
                double DiemMin = double.Parse(TextBox_DiemMin.Text);
                double DiemMax = double.Parse(TextBox_DiemMax.Text);
                double DiemDat = double.Parse(TextBox_DiemDat.Text);
                ThamSo temp = new ThamSo(TuoiMin, TuoiMax, SiSoMax, DiemMin, DiemMax, DiemDat);
                thamso.UpdateThamSo(temp);
            }
        }
    }
}
