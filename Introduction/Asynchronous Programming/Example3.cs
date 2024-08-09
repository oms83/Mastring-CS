using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Introduction.Asynchronous_Programming
{
    public class Example3
    {
        public static void run()
        {
            Task task = Task.Factory.StartNew(() => LongRunning(),  TaskCreationOptions.LongRunning);
            
        }

        private static void LongRunning()
        {
            Thread.Sleep(3000);
            Console.WriteLine($"{Thread.CurrentThread.IsBackground} {Thread.CurrentThread.IsThreadPoolThread} {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
