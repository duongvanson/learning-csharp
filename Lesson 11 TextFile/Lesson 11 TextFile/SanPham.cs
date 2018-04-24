using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11_TextFile
{
    public class SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public double Gia { get; set; }
        public override string ToString()
        {
            return MaSP+"\t"+TenSP+"\t"+Gia;
        }
    }
}
