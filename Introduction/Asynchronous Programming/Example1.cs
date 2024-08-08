using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Introduction.Asynchronous_Programming
{
    public class Example1
    {
        public static void run()
        {
            Display("text");
            Console.WriteLine("------------");
            var th = new Thread(() => Display("thread tow"));
            th.Start();
            th.Join();

            Task.Run(() => Display("task class")).Wait();
        }
        static void Display(string massage)
        {
            ShowThreadInfo(Thread.CurrentThread);
            Console.WriteLine(massage);
        }
        private static void ShowThreadInfo(Thread th)
        {
            Console.WriteLine($"ThID {th.ManagedThreadId}, Pooled: {th.IsThreadPoolThread}, isbackground: {th.IsBackground}");
        }


    }
}
