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

        string currentNamHoc = "";

        public Form_TraCuuHocSinh()
        {
            InitializeComponent();

            TextBox_HoTen.TextChanged += TextBox_HoTen_TextChanged;

            LoadDanhSachNamHoc();
            LoadThongTin();
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
            GridView_DSHocSinh.ReadOnly = true;

            // Edit theme
            GridView_DSHocSinh.BorderStyle = BorderStyle.None;
            GridView_DSHocSinh.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            GridView_DSHocSinh.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            GridView_DSHocSinh.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            GridView_DSHocSinh.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            GridView_DSHocSinh.BackgroundColor = Color.White;

            GridView_DSHocSinh.EnableHeadersVisualStyles = false;
            GridView_DSHocSinh.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            GridView_DSHocSinh.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            GridView_DSHocSinh.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
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
