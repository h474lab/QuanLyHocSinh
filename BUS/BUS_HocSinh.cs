using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_HocSinh
    {
        DAO_HocSinh hocsinh = new DAO_HocSinh();
        public DataTable GetTatCaHS()
        {
            return hocsinh.GetTatCaHocSinh();
        }
        public void Insert_HocSinh(HocSinh hs)
        {
            hocsinh.Insert_HocSinh(hs);
        }
        public void Update_HocSinh(HocSinh hs)
        {
            hocsinh.Update_HocSinh(hs);
        }
        public void Delete_HocSinh(string MaHS)
        {
            hocsinh.Delete_HocSinh(MaHS);
        }
        public DataTable GetHocSinhCho(string mahk, string manh)
        {
            return hocsinh.GetHocSinhCho(mahk, manh);
        }
        public DataTable GetHocSinh(string malop, string mahk, string manh)
        {
            return hocsinh.GetHocSinh(malop, mahk, manh);
        }
        public void AddHocSinhVaoLop(string mahs, string malop, string mahk, string manh)
        {
            hocsinh.AddHocSinhVaoLop(mahs, malop, mahk, manh);
        }
        public void Delete_HSTrongLop(string mahs, string malop, string mahk, string manh)
        {
            hocsinh.Delete_HSTrongLop(mahs, malop, mahk, manh);
        }
    }
}
