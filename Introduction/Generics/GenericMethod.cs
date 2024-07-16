using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Generics
{
    public class GenericMethod
    {
        private static void Print<T>(T value)
        {
            Console.WriteLine($"data type: {typeof(T)}");
            Console.WriteLine(value);
        }

        public static T Get<T>(T value) => value;
        public static void run()
        {
            Print("omer");
            Print(18m);
            Print(18d);
            Print(18);

            Console.WriteLine(Get("ali"));
            Console.WriteLine(Get(12));
            Console.WriteLine(Get(12.43m));
        }
    }
}
