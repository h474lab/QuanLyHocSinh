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
        BUS_DanhSachLop danhsachlop = new BUS_DanhSachLop();
        BUS_KhoiLop khoilop = new BUS_KhoiLop();
        BUS_MonHoc monhoc = new BUS_MonHoc();

        string currentMaLop = "";
        string currentKhoiLop = "";
        string currentMaMH = "";
        public Form_ThietLap()
        {
            InitializeComponent();

            SetQuyDinh();

            LoadDSLop();
            LoadDSMonHoc();
            LoadDSKhoi();
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
            TextBox_DiemDatMon.Text = temp.DiemDatMon.ToString();
        }
        void LoadDSLop()
        {
            GridView_DSLop.DataSource = danhsachlop.GetTatCaLop();
            GridView_DSLop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridView_DSLop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView_DSLop.ReadOnly = true;
            GridView_DSLop.DefaultCellStyle.SelectionBackColor = Color.LightGreen;
            GridView_DSLop.CellClick += GridView_DSLop_CellClick;
        }

        void LoadDSMonHoc()
        {
            GridView_DSMonHoc.DataSource = monhoc.GetTatCaMonHoc();
            GridView_DSMonHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridView_DSMonHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView_DSMonHoc.ReadOnly = true;
            GridView_DSMonHoc.DefaultCellStyle.SelectionBackColor = Color.LightGreen;
            GridView_DSMonHoc.CellClick += GridView_DSMonHoc_CellClick;
        }

        private void GridView_DSMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = GridView_DSMonHoc.Rows[e.RowIndex];
                currentMaMH = row.Cells[0].Value.ToString();
                TextBox_TenMonHoc.Text = row.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void LoadDSKhoi()
        {
            ComboBox_KhoiLop.DataSource = khoilop.GetTatCaKhoiLop();
            ComboBox_KhoiLop.DisplayMember = "TenKhoiLop";
            ComboBox_KhoiLop.ValueMember = "MaKhoiLop";
            currentKhoiLop = ComboBox_KhoiLop.SelectedValue.ToString();
            ComboBox_KhoiLop.SelectedValueChanged += ComboBox_KhoiLop_SelectedValueChanged;
        }

        private void ComboBox_KhoiLop_SelectedValueChanged(object sender, EventArgs e)
        {
            currentKhoiLop = ComboBox_KhoiLop.SelectedValue.ToString();
        }

        private void GridView_DSLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = GridView_DSLop.Rows[e.RowIndex];
                currentMaLop = row.Cells[0].Value.ToString();
                TextBox_TenLop.Text = row.Cells[1].Value.ToString();
                ComboBox_KhoiLop.SelectedValue = int.Parse(row.Cells[3].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                MessageBox.Show("Thông tin không hợp lệ!", "Không thể lưu", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                double DiemDatMon = double.Parse(TextBox_DiemDatMon.Text);
                ThamSo temp = new ThamSo(TuoiMin, TuoiMax, SiSoMax, DiemMin, DiemMax, DiemDat, DiemDatMon);
                thamso.UpdateThamSo(temp);
            }
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_ThemLop_Click(object sender, EventArgs e)
        {
            DanhSachLop dslop = new DanhSachLop();
            dslop.TenLop = TextBox_TenLop.Text;
            dslop.SiSo = 0;
            dslop.MaKhoiLop = long.Parse(currentKhoiLop);
            danhsachlop.Insert_Lop(dslop);
            LoadDSLop();
        }

        private void Button_SuaLop_Click(object sender, EventArgs e)
        {
            if (currentMaLop == "") return;
            DanhSachLop dslop = new DanhSachLop();
            dslop.MaLop = long.Parse(currentMaLop);
            dslop.TenLop = TextBox_TenLop.Text;
            dslop.MaKhoiLop = long.Parse(ComboBox_KhoiLop.SelectedValue.ToString());
            danhsachlop.Update_Lop(dslop);
            LoadDSLop();
        }

        private void Button_XoaLop_Click(object sender, EventArgs e)
        {
            if (currentMaLop == "") return;
            danhsachlop.Delete_Lop(currentMaLop);
        }

        private void Button_ThemMon_Click(object sender, EventArgs e)
        {
            MonHoc mh = new MonHoc();
            mh.TenMonHoc = TextBox_TenMonHoc.Text;
            monhoc.Insert_MonHoc(mh);
            LoadDSMonHoc();
        }

        private void Button_SuaMon_Click(object sender, EventArgs e)
        {
            if (currentMaMH == "") return;
            MonHoc mh = new MonHoc();
            mh.MaMonHoc = long.Parse(currentMaMH);
            mh.TenMonHoc = TextBox_TenMonHoc.Text;
            monhoc.Update_MonHoc(mh);
            LoadDSMonHoc();
        }

        private void Button_XoaMon_Click(object sender, EventArgs e)
        {
            if (currentMaMH == "") return;
            monhoc.Delete_MonHoc(currentMaMH);
            LoadDSMonHoc();
        }
    }
}
