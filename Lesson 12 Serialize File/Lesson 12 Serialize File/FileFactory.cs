using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
namespace Lesson_12_Serialize_File
{
    public static class FileFactory
    {
        public static bool saveFile(List<SanPham> sanPhams, string path)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, sanPhams);
                fs.Close();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static List<SanPham> openFile(string path)
        {
            List<SanPham> sanPhams = new List<SanPham>();
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            sanPhams = bf.Deserialize(fs) as List<SanPham>;
            fs.Close();
            return sanPhams;
        }
    }
}
