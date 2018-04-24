using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12_Serialize_File
{
    [Serializable]
    public class SanPham
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public double Gia { get; set; }
        public override string ToString()
        {
            return Ma+"\t"+Ten+"\t"+Gia;
        }
    }
}
