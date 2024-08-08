using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Asynchronous_Programming
{
    public class Example2
    {
        public static void run()
        {
            // thread low level
            // task high level

            Task<DateTime> task = Task.Run(() => DateTime.Now);
            Task<DateTime> task2 = Task.Run(GetCurrentDateTime);

            Console.WriteLine(task2); // System.Threading.Tasks.Task`1[System.DateTime] // return task object

            Console.WriteLine(task2.Result); // first way
            Console.WriteLine(task2.GetAwaiter().GetResult()); // second way

            // thread does not return value
        }
        private static DateTime GetCurrentDateTime() => DateTime.Now;
    }
}
