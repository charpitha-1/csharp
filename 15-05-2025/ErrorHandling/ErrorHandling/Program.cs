using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DoOperation();
            }
            catch (AgeNotInt ag)when (ag.IsLow==1)
            {
                Console.WriteLine("Lower end "+ag.Message);
            }
            catch (AgeNotInt ag)
            {
                Console.WriteLine("Higher end "+ag.Message);
            }
            catch (FormatException ex)
            {
                //Console.WriteLine("Format error" + ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.TargetSite.Name);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("General Error" + e.Message);
            }

            finally
            {
                Console.WriteLine("end of block");
            }
        }

        static void DoOperation()
        {
            Employee emp;
            emp = new Employee();
            int empid = int.Parse(Console.ReadLine());
            string empname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            if (age < 16)
            {
                throw new AgeNotInt($"{age} is not in the range",1);
            }
            else if(age >58)
            {
                throw new AgeNotInt($"{age} is not in the range", 0);
            }
                emp.Id = empid;
            emp.Name = empname;
            emp.Age = age;
            emp.DisplayInfo();
        }
    }
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine($"id:{Id}---name:{Name}---age:{Age}");
        }
    }
}
    

