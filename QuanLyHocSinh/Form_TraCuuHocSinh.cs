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
    public partial class Form_TraCuuHocSinh : Form
    {
        BUS_HocSinh hocsinh = new BUS_HocSinh();
        BUS_NamHoc namhoc = new BUS_NamHoc();
        BUS_DanhSachLop danhsachlop = new BUS_DanhSachLop();

        string currentNamHoc = "";
        string currentLop = "";

        public Form_TraCuuHocSinh()
        {
            InitializeComponent();

            init();

            LoadDanhSachLop();
            LoadDanhSachNamHoc();
            LoadThongTin();
        }

        private void init()
        {
            TextBox_HoTen.TextChanged += TextBox_HoTen_TextChanged;

            TrackBar_CoChu.Value = int.Parse(GridView_DSHocSinh.Font.Size.ToString());
            TrackBar_CoChu.ValueChanged += TrackBar_CoChu_ValueChanged;
        }

        private void TrackBar_CoChu_ValueChanged(object sender, EventArgs e)
        {
            GridView_DSHocSinh.Font = new Font(GridView_DSHocSinh.Font.FontFamily.ToString(), TrackBar_CoChu.Value);
        }

        private void TextBox_HoTen_TextChanged(object sender, EventArgs e)
        {
            LoadThongTin();
        }

        private void LoadThongTin()
        {
            DataTable temp = hocsinh.GetThongTinTraCuu(TextBox_HoTen.Text, currentNamHoc);
            // Load Danh sach Hoc sinh
            GridView_DSHocSinh.DataSource = temp;
            GridView_DSHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridView_DSHocSinh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView_DSHocSinh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            GridView_DSHocSinh.ReadOnly = true;

            foreach(DataGridViewColumn column in GridView_DSHocSinh.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Edit theme
            GridView_DSHocSinh.BorderStyle = BorderStyle.FixedSingle;
            GridView_DSHocSinh.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            GridView_DSHocSinh.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            GridView_DSHocSinh.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            GridView_DSHocSinh.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            GridView_DSHocSinh.BackgroundColor = Color.White;

            GridView_DSHocSinh.EnableHeadersVisualStyles = false;
            GridView_DSHocSinh.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            GridView_DSHocSinh.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            GridView_DSHocSinh.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
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
            LoadThongTin();
        }
    }
}
