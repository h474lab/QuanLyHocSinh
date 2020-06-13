using DAO;
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
    }
}
