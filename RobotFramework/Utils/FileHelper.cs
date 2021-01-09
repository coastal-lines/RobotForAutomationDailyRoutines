using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotFramework.Utils
{
    public static class FileHelper
    {
        public static string GetTextFromFile(string path)
        {
            var reader = new StreamReader(new FileStream(path, FileMode.Open));
            var text = reader.ReadToEnd();
            reader.Close();
            reader.Dispose();

            return text;
        }
    }
}
