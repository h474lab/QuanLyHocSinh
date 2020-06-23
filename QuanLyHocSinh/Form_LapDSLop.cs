using BUS;
using DTO;
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
    public partial class Form_LapDSLop : Form
    {
        BUS_DanhSachLop danhsachlop = new BUS_DanhSachLop();
        BUS_HocSinh hocsinh = new BUS_HocSinh();
        BUS_HocKy hocky = new BUS_HocKy();
        BUS_NamHoc namhoc = new BUS_NamHoc();
        BUS_ThamSo thamso = new BUS_ThamSo();

        ThamSo listThamSo = new ThamSo();

        string currentLop = "";
        string currentHocKy = "";
        string currentNamHoc = "";
        string currentHSLop = "";
        string currentHSCho = "";

        public Form_LapDSLop()
        {
            InitializeComponent();

            listThamSo = thamso.GetThamSo();

            LoadDanhSachLop();
            LoadDanhSachHocKy();
            LoadDanhSachNamHoc();
            LoadDanhSachHocSinh();
            LoadHocSinhCho();
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
            LoadDanhSachHocSinh();
            LoadHocSinhCho();
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
            LoadDanhSachHocSinh();
            LoadHocSinhCho();
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
            LoadDanhSachHocSinh();
            LoadHocSinhCho();
        }

        void LoadDanhSachHocSinh()
        {
            if (currentLop == "" | currentHocKy == "" | currentNamHoc == "") return;
            DataTable temp = hocsinh.GetHocSinh(currentLop, currentHocKy, currentNamHoc);
            temp.Columns.Add("GT", typeof(string));
            temp.Columns.Add("SoThuTu", typeof(int));

            int stt = 1;
            foreach(DataRow row in temp.Rows)
            {
                row["SoThuTu"] = stt;
                stt++;
                if (row["GioiTinh"].ToString() == "True")
                    row["GT"] = "Nam";
                else
                    row["GT"] = "Nữ";
            }
            GridView_DSLop.DataSource = temp;
            GridView_DSLop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridView_DSLop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView_DSLop.ReadOnly = true;
            GridView_DSLop.ClearSelection();

            TextBox_SiSo.Text = danhsachlop.GetSiSo(currentLop, currentHocKy, currentNamHoc).ToString();

            GridView_DSLop.CellClick += GridView_DSLop_CellClick;

            // Edit theme
            GridView_DSLop.BorderStyle = BorderStyle.FixedSingle;
            GridView_DSLop.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            GridView_DSLop.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            GridView_DSLop.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            GridView_DSLop.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            GridView_DSLop.BackgroundColor = Color.White;

            GridView_DSLop.EnableHeadersVisualStyles = false;
            GridView_DSLop.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            GridView_DSLop.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            GridView_DSLop.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void GridView_DSLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = GridView_DSLop.Rows[e.RowIndex];
                currentHSLop = row.Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void LoadHocSinhCho()
        {
            DataTable temp = hocsinh.GetHocSinhCho(currentHocKy, currentNamHoc);
            temp.Columns.Add("GT", typeof(string));
            temp.Columns.Add("SoThuTu", typeof(int));

            int stt = 1;
            foreach (DataRow row in temp.Rows)
            {
                row["SoThuTu"] = stt;
                stt++;
                if (row["GioiTinh"].ToString() == "True")
                    row["GT"] = "Nam";
                else
                    row["GT"] = "Nữ";
            }
            GridView_DSCho.DataSource = temp;
            GridView_DSCho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridView_DSCho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView_DSCho.ReadOnly = true;
            GridView_DSCho.DefaultCellStyle.SelectionBackColor = Color.LightGreen;
            GridView_DSCho.CellClick += GridView_DSCho_CellClick;

            // Edit theme
            GridView_DSCho.BorderStyle = BorderStyle.FixedSingle;
            GridView_DSCho.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            GridView_DSCho.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            GridView_DSCho.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            GridView_DSCho.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            GridView_DSCho.BackgroundColor = Color.White;

            GridView_DSCho.EnableHeadersVisualStyles = false;
            GridView_DSCho.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            GridView_DSCho.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            GridView_DSCho.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void GridView_DSCho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = GridView_DSCho.Rows[e.RowIndex];
                currentHSCho = row.Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void Button_Them_Click(object sender, EventArgs e)
        {
            if (currentHSCho == "")
            {
                MessageBox.Show("Vui lòng chọn học sinh để tiếp tục!", "Chưa chọn học sinh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.Parse(TextBox_SiSo.Text) < listThamSo.SiSoToiDa)
                hocsinh.AddHocSinhVaoLop(currentHSCho, currentLop, currentHocKy, currentNamHoc);
            else
            {
                MessageBox.Show("Lớp đã đạt sĩ số tối đa", "Không thể thêm học sinh vào lớp!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
                
            LoadDanhSachHocSinh();
            LoadHocSinhCho();
        }

        private void Button_Xoa_Click(object sender, EventArgs e)
        {
            if (currentHSLop == "")
            {
                MessageBox.Show("Vui lòng chọn học sinh để tiếp tục!", "Chưa chọn học sinh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            hocsinh.Delete_HSTrongLop(currentHSLop, currentLop, currentHocKy, currentNamHoc);
            LoadDanhSachHocSinh();
            LoadHocSinhCho();
        }
    }
}
