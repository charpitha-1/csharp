using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionApp
{
    internal class Employee
    {
        public int Id { get; set; }
        public double salary;
        public string Name { get; set; }
        public Employee(int Idnum,string empName) {
            Id = Idnum;
            Name = empName;
            salary = 15000;
        }
        public Employee(int Idnum) { 
            Id = Idnum;
            Name = "default";
            salary = 10000;

        }
        public string GetEmployeeInfo()
        {
            return $"Name:{Name}";
        }
    }
}
