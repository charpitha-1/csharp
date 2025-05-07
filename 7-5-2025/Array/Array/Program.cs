using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetBase10FromBinary("100100111");
            /*int[] prices = new int[5]; //1-d array
            Console.WriteLine(prices.Length);
            Console.WriteLine(prices.Rank);
            Console.WriteLine(prices[0]);
            //Console.WriteLine(prices[4]); //index out of boundary
            Console.WriteLine("array elements");
            prices[0] = 23;
            prices[1] = 54;
            prices[2] = 29;
            prices[3] = 45;
            prices[4] = 30;
            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine("the values are->" +i+":"+prices[i]); //prints the array
            }
            Console.WriteLine("Printing using for each loop");
            foreach (int val in prices)
            {
                Console.WriteLine(val);
               // val++; //not allowed bcz for each loop having readonly
            }
            Console.WriteLine(prices.GetType());

            //using array class
            Console.WriteLine("Using Array class");
            Array Obj=Array.CreateInstance(typeof(int),4);
            Obj.SetValue(1, 0); //setvalue(value,index)
            Obj.SetValue(3, 1);
            Obj.SetValue(5, 2);
            Obj.SetValue(9, 3);
            for (int i = 0; i < Obj.GetLength(0); i++)
            {
                Console.WriteLine("the values are->" + i + ":" + Obj.GetValue(i)); //prints the array
            }
            int[] NewArray =new int[10];
            Obj.CopyTo(NewArray,2);
            foreach (int val in NewArray)
            {
                Console.WriteLine(val);
                // val++; //not allowed bcz for each loop having readonly
            }
            double[,] storePrices = new double[3, 4]; //multi d-array

            storePrices[0, 2] = 23.45;
            Array obj2 = storePrices;
            double val3 = Convert.ToDouble(obj2.GetValue(0, 2));
            Console.WriteLine(val3);*/

            //Jagged Array->Array of array
            /*Console.WriteLine("enter no of catgs");
            int catgs = int.Parse(Console.ReadLine());
            double[][] storePrices = new double[catgs][];
            for (int i = 0; i < catgs; i++)
            {
                Console.WriteLine("enter no of item");
                int Itemc = int.Parse(Console.ReadLine());
                storePrices[i] = new double[Itemc];
                for (int j = 0; j < Itemc; j++)
                {
                    Console.WriteLine("Enter the price");
                    storePrices[i][j] = double.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Calc the Avg sum:");
            for (int i = 0; i < catgs; i++)
            {
                double ItemSum = 0.0;
                //Console.WriteLine("items are:");
                int Itemcount = storePrices[i].Length;
                for (int j = 0; j < Itemcount; j++)
                {
                    ItemSum += storePrices[i][j];
                }
                Console.WriteLine($"Avg : {ItemSum / Itemcount}");
            }*/
            /*console.WriteLine("Armstrong");
            for (int i = 1; i <= 1000; i++)
            {
                int sum = 0;
                int r;
                int n1 = i;
                int n2 = i.ToString().Length;
                while (n1 > 0)
                {
                    r = n1 % 10;
                    sum = sum + (int)Math.Pow(r, n2);
                    n1 = n1 / 10;
                }
                if (sum == i)
                {
                    Console.WriteLine(i);
                }

            }*/
        }

            //Adding two binary values and display the result base 10
            private static int GetBase10FromBinary(string inp)
        {
            char[] chars = inp.ToCharArray();
            char[] Reversechars=chars.Reverse().ToArray();
            int sum = 0;
            for(int i = 0; i < Reversechars.Length; i++)
            {
                int digit=int.Parse(Reversechars[i]+"");
                sum += (int)Math.Pow(2, i) * digit;
            }
            return sum;
        }
    
    }
}
