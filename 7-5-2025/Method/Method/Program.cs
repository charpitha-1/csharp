using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AddUser("charpitha", "charpitha@fgmail.com", "123456", 22); //positonal parameters
            //bool res = AddUser("thavishala", "charpitha2@fgmail.com", "12345", 20);
            ////DepositSalary(30000);
            //AddUser("charpitha34", email: "charpitha34@fgmail.com", Age: 22, password: "123456"); //Named Parameters
            //AddUser("rani", "rani@fgmail.com", "123456"); //default parameters
            //DepositSalary(12323d,34255d);
            //double Sal = 2321;
            //double bonus;
            //Console.WriteLine($"Before Incremental:{Sal}");
            //IncrementSal(ref Sal,out double  bonus); //both ref and out are passed with  reference
            //Console.WriteLine($"After Incremental:{Sal} :Bonus:{bonus}");
            //IncrementSal(ref Sal, out double bonus1,2000);
            dynamic obj = "char"; //binding the value at runtime
            Console.WriteLine(obj.Length);
            //var obj2 = "charpi"; //binding the value at compile time
            //Console.WriteLine(obj2.Length);

        }
        static bool AddUser(string DisplayName,string email,string password,int Age=23)
        {
            Console.WriteLine($" {DisplayName}: {email} : {password} :{Age}");
            return true;
        }
        static void DepositSalary(params double[] Sal)
        {
            double Net = Sal[0]+Sal[1];
            Console.WriteLine($"Desposited salary {Net}");
            //Console.WriteLine($"Desposited salary {Sal}");
        }
        //overloading methods
        static void IncrementSal(ref double InitialSal,out double bonus)
        {
            bonus= InitialSal*0.1;
            InitialSal = InitialSal * 1.2;
            Console.WriteLine($"from incremantal:{InitialSal} :Bonus:{bonus}");
        }
        static void IncrementSal(ref double InitialSal, out double bonus,double deductions=200)
        {
            bonus = InitialSal * 0.1;
            InitialSal = InitialSal * 1.2-deductions;
            Console.WriteLine($"from incremantal deduction:{InitialSal} :Bonus:{bonus}");
        }
    }
}
