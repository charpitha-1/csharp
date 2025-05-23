using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    


        public class ImmutablePerson
        {
            public string Name { get; }
            public int Age { get; }

            public ImmutablePerson(string name, int age)
            {
                Name = name;
                Age = age;
            }

            // Method to create a new instance with a modified name
            public ImmutablePerson WithName(string newName,int newage)
            {
                return new ImmutablePerson(newName, this.Age);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
            dynamic name = "gfuyr";
           
            Console.WriteLine(name.GetType());
            name = 1243;
            Console.WriteLine(name.GetType());
            }
        }
    }


