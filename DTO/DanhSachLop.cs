using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DanhSachLop
    {
        public long MaLop { get; set; }
        public string TenLop { get; set; }
        public int SiSo { get; set; }
        public KhoiLop MaKhoiLop { get; set; }
    }
}
