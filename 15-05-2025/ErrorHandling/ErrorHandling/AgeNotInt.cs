using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    internal class AgeNotInt:ApplicationException
    {
        public int IsLow { get; }
        public AgeNotInt(string message,int flag) : base(message)
        {
            IsLow = flag;
        }

    }
}
