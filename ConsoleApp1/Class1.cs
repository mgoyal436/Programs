using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    internal class Class1
    {
        public static void FirstMethod()
        {
            Console.WriteLine("First method is running.....");
            Thread.Sleep(10000);
            Console.WriteLine("First method is end.....");
        }

        public static void SecondMethod()
        {
            Console.WriteLine("Second Method is running");
            Thread.Sleep(8000);
            Console.WriteLine("Second method is end.....");
        }

        public static void ThirdMethod()
        {
            Console.WriteLine("Third method is running");
            Thread.Sleep(2000);
            Console.WriteLine("Third method is end.....");
        }

        public static async void CommonMethod()
        {
            await Task.Run(() =>
            {
                Thread t1 = new Thread(FirstMethod);
                Thread t2 = new Thread(SecondMethod);
                Thread t3 = new Thread(ThirdMethod);
                t1.Start();
                t2.Start();
                t3.Start();
            });
        }
        public static void Main(string[] args)
        {
            //Console.WriteLine("Main Method is Running");
            //CommonMethod();
            //Console.WriteLine("Main Method is finished");
            //Console.ReadLine();

            Thread.CurrentThread.Name = "Main";

            // Create a task and supply a user delegate by using a lambda expression.
            Task taskA = new Task(() => Console.WriteLine("Hello from taskA."));
            // Start the task.
            taskA.Start();

            // Output a message from the calling thread.
            Console.WriteLine("Hello from thread '{0}'.",
                              Thread.CurrentThread.Name);
            for(int i=0; i<5; i++)
            {
                Thread.Sleep(10);
                Console.WriteLine(i);
            }
            taskA.Wait();
            Console.ReadLine();
        }
    }
}
