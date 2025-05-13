using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class ObjectBasedTest
    {
        ArrayList arr = new ArrayList();
        public void TestArrayList()
        {
            arr.Add(1);
            arr.Add(2);
            arr.Add("ram");//not typesafe
            arr.Add(true);//not typesafe
            Console.WriteLine(arr[1]); //index access starts with 0
            int itemcount=arr.Count;//property
            int val=(int)arr[0]; //ArrayList is the obj type so we need type cast
            object[] array = arr.ToArray(); //converting arraylist to array
            arr.Clear(); //remove all  elements from arraylist
            arr.RemoveAt(1); //remove ele at position
        }
        public void TestStack()
        {
            Stack stack = new Stack();
            stack.Push(1);//adding a element at tha top of the stack
            stack.Push(2);
            stack.Pop(); //removing and return element from top of the stack
            int ncount=stack.Count;
            // stack[0] = 2; //not allow index.applicable for IList implemented classes
            foreach(object item in stack)
            {
                Console.WriteLine(item.ToString());
            }
            object obj = stack.Peek(); //returns the top value of the stack
        }
        public void TestHashTable()
        {
            Hashtable ht = new Hashtable();
            ht.Add(2,34);
            ht.Add(1, 45);
            ht[2] = 77;
            if (ht.ContainsKey(2))
            {

            }
            Console.WriteLine(ht[2]);
            EmployeeKey employeeKey = new EmployeeKey(){ Key = 12};
            Employee employee = new Employee()
            {
                name = "charpitha"
            };
            ht.Add(employeeKey, employee);
            foreach (var key in ht.Keys)
            {
                Console.WriteLine(ht[key]);
            }
        }
    }
}
