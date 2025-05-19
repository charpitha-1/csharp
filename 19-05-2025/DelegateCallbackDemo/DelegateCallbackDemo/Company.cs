using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateCallbackDemo
{
    public class Company
    {
        string[] empNames = {
            "charpitha",
            "sree",
            "thavishala",
            "Arjun",
            "Reddy"

        };
        public void PrintFilterNames(Predicate<string> filterMethod)
        {
            Console.WriteLine("filteredNames =>");
            foreach (var empName in empNames)
            {
                bool status=filterMethod(empName);
                if(status)
                    Console.WriteLine(empName);
            }
        }
    }
}
