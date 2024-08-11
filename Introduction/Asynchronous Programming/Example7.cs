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
        public static void run2()
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

        public static async void run()
        {
            var content = await ReadContant("https://www.youtube.com/@oms9159");

            Console.WriteLine(content);

            Console.WriteLine(await ReadContant("https://www.youtube.com/@oms9159"));
        }

        private static async Task<string> ReadContantAsync(string url)
        {
            var client = new HttpClient();

            var task = await client.GetStringAsync(url);

            return task;
        }
    }
}
