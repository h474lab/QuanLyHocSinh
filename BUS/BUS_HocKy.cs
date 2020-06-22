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
    public class BUS_HocKy
    {
        DAO_HocKy hocky = new DAO_HocKy();
        public DataTable GetTatCaHK()
        {
            return hocky.GetTatCaHocKy();
        }
        public void Insert_HocKy(string tenhk)
        {
            hocky.Insert_HocKy(tenhk);
        }
        public void Update_HocKy(HocKy hk)
        {
            hocky.Update_HocKy(hk);
        }
        public void Delete_HocKy(string mahk)
        {
            hocky.Delete_HocKy(mahk);
        }
    }
}
