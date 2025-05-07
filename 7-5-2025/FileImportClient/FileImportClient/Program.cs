using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilePort;

namespace FileImportClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileManager fm= new FileManager();
            string result = fm.ReadFileContent(@"c;/charpitha");
            Console.WriteLine(result);
        }
    }
}
