using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms1
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public  override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }
}
