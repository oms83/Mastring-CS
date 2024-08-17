using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Working_with_NULL
{
    public class ReferencingVSDerefrencing
    {
        public static void run()
        {
            // reference type object store at heap
            string str1 = "Omer";
            string str2 = default; // default = str1 = null 
            Console.WriteLine(str1.Length); // 4

            //Console.WriteLine(str2.Length); // null reference exception 
            // value type, value store at stack
            DateTime dateTime = default;
            Console.WriteLine(dateTime);

        }

    }
}
