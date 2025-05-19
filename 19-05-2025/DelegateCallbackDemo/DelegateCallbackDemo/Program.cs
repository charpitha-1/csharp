using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateCallbackDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            //company.PrintFilterNames(FilterBasedOnStartString);
            //company.PrintFilterNames(FilterOnLength);
            string s = "a";
            company.PrintFilterNames(str=>str.ToUpper().Contains(s.ToUpper()));
        }
        private static bool FilterBasedOnStartString(string filterstring)
        {
            if(filterstring.ToUpper().Contains("R")) 
                return true;
            else
                return false;
        }
        private static bool FilterOnLength(string filterstring)
        {
            return filterstring.Length > 6;
        }
    }
}
