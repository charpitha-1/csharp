using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionApp
{
    internal class Customer
    {
        public int CustomerId;
        public string CustomerName { get; set; }
        public Customer(int Custid)
        {       
            CustomerId = Custid;
            CustomerName = "default customer";
        }
        public Customer(int Custid,string name)
        {
            CustomerId = Custid;
            CustomerName = name;
        }
        public string GetCustomerInfo()
        {
            return CustomerName;
        }
    }
}
