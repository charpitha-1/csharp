using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo
{
    internal class LaptopBuilder : IBuilder
    {
        public  IProduct laptop;
        public void AttachBattery()
        {
            Console.WriteLine("Laptop Battery installed");
        }

        public void AttachPanel()
        {
            Console.WriteLine("Laptop Panel installed");
        }

        public void BuildBasePanel()
        {
            Console.WriteLine("Laptop BasePanel installed");
        }

        public IProduct GetFinishProduct()
        {
            return laptop;
        }

        public void InstallOs()
        {
            Console.WriteLine("Laptop os installed");
        }
    }
}
