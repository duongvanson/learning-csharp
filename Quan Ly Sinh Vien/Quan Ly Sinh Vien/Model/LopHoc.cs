using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Sinh_Vien
{
    [Serializable]
    public class LopHoc
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public Dictionary<string, SinhVien> SinhViens { get; set; }
        public Khoa KhoaChuQuan { get; set; }
        public LopHoc()
        {
            SinhViens = new Dictionary<string, SinhVien>();
        }
        public override string ToString()
        {
            return Ten;
        }
    }
}
