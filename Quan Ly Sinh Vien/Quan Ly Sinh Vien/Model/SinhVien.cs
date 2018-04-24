using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Sinh_Vien
{
    [Serializable]
    public class SinhVien
    {
        public string Ma { get; set; }
        public string HoTen { get; set; }
        public bool GioiTinh { get; set; }
        public int NamSinh { get; set; }
        public LopHoc LopChuQuan { get; set; }
        public override string ToString()
        {
            return HoTen;
        }
    }
}
