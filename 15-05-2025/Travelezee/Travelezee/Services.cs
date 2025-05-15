using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelezee
{
    internal class Services
    {
        public int Serviceid {  get; set; }
        public string ServiceName { get; set; }
        public int FromLocation {  get; set; }
        public int ToLocation { get; set; }
        public int Distance {  get; set; }
    }
}
