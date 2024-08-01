using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Collections.Stack_and_Queue
{
    public class PrintingJob
    {
        private readonly string _file;
        private readonly int _copies;

        public PrintingJob(string file, int copies)
        {
            _file = file;
            _copies = copies;
        }

        public override string ToString()
        {
            return $"{_file} X #{_copies} copies";
        }
    }

    public class Example2
    {
        public static void run()
        {
            Queue<PrintingJob> jobs = new Queue<PrintingJob>();
            jobs.Enqueue(new PrintingJob("documentation.docx", 2));
            jobs.Enqueue(new PrintingJob("userInfo.docx", 2));
            jobs.Enqueue(new PrintingJob("presention.ppt", 3));
            jobs.Enqueue(new PrintingJob("final.pdf", 1));
            jobs.Enqueue(new PrintingJob("vize.pdf", 1));
            jobs.Enqueue(new PrintingJob("math.pdf", 3));

            Random random = new Random();

            while (jobs.Count > 0)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                var job = jobs.Dequeue();
                Console.WriteLine($"printing ... [{job}]");
                System.Threading.Thread.Sleep(random.Next(1, 5) * 1000);
            }
        }
    }
}
