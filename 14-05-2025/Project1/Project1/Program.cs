using System;
using System.Collections.Generic;
using System.Linq; //consits extension method
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> list = new List<Customer>();
            list.Add(new Customer()
            {
                Id = 1,
                Name = "charpitha",
                Location = "kurnool"
            });
            list.Add(new Customer()
            {
                Id = 2,
                Name = "cherry",
                Location = "hyd"
            });
            //Query Expression
            //var result=from cust in list where cust.Location=="kurnool"
            //           select new { Name = cust.Name, id = cust.Id };
            //foreach (var item in result) {
            //    Console.WriteLine($"custname={item.Name} and id={item.id}");
            //}
            int custFromkurnool = list.Count(c => c.Location == "kurnool");
            Console.WriteLine(custFromkurnool);
                
            //int[] numbers = { 2, 4,12,36,64, 62, 34 };
           // List<int> list = new List<int>() { 2, 4, 12, 36, 64, 62, 34 };//collection initialazation

            //Query Expression 
            //list is grp of integers but the output is anonymous 
            //var res = from num in list //input seq is list output seq is res //var is used for not knowning type
            //           where num % 2 == 0 && num % 3 == 0
            //         select new { number = num, sqrt = num * num };//applicable to the list only---->.ToList();          //differ exp
            ////Console.WriteLine(res.GetType());
            //foreach (var val in res)
            //{
            //    //Console.WriteLine(val); //call the ToString()
            //    Console.WriteLine($"value:{val.number} and Sqrt:{val.sqrt}");

            //}
            //ist.Add(30);
            //Console.WriteLine("After");
            //foreach (var val in res)
            //{
            //    Console.WriteLine(val);
            //}

            //Method invocation syntax
            //Linq operators
            //var res = list.Where(val => val % 2 == 0 && val % 3 == 0)
            ////    .Select(num => new { number = num, sqrt = num * num });
            //IEnumerable<ResultEntry> res = list.Where(val => val % 2 == 0 && val % 3 == 0)
            //   .Select(num => new ResultEntry()
            //   { number = num,
            //       sqrt = num * num });
            //foreach (var val in res)
            //{
            //    Console.WriteLine(val);
            //}
        }
    }

    internal class ResultEntry
    {
        public int number;
        public int sqrt;
        public override string ToString() { 
            return $"value:{number} and Sqrt:{sqrt}";
        }
    }

    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}

