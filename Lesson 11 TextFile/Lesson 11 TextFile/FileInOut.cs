using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_11_TextFile
{
    public static class FileInOut
    {
        public static bool LuuFile(List<SanPham> sanPhams, string path)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path,false, Encoding.UTF8);
                foreach (SanPham sp in sanPhams)
                {
                    string line = sp.MaSP + "-" + sp.TenSP + "-" + sp.Gia;
                    sw.WriteLine(line);
                }
                sw.Close();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static List<SanPham> DocFile(string path)
        {
            List<SanPham> sanPhams = new List<SanPham>();
            StreamReader sr = new StreamReader(path, Encoding.UTF8);
            string line = sr.ReadLine();
            while (line!=null)
            {
                SanPham sp = new SanPham();
                string[] arr = line.Split('-');
                sp.TenSP = arr[0];
                sp.MaSP = arr[1];
                sp.Gia = double.Parse(arr[2]);
                sanPhams.Add(sp);
                line = sr.ReadLine();
            }
            return sanPhams;
        }
    }
}
