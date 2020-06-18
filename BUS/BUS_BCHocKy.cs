using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_BCHocKy
    {
        BUS_DanhSachLop danhsachlop = new BUS_DanhSachLop();
        DAO_BCHocKy bchocky = new DAO_BCHocKy();

        public int? GetSLDat(string malop, string mahk, string manh)
        {
            return bchocky.GetSLDat(malop, mahk, manh);
        }
        public DataTable GetBCHocKy(string mahk, string manh)
        {
            DataTable result = danhsachlop.GetTatCaLop();

            result.Columns.Remove("MaKhoiLop");
            result.Columns.Add("SoLuongDat", typeof(int));
            result.Columns.Add("TiLe", typeof(float));

            foreach(DataRow row in result.Rows)
            {
                string malop = row["MaLop"].ToString();
                row["SoLuongDat"] = (object)this.GetSLDat(malop, mahk, manh) ?? DBNull.Value;
            }

            return result;
        }
    }
}
