using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Introduction.Asynchronous_Programming
{
    /*
      
        Execution Flow:
        Synchronous: Tasks are executed sequentially, one after the other.
        Asynchronous:Tasks can be executed concurrently, allowing the program to continue running 
                     while waiting for other tasks to complete..


        Blocking vs. Non-blocking:
        Synchronous: The main thread is blocked while waiting for a task to complete.
        Asynchronous:The main thread is not blocked, allowing other operations to continue.


        Use Cases:
        Synchronous: Best for simple, linear tasks where blocking operations are acceptable, such as simple 
                     command-line utilities.
        Asynchronous: Ideal for I/O-bound or network-bound operations, especially in environments like web servers, 
                      where you need to handle many requests concurrently.


        Complexity:
        Synchronous: Easier to write, debug, and understand.
        Asynchronous: More complex, but provides better performance in scenarios with long-running operations.
     
    */
    public class Example6
    {
        public static void run()
        {
            ShowInfo(Thread.CurrentThread, 14);
            CallSynchronous();

            ShowInfo(Thread.CurrentThread, 17);
            CallAsynchronous();

            ShowInfo(Thread.CurrentThread, 20);
        }

        private static void CallSynchronous()
        {
            Thread.Sleep(3000);
            ShowInfo(Thread.CurrentThread, 26);

            //Task.Run(() => Console.WriteLine("++++++++++++++++++Synchronous++++++++++++++++++")).Wait();

            Thread t = new Thread(() => {
                Console.WriteLine("++++++++++++++++++Synchronous++++++++++++++++++");
            });
            t.Start();
            t.Join();
        }

        private static void CallAsynchronous()
        {
            ShowInfo(Thread.CurrentThread, 32);
            Task.Delay(3000).GetAwaiter().OnCompleted(() =>
            {
                ShowInfo(Thread.CurrentThread, 35);
                Console.WriteLine("++++++++++++++++++Asynchronous++++++++++++++++++");
            });
        }

        private static void ShowInfo(Thread t, int line)
        {
            Console.WriteLine($"ThreadID:{t.ManagedThreadId}, Pooled:{t.IsThreadPoolThread}, IsBackground:{t.IsBackground}");
        }
    }
}
