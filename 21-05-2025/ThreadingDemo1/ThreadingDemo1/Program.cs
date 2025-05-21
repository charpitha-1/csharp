using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadingDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParameterizedThreadStart st=new ParameterizedThreadStart(MyParamFunc); //accept one parameter type 
            //Thread thread = new Thread(st);
            //thread.Start(20);
            //thread.IsBackground=true;
            //Console.WriteLine("----Before join :");
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(thread.ThreadState);
            //}
            //Console.WriteLine(thread.ThreadState);
            //Console.WriteLine("press any key to abort");
            //Console.ReadLine();
            //thread.Abort();
            //Console.WriteLine("Thread state--->"+thread.ThreadState);
            ////thread.Join(); //waits the background thread //blocking call
            //Console.WriteLine("-----After:");
            //ThreadStart thdlg=new ThreadStart(MyThreadfunc); //return type is default "void" no parameters
            //MyClass my= new MyClass();
            //Thread th1 = new Thread(my.ClassThreadFunc);
            //Thread th2 = new Thread(my.ClassThreadFunc); //delegate inference
            //Console.WriteLine("----Before:"+th1.ThreadState);
            //th2.Start();
            //th1.Start();
            //Console.WriteLine("-----After:"+th1.ThreadState);
            //th1.Priority = ThreadPriority.Highest;
           // Console.WriteLine("Reached to end");

            //Thread pool
            //ThreadPool.GetMaxThreads(out int wt, out int cpt);
            //Console.WriteLine(wt);
            WaitCallback call = MyPoolFunc;
            for (int i = 0; i < 20; i++)
            {
                ThreadPool.QueueUserWorkItem(call, 20);
                ThreadPool.GetMaxThreads(out int wt, out int cpt);
                Console.WriteLine(wt);
                Console.ReadLine();
            }
            Console.WriteLine("Reached to end");
        }
        public static void MyPoolFunc(object state)
        {
            int Va = Convert.ToInt32(state);
            int ThreadId = Thread.CurrentThread.ManagedThreadId;
            for (int i = 0; i < Va; i++)
            {
                Console.WriteLine($"From thread :{ThreadId} ----{i}");
                Thread.Sleep(100);
            }
        }
        public static void MyParamFunc(object state)
        {
            int Val=Convert.ToInt32(state);
            int ThreadId=Thread.CurrentThread.ManagedThreadId;
            for(int i = 0; i < Val; i++)
            {
                Console.WriteLine($"From thread :{ThreadId} ----{i}");
                Thread.Sleep(500);
            }
        }
        public static void MyThreadfunc()
        {
            int Count = 0;
            int ThreadId=Thread.CurrentThread.ManagedThreadId;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"From thread:{ThreadId} Hello :{Count}");
                ++Count;
            }
        }
        public static void MyThreadfunc2()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("thavishala" + i.ToString());
            }
        }
    }
}
