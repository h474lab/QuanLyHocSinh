using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Diem
    {
        public DAO_Diem diem = new DAO_Diem();
        public double? GetDiem(string mahs, string mahk, string manh, string mamh, string makt)
        {
            return diem.GetDiem(mahs, mamh, mahk, manh, makt);
        }
        public void Insert_Diem(string mahs, string malop, string mahk, string manh, string mamh, string makt, double? d)
        {
            diem.Insert_Diem(mahs, malop, mahk, manh, mamh, makt, d);
        }
        public void Update_Diem(string mahs, string malop, string mahk, string manh, string mamh, string makt, double? d)
        {
            diem.Update_Diem(mahs, malop, mahk, manh, mamh, makt, d);
        }
        public void Delete_Diem(string mahs, string malop, string mahk, string manh, string mamh, string makt)
        {
            diem.Delete_Diem(mahs, malop, mahk, manh, mamh, makt);
        }
        public double? GetDiemTBHK(string mahs, string manh, string tenhk)
        {
            return diem.GetDiemTBHK(mahs, manh, tenhk);
        }
    }
}
