using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_07_ListView
{
    public class SinhVien
    {
        public string Ma { get; set; }
        public string HoTen { get; set; }
        public string Lop { get; set; }
        public SinhVien(string ma, string hoTen, string lop)
        {
            this.Ma = ma;
            this.HoTen = hoTen;
            this.Lop = lop;
        }
    }
}
