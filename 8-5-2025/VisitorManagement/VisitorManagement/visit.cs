using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorManagement
{
    public class Visitors
    {
        public string name { get;  }
        public string loc {  get; }
        public string pname {  get; }
        public string purpose {  get;  }
        public string mobileno {  get;  }
        public DateTime visitingDate { get; }
        public string hname {  get;  }

        public Visitors(string name,string loc,string pname,string purpose,string mobileno,DateTime visitingDate){
            this.name = name;   
            this.loc = loc;
            this.pname = pname;
            this.purpose = purpose;
            this.mobileno = mobileno;
            this.visitingDate = visitingDate;
            this.hname = hname;
            }
        public void VisitorInfo() //public method
        {
            Console.WriteLine($"{name}--{loc}--{pname}--{purpose}--{mobileno}--{visitingDate}--{hname}");
        }
    }
}
