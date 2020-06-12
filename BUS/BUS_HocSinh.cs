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
    }
}
