using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_07_ListView
{
    public class ToaNhaHoc
    {
        public string MaToaNha { get; set; }
        public string TenToaNha { get; set; }
        public List<PhongHoc> PhongHocs { get; set; }
        public ToaNhaHoc()
        {
            PhongHocs = new List<PhongHoc>();
        }
        public void themPhong(PhongHoc ph)
        {
            PhongHocs.Add(ph);
            ph.ToaNha = this;
        }
    }
}
