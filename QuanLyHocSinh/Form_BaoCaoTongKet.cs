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
        BUS_BCHocKy bchocky = new BUS_BCHocKy();

        string currentLop = "";
        string currentHocKy = "";
        string currentNamHoc = "";

        public Form_BaoCaoTongKet()
        {
            InitializeComponent();

            LoadDanhSachHocKy();
            LoadDanhSachNamHoc();
            LoadDanhSachCacLop();
        }

        void LoadDanhSachCacLop()
        {
            if (currentHocKy == "" | currentNamHoc == "") return;
            GridView_BCHocKy.DataSource = bchocky.GetBCHocKy(currentHocKy, currentNamHoc);
            GridView_BCHocKy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridView_BCHocKy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView_BCHocKy.ReadOnly = true;
            GridView_BCHocKy.DefaultCellStyle.SelectionBackColor = Color.LightGreen;


            // Edit theme
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

        void LoadDanhSachHocKy()
        {
            DataTable temp = hocky.GetTatCaHK();

            ComboBox_HocKy_HK.DataSource = temp;
            ComboBox_HocKy_HK.DisplayMember = "TenHocKy";
            ComboBox_HocKy_HK.ValueMember = "MaHocKy";

            currentHocKy = ComboBox_HocKy_HK.SelectedValue.ToString();

            ComboBox_HocKy_HK.SelectedValueChanged += ComboBox_HocKy_HK_SelectedValueChanged;

            ComboBox_HocKy_MH.DataSource = temp;
            ComboBox_HocKy_MH.DisplayMember = "TenHocKy";
            ComboBox_HocKy_MH.ValueMember = "MaHocKy";

            currentHocKy = ComboBox_HocKy_MH.SelectedValue.ToString();

            ComboBox_HocKy_MH.SelectedValueChanged += ComboBox_HocKy_MH_SelectedValueChanged;
        }

        private void ComboBox_HocKy_HK_SelectedValueChanged(object sender, EventArgs e)
        {
            currentHocKy = ComboBox_HocKy_HK.SelectedValue.ToString();
        }

        private void ComboBox_HocKy_MH_SelectedValueChanged(object sender, EventArgs e)
        {
            currentHocKy = ComboBox_HocKy_HK.SelectedValue.ToString();
        }

        void LoadDanhSachNamHoc()
        {
            DataTable temp = namhoc.GetTatCaNH();
            temp.Columns.Add("Full_NamHoc", typeof(string), "NamBD + ' - ' + NamKT");
            ComboBox_NamHoc_HK.DataSource = temp;
            ComboBox_NamHoc_HK.DisplayMember = "Full_NamHoc";
            ComboBox_NamHoc_HK.ValueMember = "MaNamHoc";

            currentNamHoc = ComboBox_NamHoc_HK.SelectedValue.ToString();

            ComboBox_NamHoc_HK.SelectedValueChanged += ComboBox_NamHoc_HK_SelectedValueChanged;

            ComboBox_NamHoc_MH.DataSource = temp;
            ComboBox_NamHoc_MH.DisplayMember = "Full_NamHoc";
            ComboBox_NamHoc_MH.ValueMember = "MaNamHoc";

            currentNamHoc = ComboBox_NamHoc_MH.SelectedValue.ToString();

            ComboBox_NamHoc_MH.SelectedValueChanged += ComboBox_NamHoc_MH_SelectedValueChanged;
        }

        private void ComboBox_NamHoc_HK_SelectedValueChanged(object sender, EventArgs e)
        {
            currentNamHoc = ComboBox_NamHoc_HK.SelectedValue.ToString();
        }

        private void ComboBox_NamHoc_MH_SelectedValueChanged(object sender, EventArgs e)
        {
            currentNamHoc = ComboBox_NamHoc_HK.SelectedValue.ToString();
        }

    }
}
