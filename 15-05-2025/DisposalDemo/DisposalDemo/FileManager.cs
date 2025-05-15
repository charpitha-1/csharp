using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposalDemo
{
    internal class FileManager:IDisposable
    {
        FileStream fileStream;
        public FileManager(string filepath) {
            //open the file at specified path in binary mode
            fileStream = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);
            Console.WriteLine("File Opened for Writing");
        }
        ~FileManager() { //destructor -->but not depend on this we should provide a method to close the file we use IDisposable
            if (fileStream != null)
           {
                fileStream.Close();
                Console.WriteLine("File Closed from destructor");
           }
        }

        public void Dispose()
        {
            if (fileStream != null)
            {
                fileStream.Close();
                Console.WriteLine("File Closed from disposable");
                GC.SuppressFinalize(this);//Donot call destructor
            }
        }
    }
}
