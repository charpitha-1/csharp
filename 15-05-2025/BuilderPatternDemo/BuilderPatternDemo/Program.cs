using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            IBuilder mobilebuilder=new MobileBuilder();
            GadgetDirector gadgetDirector = new GadgetDirector(mobilebuilder);
            IProduct finishproduct = gadgetDirector.BuildGadget();
            IBuilder laptopbuilder=new LaptopBuilder();
            GadgetDirector gadgetDirector1=new GadgetDirector(laptopbuilder);
            finishproduct= gadgetDirector1.BuildGadget();
        }
    }
}
