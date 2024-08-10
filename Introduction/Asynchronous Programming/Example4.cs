using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Asynchronous_Programming
{
    public class Example4
    {
        public static void run()
        {
            Task<int> task = Task.Run(() => CountPrimaryNumInRange(2, 3_000_000));

            //*****************************************************

            //Console.WriteLine(task.Result); // bad it blocks the thread
          
            
            //*****************************************************

            var awaiter = task.GetAwaiter();
            
            awaiter.OnCompleted(() =>
            {
                Console.WriteLine(awaiter.GetResult()); // block the thread but task is complated
            });

            //*****************************************************

            task.ContinueWith(t => Console.WriteLine(t.Result));
            Console.WriteLine("oms");

            //*****************************************************

            Console.WriteLine("OMS");
        }

        private static int CountPrimaryNumInRange(int From, int To)
        {
            int count = 0;
            From = From < 2 ? 2 : From;

            for (int i = From; i < To; i++)
            {

                bool isPrime = true;
                for (int j = 2; j < Math.Sqrt(i); j++) 
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    count++;
                }
            }
            return count;
                
        }
    }
}
