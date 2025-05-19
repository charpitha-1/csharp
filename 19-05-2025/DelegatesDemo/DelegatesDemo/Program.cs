using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    internal class Program
    {
        public delegate void DoOPeration(int a, int b);//definition
        public delegate int MyOperation(int a,int b);
        static void Main(string[] args)
        {
            MathOperations maths=new MathOperations();
            MyOperation ops = maths.Add;
            int res = ops(10, 34);
            Console.WriteLine(res);
           //DoOPeration doAdd = new DoOPeration(Add); //instance creation
           //doAdd(12, 3); //invoke delegate ...Indirect calling
           //Add(1, 2); //normal  calling
           //DoOPeration dosub = new DoOPeration(Sub); //instance creation
           //dosub(12, 3);
           //DoOPeration doAdd1 = Add; //delegate Infrernce
           //doAdd1(10, 20);
           //DoOPeration dosub1 = Sub;
           //dosub1(40, 20);
           //Invoking multiple method with safe delegate reference
           //multicasting:calling all the referenced methods in sequence 
           //DoOPeration DoMul = Add;
           // DoMul += Sub;
           // DoMul(4, 2);
           // DoOPeration annDelegate = delegate (int x, int y) //annoyomous delegate
           // {
           //    Console.WriteLine("anno delegate :"+(x + y));
           // };
           // annDelegate(1, 2);
           // DoOPeration annmDelegate = (x, y) => //lambda expression
           // {
           //     Console.WriteLine("Lambada exp: " + (x + y));
           // };
           // annmDelegate(10, 2);
        }

        public static void Sub(int a, int b)
        {
            Console.WriteLine("sub: "+(a - b));
        }
        public static void Add2(int a,int b)
        {
            Console.WriteLine("add: "+(a + b));
        }
    }
}
