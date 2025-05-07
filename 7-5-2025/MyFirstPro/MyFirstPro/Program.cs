using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstPro
{
    internal class Program
    {
        static void Main(string[] args) //void main()// int main() //int main(string[] args) //async Task main()
        {
            //Console.WriteLine("Enter the principle ");
            //double PAmount=double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Rate");
            //double RI = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the time ");
            //int Time = int.Parse(Console.ReadLine());
            //double SI = PAmount+(PAmount * RI * Time / 100.0);
            //Console.WriteLine($"Simple Interest: {SI}");
            /*int val = 10;
            object obj = val; //boxing -value type assigned to object
            int val2 = (int)obj; //unboxing obj to int explictly
            Console.WriteLine(val);
            Console.WriteLine(val2);
            Console.Write("Hello World");
            Console.WriteLine("hello");
            Console.WriteLine("enter name");
            string Name = Console.ReadLine();
            Console.WriteLine("Name  " + Name);

            Console.WriteLine("enter age");
            string age = Console.ReadLine();

            Console.WriteLine("enter salary");
            string salary = Console.ReadLine();

            //int nAge = int.Parse(age); //converting the string to int
            //++nAge;
            int nAge;
            bool valid = int.TryParse(age, out nAge); //show  an error in age and tryparse to show and out for fill the nage
            if (valid == false)
            {
                Console.WriteLine("error in age");
                return;
            }
            //++nAge;
            double Sal = double.Parse(salary); //converting string to double
            double bonus = Sal * 0.1;
            if (bonus > 2000)
            {
                bonus = 2000;
                return;
            }
            string strout = $"Name is:{Name}, Age is:{age},Sal is:{Sal},bonus:{bonus}";
            //Console.WriteLine("Name:" + Name +  " age:" + nAge+" salary "+Sal);
            Console.WriteLine(strout);*/

            //string st = null;
            //int va = null;
            //map the Db coloumn of type Id:Bigint to local vaariable :Nullable field
            //long DbVal = 121343;//long is a valuetype cannot  assign to null
            //Nullable value type
            //Nullable<long> Nullable = 124243; //it seema long so
            /*long? NullableSal = 1234;
            NullableSal = null;

            //calculate the bonus by 10%.If the sal is null ,bonus =2000
            if (NullableSal.HasValue)
            {
                Console.WriteLine("Bonus:" + NullableSal.Value * 0.1); //123.4
            }
            else
            {
                Console.WriteLine("Bonus:2000");
            }
            
                var value1 = 10; //implicit typed local variable
                Console.WriteLine(value1.GetType()); //system.int 32
                var str = "test1";
                Console.WriteLine(str.GetType()); //system.string

                string name = "chariptha";
                Console.WriteLine(name);

                name = null;//assign null to string
                int val3 = 10;
                //val3 = null; //value type cast
                string comment = "some comment says:\"is my comment\""; //escape character
                Console.WriteLine(comment);
                string comment1 = @"Path is:\is my comment\"; // "path is:\\is my comment\\"
                Console.WriteLine(comment1);
                */

            //char c = 'A';//ASCII
            //int s = (int)c;
            //Console.WriteLine(s);

            //    int Sal = 1214554;
            ////Console.WriteLine("{0:N}", Sal); //c is format character //E,N,X, //stored as number
            //string strTemp = String.Format("{0:N}", Sal);
            //Console.WriteLine(strTemp); //format chars //stored as string



            //int i = (int)100ul; //explicit conversion
            //ulong ul = 100;
            //float f = 12.34f;
            //double d = (double)12.3m; //m=money
            //byte b = 233;
            //int val = 123;
            //long v = 2344;
            //val = (int)v;

            //char ch = 'a';
            //int val2 = ch; //implicit
            //int ch2 = (int)ch;

            //int val3; //local variables
            //++val3;
            //Console.WriteLine(val2.GetType()); //get type is method on system.object
            //Type t = typeof(int); //typeof is operator
            //if (val2.GetType() == typeof(int))
            //{
            //    Console.WriteLine("val2 is integer");
            //}
            //int val1 = 10;
            //double res = val1/3.0;
            //Console.WriteLine(res);
            //return;


            //Operators Precedence

            /*int a = 10, b = 5;
            double c= 10.4;
            double res1 = a + b * c / 2; //
            Console.WriteLine(res1);
            double res2 = a * b + c / 2; //55.2
            Console.WriteLine(res2);
            double res3 = (a + b) * c / 2; //
            Console.WriteLine(res3);
            Console.WriteLine($"{res1}-{res2}-{res3}");*/
            //[],(),. -->having max precedence

            /* string str ="abc"; //str=null
             string str2 = str ?? "durga"; //null colese operator ,if the str is not null then return str ,is null return the durga
             Console.WriteLine(str2);
             string str3=(str!=null)?str:"durga"; //trenary operator
             Console.WriteLine(str3);*/

            /*checked //gives the exception bcz of the overflow
            {
                uint val1 = uint.MaxValue;
                val1++;
                Console.WriteLine(val1);
            }*/

            //conditional Control Flow
            //1.If-else
            //2.if-elseif-else
            //3.switch
            //looping flow control
            //1.for
            //2.do-while
            //3.while
            //4.foreach
            //5.continue
            //6.break

            /*int mark = 45;
            if(mark>35&&mark < 59)
            {
                if(mark>35&& mark < 40) //nested if

                {

                }
            }
            else if (mark >=60 && mark <60)
            {

            }
            else
            {

            }*/

            
            /*while (true) //infi loop
            {
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.WriteLine("entered 1");
                }
                else if (option == 2)
                {
                    Console.WriteLine("entered 2");
                    continue;
                }
                else if (option == 3) {
                    break;
                }
                Console.WriteLine("After if block");
            }*/


            int count=int.Parse(Console.ReadLine());
            if(count > 0)
            {
                for(int i=1;i<count;i++)
                {
                    for (int j=1;j<count;j++)
                    {
                        if (j<i)
                        {
                            Console.Write(j+""+i);
                        }
                    }
                    Console.WriteLine("");
                }
            }
            
                







        }
    }
}
