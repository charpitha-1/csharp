using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo
{
    internal interface IBuilder
    {
        void BuildBasePanel();
        void AttachPanel();
        void AttachBattery();
        void InstallOs();
        IProduct GetFinishProduct();

    }
}
