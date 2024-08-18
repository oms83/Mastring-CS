using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Working_with_NULL
{
    public class Example1
    {
        public static void run()
        {
            string name = null;

            string decision = IsLong(name) ? "long" : "short";

            Console.WriteLine(decision);
        } 
        static bool IsLong(string name)
        {
            // we will not take an exception in compile time but will take it in run time.

            return name.Length > 10;
        }
    }
}
