using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StuMarks st=new StuMarks();
            //st.AddMark(70, 0);
            //st.AddMark(56, 1);
            //st.AddMark(90, 2);
            //int marks =st.GetMarks(1);
            //Console.WriteLine(marks);
             
            ObjectManager objectManager1 = new ObjectManager();
            objectManager1.Add(20, 1);
            Console.WriteLine(objectManager1.Get(1));
            ObjectManager objectManager2 = new ObjectManager();
            objectManager2.Add("charpitha", 1);
            objectManager2.Add(23, 3);
            Console.WriteLine(objectManager2.Get(3));
            Console.WriteLine(objectManager2.Get(1));

            ObjectManager objectManager3= new ObjectManager();
            objectManager3.Add(new Employee(), 0);
            objectManager3.Add(34, 2);//Boxing
            object  temp = objectManager3.Get( 2);
            int tempInt=(int)temp; //unboxing
            Console.WriteLine(objectManager3.Get(1));
            Console.WriteLine(objectManager3.Get(2));

            //1.TypeSafety 2.Performance
            //GenericManager<int> genericManager1 = new GenericManager<int>();//bcz int is value type
            //genericManager1.Add(15,0);
            //genericManager1.Add(43, 1);
            //int res = genericManager1.GetValue(1);

            GenericManager<Employee> genericManager2 = new GenericManager<Employee>();
            Employee emp = new Employee();
            emp.id = 1;
            emp.name = "char";
            genericManager2.Add(emp, 0);
            Console.WriteLine(genericManager2.increment(0));
              //gives error bcz emp is a class and ref type


        }
    }
}
