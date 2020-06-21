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
    public partial class Form_BaoCaoTongKet : Form
    {
        BUS_DanhSachLop danhsachlop = new BUS_DanhSachLop();
        BUS_HocKy hocky = new BUS_HocKy();
        BUS_NamHoc namhoc = new BUS_NamHoc();
        BUS_MonHoc monhoc = new BUS_MonHoc();
        BUS_BCHocKy bchocky = new BUS_BCHocKy();
        BUS_BCMon bcmon = new BUS_BCMon();

        string currentLop_HK = "";
        string currentHocKy_HK = "";
        string currentNamHoc_HK = "";

        string currentLop_MH = "";
        string currentHocKy_MH = "";
        string currentNamHoc_MH = "";
        string currentMonHoc_MH = "";

        public Form_BaoCaoTongKet()
        {
            InitializeComponent();

            LoadDanhSachHocKy();
            LoadDanhSachNamHoc();
            LoadDanhSachMonHoc();
            LoadBCHocKy();
            LoadBCMon();
        }

        void LoadBCHocKy()
        {
            if (currentHocKy_HK == "" | currentNamHoc_HK == "") return;
            GridView_BCHocKy.DataSource = bchocky.GetBCHocKy(currentHocKy_HK, currentNamHoc_HK);
            GridView_BCHocKy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridView_BCHocKy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView_BCHocKy.ReadOnly = true;
            GridView_BCHocKy.DefaultCellStyle.SelectionBackColor = Color.LightGreen;

            GridView_BCHocKy.BorderStyle = BorderStyle.None;
            GridView_BCHocKy.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            GridView_BCHocKy.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            GridView_BCHocKy.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            GridView_BCHocKy.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            GridView_BCHocKy.BackgroundColor = Color.White;

            GridView_BCHocKy.EnableHeadersVisualStyles = false;
            GridView_BCHocKy.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            GridView_BCHocKy.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            GridView_BCHocKy.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        void LoadBCMon()
        {
            if (currentHocKy_MH == "" | currentNamHoc_MH == "") return;
            GridView_BCMonHoc.DataSource = bcmon.GetBCMon(currentHocKy_MH, currentNamHoc_MH, currentMonHoc_MH);
            GridView_BCMonHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridView_BCMonHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView_BCMonHoc.ReadOnly = true;
            GridView_BCMonHoc.DefaultCellStyle.SelectionBackColor = Color.LightGreen;

            GridView_BCMonHoc.BorderStyle = BorderStyle.None;
            GridView_BCMonHoc.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            GridView_BCMonHoc.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            GridView_BCMonHoc.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            GridView_BCMonHoc.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            GridView_BCMonHoc.BackgroundColor = Color.White;

            GridView_BCMonHoc.EnableHeadersVisualStyles = false;
            GridView_BCMonHoc.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            GridView_BCMonHoc.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            GridView_BCMonHoc.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        void LoadDanhSachHocKy()
        {
            DataTable temp = hocky.GetTatCaHK();

            ComboBox_HocKy_HK.DataSource = temp;
            ComboBox_HocKy_HK.DisplayMember = "TenHocKy";
            ComboBox_HocKy_HK.ValueMember = "MaHocKy";

            currentHocKy_HK = ComboBox_HocKy_HK.SelectedValue.ToString();

            ComboBox_HocKy_HK.SelectedValueChanged += ComboBox_HocKy_HK_SelectedValueChanged;

            ComboBox_HocKy_MH.DataSource = temp;
            ComboBox_HocKy_MH.DisplayMember = "TenHocKy";
            ComboBox_HocKy_MH.ValueMember = "MaHocKy";

            currentHocKy_MH = ComboBox_HocKy_MH.SelectedValue.ToString();

            ComboBox_HocKy_MH.SelectedValueChanged += ComboBox_HocKy_MH_SelectedValueChanged;
        }

        private void ComboBox_HocKy_HK_SelectedValueChanged(object sender, EventArgs e)
        {
            currentHocKy_HK = ComboBox_HocKy_HK.SelectedValue.ToString();
            LoadBCHocKy();
        }

        private void ComboBox_HocKy_MH_SelectedValueChanged(object sender, EventArgs e)
        {
            currentHocKy_MH = ComboBox_HocKy_HK.SelectedValue.ToString();
            LoadBCMon();
        }

        void LoadDanhSachNamHoc()
        {
            DataTable temp = namhoc.GetTatCaNH();
            temp.Columns.Add("Full_NamHoc", typeof(string), "NamBD + ' - ' + NamKT");
            ComboBox_NamHoc_HK.DataSource = temp;
            ComboBox_NamHoc_HK.DisplayMember = "Full_NamHoc";
            ComboBox_NamHoc_HK.ValueMember = "MaNamHoc";

            currentNamHoc_HK = ComboBox_NamHoc_HK.SelectedValue.ToString();

            ComboBox_NamHoc_HK.SelectedValueChanged += ComboBox_NamHoc_HK_SelectedValueChanged;

            ComboBox_NamHoc_MH.DataSource = temp;
            ComboBox_NamHoc_MH.DisplayMember = "Full_NamHoc";
            ComboBox_NamHoc_MH.ValueMember = "MaNamHoc";

            currentNamHoc_MH = ComboBox_NamHoc_MH.SelectedValue.ToString();

            ComboBox_NamHoc_MH.SelectedValueChanged += ComboBox_NamHoc_MH_SelectedValueChanged;
        }

        private void ComboBox_NamHoc_HK_SelectedValueChanged(object sender, EventArgs e)
        {
            currentNamHoc_HK = ComboBox_NamHoc_HK.SelectedValue.ToString();
            LoadBCHocKy();
        }

        private void ComboBox_NamHoc_MH_SelectedValueChanged(object sender, EventArgs e)
        {
            currentNamHoc_MH = ComboBox_NamHoc_HK.SelectedValue.ToString();
            LoadBCMon();
        }

        void LoadDanhSachMonHoc()
        {
            ComboBox_MonHoc_MH.DataSource = monhoc.GetTatCaMonHoc();
            ComboBox_MonHoc_MH.DisplayMember = "TenMonHoc";
            ComboBox_MonHoc_MH.ValueMember = "MaMonHoc";

            currentMonHoc_MH = ComboBox_NamHoc_MH.SelectedValue.ToString();

            ComboBox_MonHoc_MH.SelectedValueChanged += ComboBox_MonHoc_MH_SelectedValueChanged;
        }

        private void ComboBox_MonHoc_MH_SelectedValueChanged(object sender, EventArgs e)
        {
            currentMonHoc_MH = ComboBox_MonHoc_MH.SelectedValue.ToString();
            LoadBCMon();
        }
    }
}
