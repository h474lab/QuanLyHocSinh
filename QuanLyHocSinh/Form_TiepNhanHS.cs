using BUS;
using DTO;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class Form_TiepNhanHS : Form
    {
        BUS_HocSinh hocsinh = new BUS_HocSinh();
        BUS_ThamSo thamso = new BUS_ThamSo();
        string currentMaHS = "";

        ThamSo listThamSo = new ThamSo();

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

            listThamSo = thamso.GetThamSo();

            DateTimePicker_NgaySinh.Format = DateTimePickerFormat.Custom;
            DateTimePicker_NgaySinh.CustomFormat = "dd/MM/yyyy";
            DateTimePicker_NgaySinh.MaxDate = DateTime.Today.AddYears(-listThamSo.TuoiToiThieu);
            DateTimePicker_NgaySinh.MinDate = DateTime.Today.AddYears(-listThamSo.TuoiToiDa);

            TrackBar_CoChu.Value = int.Parse(GridView_DSHocSinh.Font.Size.ToString());
            TrackBar_CoChu.ValueChanged += TrackBar_CoChu_ValueChanged;
        }

        private void TrackBar_CoChu_ValueChanged(object sender, EventArgs e)
        {
            GridView_DSHocSinh.Font = new Font(GridView_DSHocSinh.Font.FontFamily.ToString(), TrackBar_CoChu.Value);
        }

        private void LoadThongTin()
        {
            DataTable temp = hocsinh.GetTatCaHS();
            temp.Columns.Add("GT", typeof(string));
            temp.Columns.Add("SoThuTu", typeof(int));
            temp.Columns.Add("NS", typeof(string));

            int stt = 1;
            foreach(DataRow row in temp.Rows)
            {
                row["SoThuTu"] = stt;
                stt++;

                if (row["GioiTinh"].ToString() == "True")
                {
                    row["GT"] = "Nam";
                }
                else
                {
                    row["GT"] = "Nữ";
                }
                row["NS"] = DateTime.Parse(row["NgaySinh"].ToString()).ToString("dd/MM/yyyy");
            }


            foreach (DataGridViewColumn column in GridView_DSHocSinh.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Load Danh sach Hoc sinh
            GridView_DSHocSinh.DataSource = temp;
            GridView_DSHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridView_DSHocSinh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView_DSHocSinh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            GridView_DSHocSinh.RowHeadersVisible = false;
            GridView_DSHocSinh.ReadOnly = true;
            GridView_DSHocSinh.CellClick += GridView_DSHocSinh_CellClick;

            // Edit theme
            GridView_DSHocSinh.BorderStyle = BorderStyle.FixedSingle;
            GridView_DSHocSinh.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            GridView_DSHocSinh.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            GridView_DSHocSinh.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            GridView_DSHocSinh.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            GridView_DSHocSinh.BackgroundColor = Color.White;

            GridView_DSHocSinh.EnableHeadersVisualStyles = false;
            GridView_DSHocSinh.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            GridView_DSHocSinh.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            GridView_DSHocSinh.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void GridView_DSHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = GridView_DSHocSinh.Rows[e.RowIndex];
                currentMaHS = row.Cells[0].Value.ToString();
                //Console.WriteLine(row.Cells[0].Value.ToString());
                TextBox_HoTen.Text = row.Cells[1].Value.ToString();
                //Console.WriteLine(row.Cells[2].Value.ToString());
                if (row.Cells[2].Value.ToString() == "True")
                    RadioButton_Nam.Checked = true;
                else
                    RadioButton_Nu.Checked = true;
                DateTimePicker_NgaySinh.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                //Console.WriteLine(row.Cells[5].Value.ToString());
                TextBox_DiaChi.Text = row.Cells[4].Value.ToString();
                TextBox_Email.Text = row.Cells[5].Value.ToString();
            } catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        private void Button_Them_Click(object sender, EventArgs e)
        {
            //if (!checkThongTin()) return;
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
            int? result = hocsinh.Insert_HocSinh(temp);
            if (result == 1)
            {
                MessageBox.Show("Dữ liệu đã được cập nhật", "Thêm thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Không thể cập nhật thông tin", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            currentMaHS = "";
            LoadThongTin();
            GridView_DSHocSinh.ClearSelection();
        }

        private void Button_Sua_Click(object sender, EventArgs e)
        {
            //if (!checkThongTin()) return;
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
            int? result = hocsinh.Update_HocSinh(temp);
            if (result == 1)
            {
                MessageBox.Show("Dữ liệu đã được cập nhật", "Cập nhật thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể cập nhật thông tin", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            currentMaHS = "";
            LoadThongTin();
            GridView_DSHocSinh.ClearSelection();
        }

        private void Button_Xoa_Click(object sender, EventArgs e)
        {
            //if (!checkThongTin()) return;
            Console.WriteLine(currentMaHS);
            if (currentMaHS == "") return;
            int? result = hocsinh.Delete_HocSinh(currentMaHS);
            if (result == 1)
            {
                MessageBox.Show("Dữ liệu đã được cập nhật", "Xóa thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể cập nhật thông tin", "Đã xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            currentMaHS = "";
            LoadThongTin();
            GridView_DSHocSinh.ClearSelection();
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
                    checkedProvider_Email.Clear();
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
            val[index] = true;
        }

        private bool checkThongTin()
        {
            foreach(bool v in val)
            {
                if (!v) return false;
            }
            return true;
        }

        private void TextBox_HoTen_Validating(object sender, CancelEventArgs e)
        {
            string hoten = TextBox_HoTen.Text;
            if (hoten == "")
            {
                SetError(0, "Họ tên không được để trống!");
                return;
            }
            else if (hoten.Length > 30)
            {
                SetError(0, "Họ tên phải có số kí tự nhỏ hơn 30!");
            }
            for (int i = 0; i < hoten.Length; i++)
                if (!char.IsWhiteSpace(hoten[i]) && !char.IsLetter(hoten[i]))
                {
                    SetError(0, "Họ tên chỉ được chứa chữ cái và khoảng trắng!");
                    return;
                }

            SetChecked(0, "Thông tin hợp lệ!");

            // Chuan hoa
            if (char.IsWhiteSpace(hoten[0]))
                hoten = hoten.Substring(1);
            if (char.IsWhiteSpace(hoten[hoten.Length - 1]))
                hoten = hoten.Substring(0, hoten.Length - 1);
            for (int i = 0; i < hoten.Length - 1; i++)
                if (char.IsWhiteSpace(hoten[i]))
                {
                    if (char.IsWhiteSpace(hoten[i + 1]))
                    {
                        hoten = hoten.Substring(0, i) + hoten.Substring(i + 1);
                        i--;
                    }
                    else if (char.IsLetter(hoten[i + 1]))
                        hoten = hoten.Substring(0, i + 1) + char.ToUpper(hoten[i + 1]) + hoten.Substring(i + 2);
                }
            if (char.IsLetter(hoten[0]))
                hoten = char.ToUpper(hoten[0]) + hoten.Substring(1);
            TextBox_HoTen.Text = hoten;
        }

        private void DateTimePicker_NgaySinh_Validating(object sender, CancelEventArgs e)
        {
            SetChecked(1, "Thông tin hợp lệ!");
        }

        private void TextBox_DiaChi_Validating(object sender, CancelEventArgs e)
        {
            string diachi = TextBox_DiaChi.Text;
            if (diachi == "")
            {
                SetError(2, "Địa chỉ không được để trống!");
                return;
            }
            else if (diachi.Length > 30)
            {
                SetError(2, "Địa chỉ phải có số kí tự nhỏ hơn 50!");
                return;
            }

            SetChecked(2, "Thông tin hợp lệ!");

            // Chuan hoa
            for (int i = 0; i < diachi.Length - 1; i++)
                if (char.IsWhiteSpace(diachi[i]))
                {
                    if (char.IsWhiteSpace(diachi[i + 1]))
                    {
                        diachi = diachi.Substring(0, i) + diachi.Substring(i + 1);
                        i--;
                    }
                }

        }

        private void TextBox_Email_Validating(object sender, CancelEventArgs e)
        {
            string email = TextBox_Email.Text;
            if (email == "")
            {
                SetError(3, "Email không được để trống!");
                return;
            }
            else if (email.Length > 40)
            {
                SetError(3, "Email phải có số kí tự nhỏ hơn 40!");
                return;
            }

            SetChecked(3, "Thông tin hợp lệ");
            // Chuan hoa
            for (int i = 0; i < email.Length - 1; i++)
                if (char.IsWhiteSpace(email[i]))
                {
                    if (char.IsWhiteSpace(email[i + 1]))
                    {
                        email = email.Substring(0, i) + email.Substring(i + 1);
                        i--;
                    }
                }
        }
    }
}
