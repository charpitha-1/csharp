using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo
{
    internal class GadgetDirector
    {
        IBuilder _builder;
        public GadgetDirector(IBuilder builder)
        {
            _builder = builder;
        }
        public IProduct BuildGadget()
        {
            _builder.BuildBasePanel();
            _builder.AttachPanel();
            _builder.AttachBattery();
            _builder.InstallOs();
            return _builder.GetFinishProduct();
        }
    }
}
