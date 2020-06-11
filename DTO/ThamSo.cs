using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThamSo
    {
        public int TuoiToiThieu { get; set; }
        public int TuoiToiDa { get; set; }
        public int SiSoToiDa { get; set; }
        public double DiemToiThieu { get; set; }
        public double DiemToiDa { get; set; }
        public double DiemDat { get; set; }
        public ThamSo() { }
        public ThamSo(int tuoimin, int tuoimax, int sisomax, float diemmin, float diemmax, float diemdat)
        {
            TuoiToiThieu = tuoimin;
            TuoiToiDa = tuoimax;
            SiSoToiDa = sisomax;
            DiemToiThieu = diemmin;
            DiemToiDa = diemmax;
            DiemDat = diemdat;
        }
    }
}
