using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    internal class MathOperations
    {
        public  void Sub(int a, int b)
        {
            Console.WriteLine("sub: " + (a - b));
        }
        public  int Add(int a, int b)
        {
            return (a + b); 
        }
    }
}
