using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilePort
{
    public class FileManager
    {
        public string ReadFileContent(string path)
        {
            return "content read from" + path;
        }
        public string WriteFileContent(string path,bool overwrite)
        {
            return "content read from" + path;
        }
    }
    public class PathHelper
    {
        public  string ParsePath()
        {
            return "path is loaded";
        }
    }
}
