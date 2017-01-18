using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public static class FileAPI
    {
        static string _rootPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)));
        static string _folderPath = _rootPath + "\\Data\\";

        public static string FilePath(string filename)
        {
            return new Uri(_folderPath + filename).LocalPath;
        }

        public static string Read(string filename)
        {
            string localPath = FilePath(filename);

            return File.ReadAllText(localPath);
        }
    }
}
