using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Introduction.Asynchronous_Programming
{
    /*
        1. Thread.Sleep
        
        Purpose: Pauses the current thread for a specified duration.
            
        Synchronous execution: Thread.Sleep blocks the current thread, meaning it cannot 
        perform any other work during the sleep period.
        
        Typical scenarios: Commonly used when you need to pause the execution of a specific thread synchronously, 
        for example, when you want a simple delay in execution. 
        
        
        2. Task.Delay
       
        Purpose: Delays the execution of a task for a specified period without blocking the current thread.
        
        Asynchronous execution: Task.Delay is used for asynchronous delay, meaning it can be used with 
        async and await so that it doesn't block the thread, allowing it to perform other work during the delay.
        
        Typical scenarios: Mainly used in asynchronous programming to delay execution without blocking the current thread.

    */
    public class Example5
    {
        public static void run()
        {
            DelayUsingTask(3000);
            SleepUsingTask(5000);
        }

        private static void DelayUsingTask(int ms)
        {

            // should run the task or ...

            Task.Delay(ms).GetAwaiter().OnCompleted(() =>
            {
                Console.WriteLine("Delay using task");
            });
        }

        private static void SleepUsingTask(int ms)
        {
            Thread.Sleep(ms); // bloks the thread
            Console.WriteLine("Sleep using thread");
        }

    }
}
