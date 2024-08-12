using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Asynchronous_Programming
{
    internal class Example10
    {
        public static async Task run()
        {
            var has1000 = Task.Run(() => Has1000Subscriber());
            var has4000 = Task.Run(() => Has4000Subscriber());

            Console.WriteLine("using WhenAny");
            var any = await Task.WhenAny(has1000, has4000);
            Console.WriteLine(any.Result);

            Console.WriteLine("\nusing WhenAll");
            var all = await Task.WhenAny(has1000,has4000); 
        }
        public static Task<string> Has4000Subscriber()
        {
            Task.Delay(4000).Wait();
            return Task.FromResult("congratulation !! you have 4000 subscribers");
        }
        public static Task<string> Has1000Subscriber()
        {
            Task.Delay(1000).Wait();
            return Task.FromResult("congratulation !! you have 1000 subscribers"); 
        }
    }
}
