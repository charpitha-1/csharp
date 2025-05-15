using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo
{
    internal class MobileBuilder : IBuilder
    {
        private IProduct mobile;
        public void AttachBattery()
        {
            Console.WriteLine("Mobile Battery installed");
        }

        public void AttachPanel()
        {
            Console.WriteLine("Mobile Panel installed");
        }

        public void BuildBasePanel()
        {
            Console.WriteLine("Mobile BasePanel installed");
        }

        public IProduct GetFinishProduct()
        {
            return mobile;
        }

        public void InstallOs()
        {
            Console.WriteLine("Mobile os installed");
        }
    }
}
