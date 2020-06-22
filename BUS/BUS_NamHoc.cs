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
    public class BUS_NamHoc
    {
        DAO_NamHoc namhoc = new DAO_NamHoc();
        public DataTable GetTatCaNH()
        {
            return namhoc.GetTatCaNamHoc();
        }
        public void Insert_NamHoc(string nambd, string namkt)
        {
            namhoc.Insert_NamHoc(nambd, namkt);
        }
        public void Update_NamHoc(NamHoc nh)
        {
            namhoc.Update_HocKy(nh);
        }
        public void Delete_NamHoc(string manh)
        {
            namhoc.Delete_NamHoc(manh);
        }
    }
}
