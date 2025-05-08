using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorManagement
{
    public  class Host
    {
        string hostId;
        string hostname;
        string empno;
        string dept;
        string loc;
        string contactNo;
        public string HostId { 
            get { return hostId; } 
            set { hostId = value; } 
        }
        public string HostName { 
            get { return hostname; } 
            set { hostname = value; }
        }
        public string Empno {
            get { return empno; } 
            set { empno = value; }
        }    
        public string Dept { 
            get { return dept; } 
            set { dept = value; } 
        }
        public string Loc { 
            get { return loc; } 
            set { loc = value; } 
        }  
        public string ContactNo { 
            get { return contactNo; } 
            set { contactNo = value; } 
        }
        public Host()
        {

        }
    }
}
