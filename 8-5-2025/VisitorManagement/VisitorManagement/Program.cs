using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorManagement
{
    public class Manage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the visitor Name");
            string VName = Console.ReadLine();
            Console.WriteLine("Enter the visitor Location");
            string Loc = Console.ReadLine();
            Console.WriteLine("Enter the Parent Company");
            string PCom = Console.ReadLine();
            Console.WriteLine("Enter the Mobile no ");
            string MobNo = Console.ReadLine();
            Console.WriteLine("Enter the Host Name");
            string HName = Console.ReadLine();
            Visitors visit= new Visitors();
            visit.name = VName;
            visit.loc = Loc;
            visit.pname = PCom;
            visit.mobileno = MobNo;
            visit.name = HName;

        }
    }
}
