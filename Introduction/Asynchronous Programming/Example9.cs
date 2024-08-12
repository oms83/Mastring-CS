using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Asynchronous_Programming
{
    public class Example9
    {
        public static async Task run()
        {
            Action<int> Progress = (p) => { Console.Clear(); Console.WriteLine($"{p}%"); };
            await Copy(Progress);
            Console.WriteLine("omer");
        }

        private static Task Copy(Action<int> onProgressPercentChanged)
        {
            return Task.Run(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    Task.Delay(50).Wait();
                    if (i % 10 == 0)
                    {
                        onProgressPercentChanged(i);
                    }
                }
            });

        }
    }
}
