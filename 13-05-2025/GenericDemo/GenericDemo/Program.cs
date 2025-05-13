using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    GenericAdd(12, 13);
            //    GenericAdd(13.3, 14.56);
            //    MyClass myClass = new MyClass();
            //    string res=myClass.display(56);
            //    Console.WriteLine(res);
            //    MyClass2 myClass2 = new MyClass2();
            //    bool res1 = myClass2.compare("char","wgch");
            //    Console.WriteLine(res1);
            ObjectBasedTest objectBasedTest = new ObjectBasedTest();
            objectBasedTest.TestHashTable();
            BasicCollectionsTest l = new BasicCollectionsTest();
            l.TestList();
            l.TestList2();
        }      
        public static int Add(int a, int b) { 
            return a + b;
        }
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static void GenericAdd<T>(T a,T b) //generic methods
        {
            Console.WriteLine(a + " " + b);
        }
        public interface ICalc<T,K> //generic interface
        {
            K display(T inp); //interface method
        }
        public class MyClass:ICalc<int,string> //we can have two datatypes at one here passing value as int and returning as string type
        {
            public string display(int inp)
            {
                return inp.ToString();
            }
        }
        public interface ICompare<T> where T : class
        {
            bool compare(T a, T b);
        }
        public class MyClass2 : ICompare<string>
        {
            public bool compare(string a, string b)
            {
                return a.Equals(b);
            }
        }
    }
}
