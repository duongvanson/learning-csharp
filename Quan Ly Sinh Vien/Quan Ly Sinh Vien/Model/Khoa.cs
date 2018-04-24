using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Sinh_Vien
{
    [Serializable]
    public class Khoa
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public Dictionary<string, LopHoc> Lops { get; set; }
        public Khoa()
        {
            Lops = new Dictionary<string, LopHoc>();
        }
        public override string ToString()
        {
            return Ten;
        }
    }
}
