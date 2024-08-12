using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Introduction.Asynchronous_Programming
{
    public class Example11
    {
        public static async Task run()
        {
            var duties = new List<DailyDuty>()
            {
                new DailyDuty("Cleaning House"),
                new DailyDuty("Washing Dishes"),
                new DailyDuty("Doing Laudry"),
                new DailyDuty("Preparing Meals"),
                new DailyDuty("Checking Emails"),
                new DailyDuty("Cleaning House"),
            };

            //Console.WriteLine("using inparallel");
            //await ProcessThingsInParallel(duties);

            Console.WriteLine("\nusing inconcurrent");
            await ProcessThingsInConcurrent(duties);
        }
        static Task ProcessThingsInParallel(IEnumerable<DailyDuty> duties)
        {
            Parallel.ForEach(duties, thing => thing.Process());
            return Task.CompletedTask;
        }
        static Task ProcessThingsInConcurrent(IEnumerable<DailyDuty> duties)
        {
            foreach (var dut in duties)
            {
                dut.Process();
            }
            return Task.CompletedTask;
        }
    }
    public class DailyDuty
    {
        public string title { get; set; }
        public bool isProsecced {  get; private set; }

        public DailyDuty(string title)
        {
            this.title = title;
        }

        public void Process()
        {
            Console.WriteLine($"TID: {Thread.CurrentThread.ManagedThreadId}, duty: {this.title}");
            Task.Delay(100).Wait();
        }
    }
}
