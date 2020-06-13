using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DanhSachLop
    {
        DAO_DanhSachLop danhsachlop = new DAO_DanhSachLop();
        public DataTable GetTatCaLop()
        {
            return danhsachlop.GetTatCaLop();
        }
        public void Insert_Lop(DanhSachLop lop)
        {
            danhsachlop.Insert_Lop(lop);
        }
        public void Update_Lop(DanhSachLop lop)
        {
            danhsachlop.Update_Lop(lop);
        }
        public void Delete_Lop(string malop)
        {
            danhsachlop.Delete_Lop(malop);
        }
    }
}
