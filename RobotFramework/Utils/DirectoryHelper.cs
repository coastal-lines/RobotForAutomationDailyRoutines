using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotFramework.Utils
{
    public static class DirectoryHelper
    {
        public static List<string> GetListFilesFromDirectory(string path)
        {
            var listFiles = new List<string>();

            DirectoryInfo d = new DirectoryInfo(path);
            FileInfo[] files = d.GetFiles();
            List<string> listFilesPath = new List<string>();
            listFilesPath = files.Select(f => f.FullName).ToArray().ToList();

            return listFilesPath;
        }
    }
}
