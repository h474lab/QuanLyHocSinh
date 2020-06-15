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
    public partial class Form_BangDiemMonHoc : Form
    {
        BUS_DanhSachLop danhsachlop = new BUS_DanhSachLop();
        BUS_HocKy hocky = new BUS_HocKy();
        BUS_NamHoc namhoc = new BUS_NamHoc();
        BUS_MonHoc monhoc = new BUS_MonHoc();
        BUS_HocSinh hocsinh = new BUS_HocSinh();
        BUS_BangDiemMon bangdiemmon = new BUS_BangDiemMon();

        string currentLop = "";
        string currentHocKy = "";
        string currentNamHoc = "";
        string currentMonHoc = "";
        public Form_BangDiemMonHoc()
        {
            InitializeComponent();
            LoadDanhSachLop();
            LoadDanhSachHocKy();
            LoadDanhSachNamHoc();
            LoadDanhSachMonHoc();
            LoadBangDiem();
        }

        void LoadDanhSachLop()
        {
            DataTable temp = danhsachlop.GetTatCaLop();
            ComboBox_Lop.DataSource = temp;
            ComboBox_Lop.DisplayMember = "TenLop";
            ComboBox_Lop.ValueMember = "MaLop";

            currentLop = ComboBox_Lop.SelectedValue.ToString();

            ComboBox_Lop.SelectedValueChanged += ComboBox_Lop_SelectedValueChanged;
        }

        private void ComboBox_Lop_SelectedValueChanged(object sender, EventArgs e)
        {
            currentLop = ComboBox_Lop.SelectedValue.ToString();
            //Console.WriteLine(currentLop);
            LoadBangDiem();
        }

        void LoadDanhSachHocKy()
        {
            ComboBox_HocKy.DataSource = hocky.GetTatCaHK();
            ComboBox_HocKy.DisplayMember = "TenHocKy";
            ComboBox_HocKy.ValueMember = "MaHocKy";

            currentHocKy = ComboBox_HocKy.SelectedValue.ToString();

            ComboBox_HocKy.SelectedValueChanged += ComboBox_HocKy_SelectedValueChanged;
        }

        private void ComboBox_HocKy_SelectedValueChanged(object sender, EventArgs e)
        {
            currentHocKy = ComboBox_HocKy.SelectedValue.ToString();
            LoadBangDiem();
        }

        void LoadDanhSachNamHoc()
        {
            DataTable temp = namhoc.GetTatCaNH();
            temp.Columns.Add("Full_NamHoc", typeof(string), "NamBD + ' - ' + NamKT");
            ComboBox_NamHoc.DataSource = temp;
            ComboBox_NamHoc.DisplayMember = "Full_NamHoc";
            ComboBox_NamHoc.ValueMember = "MaNamHoc";

            currentNamHoc = ComboBox_NamHoc.SelectedValue.ToString();

            ComboBox_NamHoc.SelectedValueChanged += ComboBox_NamHoc_SelectedValueChanged;
        }

        private void ComboBox_NamHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            currentNamHoc = ComboBox_NamHoc.SelectedValue.ToString();
            LoadBangDiem();
        }

        void LoadDanhSachMonHoc()
        {
            ComboBox_MonHoc.DataSource = monhoc.GetTatCaMonHoc();
            ComboBox_MonHoc.DisplayMember = "TenMonHoc";
            ComboBox_MonHoc.ValueMember = "MaMonHoc";

            currentMonHoc = ComboBox_MonHoc.SelectedValue.ToString();

            ComboBox_MonHoc.SelectedValueChanged += ComboBox_MonHoc_SelectedValueChanged;
        }

        private void ComboBox_MonHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            currentMonHoc = ComboBox_MonHoc.SelectedValue.ToString();
            LoadBangDiem();
        }

        void LoadBangDiem()
        {
            if (currentLop == "" | currentHocKy == "" | currentNamHoc == "") return;
            GridView_BangDiem.DataSource = bangdiemmon.GetBangDiem(currentLop, currentHocKy, currentNamHoc, currentMonHoc);
            GridView_BangDiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridView_BangDiem.SelectionMode = DataGridViewSelectionMode.CellSelect;

            // Edit theme
            GridView_BangDiem.BorderStyle = BorderStyle.None;
            GridView_BangDiem.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            GridView_BangDiem.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            GridView_BangDiem.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            GridView_BangDiem.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            GridView_BangDiem.BackgroundColor = Color.White;

            GridView_BangDiem.EnableHeadersVisualStyles = false;
            GridView_BangDiem.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            GridView_BangDiem.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            GridView_BangDiem.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

    }
}
