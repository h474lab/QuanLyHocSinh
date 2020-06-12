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
    public partial class Form_TiepNhanHS : Form
    {
        BUS_HocSinh hocsinh = new BUS_HocSinh();
        string currentMaHS = "";
        public Form_TiepNhanHS()
        {
            InitializeComponent();

            LoadThongTin();
        }
        private void LoadThongTin()
        {
            GridView_DSHocSinh.DataSource = hocsinh.GetTatCaHS();
            GridView_DSHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridView_DSHocSinh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView_DSHocSinh.ReadOnly = true;
            GridView_DSHocSinh.CellClick += GridView_DSHocSinh_CellClick;
        }

        private void GridView_DSHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
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
    }
}
