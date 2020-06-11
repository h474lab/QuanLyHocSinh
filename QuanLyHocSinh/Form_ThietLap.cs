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
    }
}
