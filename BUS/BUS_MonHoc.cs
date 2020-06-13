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
    public class BUS_MonHoc
    {
        DAO_MonHoc monhoc = new DAO_MonHoc();
        public DataTable GetTatCaMonHoc()
        {
            return monhoc.GetTatCaMonHoc();
        }
        public void Insert_MonHoc(MonHoc mh)
        {
            monhoc.Insert_MonHoc(mh);
        }
        public void Update_MonHoc(MonHoc mh)
        {
            monhoc.Update_MonHoc(mh);
        }
        public void Delete_MonHoc(string mamh)
        {
            monhoc.Delete_MonHoc(mamh);
        }
    }
}
