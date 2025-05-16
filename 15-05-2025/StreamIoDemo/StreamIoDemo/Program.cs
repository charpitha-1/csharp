using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StreamIoDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestStreamWriter();
            //TestStreamWriterWithEncoding(); //first write and after that read\
            //TestStreamReaderWithEncoding();
            //TestFileStream_Write();
            //TestFileStream_Read();
            //TestBinaryWriter();
            //TestBinaryReader();
            //TestStreamReader();
            ListFiles("C:\\Users\\thavishala.c");
        }
        private static void DoFileLoop()
        {
            //File.Copy();
            //File.Delete();
            //File.Move();
            //File.Exists();
        }
        private static void ListFiles(string FolderPath)
        {
            if (Directory.Exists(FolderPath))
            {
                string[] files = Directory.GetFiles(FolderPath);
                foreach (string file in files)
                {
                    Console.WriteLine("File  is about--->"+file);
                    FileInfo fileInfo = new FileInfo(file);
                    FileAttributes fileAttributes = fileInfo.Attributes;
                    
                }
                string[] dirs = Directory.GetDirectories(FolderPath);
                foreach (string dir in dirs)
                {
                    Console.WriteLine(dir);
                }
            }
        }
        private static void TestBinaryReader()
        {
            FileStream fs = new FileStream("file5.txt", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            long storedint = br.ReadInt64();//ReadInt32();
            double storeddouble=br.ReadDouble();
            Console.WriteLine(storedint);
            Console.WriteLine(storeddouble);
            br.Dispose();
        }
        
        private static void TestBinaryWriter()
        {
            FileStream fs = new FileStream("file5.txt", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs); 
            bw.Write(1200L);
            bw.Write(1233.34);
            bw.Dispose();
        }
        private static void TestFileStream_Write()
        {
            FileStream fs = new FileStream("file4.txt",FileMode.OpenOrCreate,FileAccess.Write);
            string strvalue = "My file stream is here";
            byte[] barr=System.Text.Encoding.UTF8.GetBytes(strvalue);
            Console.WriteLine(barr);
            fs.Write(barr, 0, barr.Length);//bytes[22]
            fs.Dispose();
        }
        private static void TestFileStream_Read()
        {
            FileStream ff = new FileStream("file4.txt", FileMode.Open, FileAccess.Read);
            long len=ff.Length;
            byte[] arrb=new byte[len];
            ff.Read(arrb, 0, arrb.Length);
            ff.Dispose();
            String output=System.Text.Encoding.UTF8.GetString(arrb);
            Console.WriteLine(output);
        }
        private static void TestStreamWriter()
        {

            string str = "My Test String2";
            StreamWriter writer = new StreamWriter("File2.txt");
            writer.WriteLine(str);
            writer.Dispose();
        }
        private static void TestStreamReader()
        {
            StreamReader reader = new StreamReader("File3.txt");

            //do
            //{
            //    string strout = reader.ReadLine();
            //    if (strout == null)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(strout);
            //} while (true);
            string strtotal = reader.ReadToEnd();//reading entire content at a time
            Console.WriteLine(strtotal);
            reader.Dispose();
        }
        private static void TestStreamWriterWithEncoding()
        {
            string str1 = "My Test String to read ";
            StreamWriter writer1 = new StreamWriter("File3.txt",false,Encoding.UTF32);
            writer1.WriteLine(str1);
            writer1.Dispose();
        }
        private static void TestStreamReaderWithEncoding()
        {
          
            StreamReader reader1 = new StreamReader("File3.txt", Encoding.UTF32);
            string strout1 = reader1.ReadLine();
            Console.WriteLine(strout1);
            reader1.Dispose();
        }
    }
}
