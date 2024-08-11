using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Asynchronous_Programming
{
    internal class Example7
    {
        public static void run()
        {
            var task = Task.Run(() => ReadContant("https://www.youtube.com/@oms9159"));
            
            var awaiter = task.GetAwaiter();

            awaiter.OnCompleted(()=>Console.Write(awaiter.GetResult()));
        }

        private static Task<string> ReadContant(string url)
        {
            var client = new HttpClient();

            var task = client.GetStringAsync(url);

            return task;
        }
    }
}
