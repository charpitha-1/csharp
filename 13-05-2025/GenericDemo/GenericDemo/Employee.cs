using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class Employee:IComparable
    {
        public string name {  get; set; }
        public int salary {  get; set; }

        public int CompareTo(object obj)
        {
            var curEmp=obj as Employee;
            if (salary > curEmp.salary)
            {
                return 1;
            }
            else if (salary < curEmp.salary) { return -1; }
            else { return 0; }
        }
    }
    public class EmployeeSqlCompare : IComparer<Employee>
    {
        int IComparer<Employee>.Compare(Employee x,Employee y)
        {
            if (x.salary > y.salary)
            {
                return 1;
            }
            else if (x.salary < y.salary) { return -1; }
            else { return 0; }
        }
    }
    internal class EmployeeKey
    {
        public int Key {  get; set; }
    }
}
