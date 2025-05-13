using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class BasicCollectionsTest
    {
        public void TestList()
        {
            var list = new List<int>();
            list.Add(16);
            list.Add(25);
            list.Add(3);
            list.Add(44);
            list.Add(53);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            foreach (int val in list)
            {
                Console.WriteLine(val);
            }
            list.Sort();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            List<int> list2 = list.FindAll((val) => val % 2 != 0);
            foreach (int val1 in list2)
            {
                Console.WriteLine(val1);
            }
        }
        public void TestList2()
        {
            var list = new List<Employee>();
            list.Add(new Employee() {
                name = "cherry",
                salary = 69956
            })
            ;
            list.Add(new Employee()
            {
                name = "bunny",
                salary = 789665

            })
            ;
            list.Add(new Employee()
            {
                name = "ram",
                salary = 7865

            })
            ;
            list.Sort(new EmployeeSqlCompare());
            foreach (Employee e in list) { 
                Console.WriteLine(e.name);
            }
        }
    }
}
