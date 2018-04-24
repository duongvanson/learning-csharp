using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
namespace Quan_Ly_Sinh_Vien.io
{
    public class FileFactory
    {
        public static bool saveFile(Dictionary<string, Khoa> database, string path)
        {
            try
            {
                FileStream fs = new FileStream(path,FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs,database);
                fs.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static Dictionary<string, Khoa> openFile(string path)
        {
            Dictionary<string, Khoa> db = new Dictionary<string, Khoa>();
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            db = bf.Deserialize(fs) as Dictionary<string, Khoa>;
            return db;
        }
    }
}
