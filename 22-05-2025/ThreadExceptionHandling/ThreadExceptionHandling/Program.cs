using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading;
using System.Threading.Tasks;

namespace ThreadExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task<string> downloadTask = new Task<string>(() =>
            {
                Console.WriteLine("Downloading..");
                Task.Delay(1000).Wait();
                return "File Downloaded";
            });
            downloadTask.Start();
            string r= downloadTask.Result;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }  
            Console.WriteLine("Result from string gen:"+r);
            Console.WriteLine($"File saved in---{r}");
            Console.WriteLine("Start main");
            //Action action = Taskfunc;
            //Func<int> f = Taskfunc2;
            //Task<int> t = new Task<int>(f,TaskCreationOptions.PreferFairness| 
            //    TaskCreationOptions.LongRunning);

            //t.Start();
            //int t1=t.Result;
            //Console.WriteLine("Result:"+t1);
            //action are  delegate
            //Task task=new Task(action);
            //task.Start();
            //Task.Run(action);
            //Task t1= Task.Run(action);
            //Task t2= Task.Run(Taskfunc1);
            //Task t=Task.Factory.StartNew(action);
            //Task<int> t = Task<int>.Run(() => //to return the value from task
            //                                  //we need generics to return the data
            //{
            //    return 10;
            //});
            //int r=t.Result; //blocking call
            //Console.WriteLine("Result of the task:"+r);
            //t.Wait();
           // Console.WriteLine("Task started from main");
            //Console.ReadLine();
           //t1.Wait();//blocking call //similar to join 
            //Task.WaitAll(t1,t2); //we have waitany to move forward to next task
            //Console.WriteLine("wait ended");
            // ParameterizedThreadStart p = new ParameterizedThreadStart(DownloadFile);
            //  Thread th = new Thread(p);
            //  th.Start("http://localhost//mtfile.pdf");
            //Console.WriteLine("Reached to end");
        }
        public static void Taskfunc()
        {
            Console.WriteLine("task function1");
            Task.Delay(1000).Wait(); //delay is a task and calls another task
                                     //to execute but we should say to wait
        }
        public static void Taskfunc1()
        {
            Console.WriteLine("task function2");
            Task.Delay(2000).Wait();
        }

        public static int Taskfunc2()
        {
            return 10;
        }
        //public static void SaveFile(object path)
        //{
        //    Console.WriteLine("Saved the file");
        //}
        //public static void  DownloadFile(object path)
        //{
        //    Thread.Sleep(1000);
        //    Console.WriteLine("Download Completed" + path);
        //}
        //public static void myThreadFunc(object obj)
        //{
        //    int Val=Convert.ToInt32(obj);
        //    try//we should catch the exception in thread fun only not in main method
        //    {
        //        for (int i = -10; i < 10; i++)
        //        {
        //            Console.WriteLine(Val / i); //exp if i=0
        //        }
        //    }
        //    catch(Exception e)
        //    {
        //        Console.WriteLine("Error occured");
        //    }
        //}
    }
}
