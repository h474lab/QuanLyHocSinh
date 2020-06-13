using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class Form_TiepNhanHS : Form
    {
        BUS_HocSinh hocsinh = new BUS_HocSinh();
        BUS_ThamSo thamso = new BUS_ThamSo();
        string currentMaHS = "";

        private bool[] val = { false, false, false, false, false };

        public Form_TiepNhanHS()
        {
            InitializeComponent();
            Initialize();
            LoadThongTin();
        }
        private void Initialize()
        {
            RadioButton_Nam.Checked = true;
        }
        private void LoadThongTin()
        {
            // Load Danh sach Hoc sinh
            GridView_DSHocSinh.DataSource = hocsinh.GetTatCaHS();
            GridView_DSHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridView_DSHocSinh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView_DSHocSinh.ReadOnly = true;
            GridView_DSHocSinh.DefaultCellStyle.SelectionBackColor = Color.LightGreen;
            GridView_DSHocSinh.CellClick += GridView_DSHocSinh_CellClick;
        }
        private void GridView_DSHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = GridView_DSHocSinh.Rows[e.RowIndex];
                currentMaHS = row.Cells[0].Value.ToString();
                TextBox_HoTen.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "True")
                    RadioButton_Nam.Checked = true;
                else
                    RadioButton_Nu.Checked = true;
                DateTimePicker_NgaySinh.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                TextBox_DiaChi.Text = row.Cells[4].Value.ToString();
                TextBox_Email.Text = row.Cells[5].Value.ToString();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Button_Them_Click(object sender, EventArgs e)
        {
            HocSinh temp = new HocSinh();
            temp.HoTen = TextBox_HoTen.Text;
            if (RadioButton_Nam.Checked)
            {
                temp.GioiTinh = 1;
            } 
            else if (RadioButton_Nu.Checked)
            {
                temp.GioiTinh = 0;
            }
            temp.NgaySinh = DateTimePicker_NgaySinh.Value;
            temp.DiaChi = TextBox_DiaChi.Text;
            temp.Email = TextBox_Email.Text;
            hocsinh.Insert_HocSinh(temp);
            LoadThongTin();
        }

        private void Button_Sua_Click(object sender, EventArgs e)
        {
            if (currentMaHS == "") return;
            HocSinh temp = new HocSinh();
            temp.MaHocSinh = long.Parse(currentMaHS);
            temp.HoTen = TextBox_HoTen.Text;
            if (RadioButton_Nam.Checked)
            {
                temp.GioiTinh = 1;
            }
            else if (RadioButton_Nu.Checked)
            {
                temp.GioiTinh = 0;
            }
            temp.NgaySinh = DateTimePicker_NgaySinh.Value;
            temp.DiaChi = TextBox_DiaChi.Text;
            temp.Email = TextBox_Email.Text;
            hocsinh.Update_HocSinh(temp);
            LoadThongTin();
        }

        private void Button_Xoa_Click(object sender, EventArgs e)
        {
            if (currentMaHS == "") return;
            hocsinh.Delete_HocSinh(currentMaHS);
            currentMaHS = "";
            LoadThongTin();
        }
        // Dat bao hieu loi
        private void SetError(int index, string message)
        {
            switch (index)
            {
                case 0:
                    checkedProvider_HoTen.Clear();
                    errorProvider_HoTen.SetError(TextBox_HoTen, message);
                    break;
                case 1:
                    checkedProvider_NgaySinh.Clear();
                    errorProvider_NgaySinh.SetError(DateTimePicker_NgaySinh, message);
                    break;
                case 2:
                    checkedProvider_DiaChi.Clear();
                    errorProvider_DiaChi.SetError(TextBox_DiaChi, message);
                    break;
                case 3:
                    checkedProvider_DiaChi.Clear();
                    errorProvider_Email.SetError(TextBox_Email, message);
                    break;
            }
            val[index] = false;
        }
        // Dat bao hieu hop le
        private void SetChecked(int index, string message)
        {
            switch (index)
            {
                case 0:
                    errorProvider_HoTen.Clear();
                    checkedProvider_HoTen.SetError(TextBox_HoTen, message);
                    break;
                case 1:
                    errorProvider_NgaySinh.Clear();
                    checkedProvider_NgaySinh.SetError(DateTimePicker_NgaySinh, message);
                    break;
                case 2:
                    errorProvider_DiaChi.Clear();
                    checkedProvider_DiaChi.SetError(TextBox_DiaChi, message);
                    break;
                case 3:
                    errorProvider_Email.Clear();
                    checkedProvider_Email.SetError(TextBox_Email, message);
                    break;
            }
            val[index] = false;
        }
        private void TextBox_HoTen_Validating(object sender, CancelEventArgs e)
        {
            string hoten = TextBox_HoTen.Text;
            if (hoten == "")
            {
                SetError(0, "Họ tên không được để trống!");
                return;
            }
            SetChecked(0, "Thông tin hợp lệ!");
        }

        private void DateTimePicker_NgaySinh_Validating(object sender, CancelEventArgs e)
        {
            
        }
    }
}
