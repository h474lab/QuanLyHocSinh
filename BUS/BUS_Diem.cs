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
        public void Insert_Diem(Diem d)
        {
            diem.Insert_Diem(d);
        }
        public void Update_Diem(Diem d)
        {
            diem.Update_Diem(d);
        }
        public void Delete_Diem(Diem d)
        {
            diem.Delete_Diem(d);
        }
    }
}
