//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MyFirstPro
//{
//    internal class DataTypeCasting
//    {
//        static void main(string[] args)
//        {
//            var value1 = 10; //implicit typed local variable
//            Console.WriteLine(value1.GetType()); //system.int 32
//            var str = "test1";
//            Console.WriteLine(str.GetType()); //system.string

//            string name = "chariptha";
//            Console.WriteLine(name);

//            name = null;//assign null to string
//            int val3 = 10;
//            //val3 = null; //value type cast
//            string comment = "some comment says:\"is my comment\""; //escape character
//            Console.WriteLine(comment);
//            string comment1 =@"Path is:\is my comment\"; // "path is:\\is my comment\\"
//            Console.WriteLine(comment1);

//            char ch = 'A';//ASCII
//            int s = (int)ch;



//            int i = (int)100ul; //explicit conversion
//            ulong ul = 100;
//            float f = 12.34f;
//            double d = (double)12.3m; //m=money
//            byte b = 233;
//            int val = 123;
//            long v = 2344;
//            val = (int)v;

//            char ch = 'a';
//            int val2 = ch; //implicit
//            int ch2 =(int)ch;

//            //int val3; //local variables
//            //++val3;
//            Console.WriteLine(val2.GetType()); //get type is method on system.object
//            Type t=typeof(int); //typeof is operator
//            if(val2.GetType() == typeof(int))
//            {
//                Console.WriteLine("val2 is integer");
//            }

//        }
//    }
//}
