using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class MonHoc
    {
        public long MaMonHoc { get; set; }
        public string TenMonHoc { get; set; }
        MonHoc(long mamh, string tenmh)
        {
            MaMonHoc = mamh;
            TenMonHoc = tenmh;
        }
    }
}
