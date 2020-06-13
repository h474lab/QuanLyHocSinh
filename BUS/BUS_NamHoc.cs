using DAO;
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
    }
}
