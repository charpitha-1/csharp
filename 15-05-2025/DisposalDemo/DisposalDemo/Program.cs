using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposalDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FileManager fileManager1 = new FileManager("file4.txt");
            WriteContent();
            //byte[] b = new byte[byte.MaxValue];
            //GC.Collect();
            WriteContent();
          
        }
        private static void WriteContent()
        {
            //FileManager fileManager1 = new FileManager("file4.txt");
            //fileManager1.Dispose();
            using (FileManager fileManager1 = new FileManager("file4.txt"))
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("First Line");
                string stringfinal= sb.ToString();
            }//obi.Dispose()
        }
    }
}
