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

            int num = default;
            Console.WriteLine(num); // 0

            Nullable<int> nullable = default;
            Console.WriteLine(nullable); // empty - null

            Console.WriteLine("---");
            
            int? num2 = default;
            Console.WriteLine(num2); // null
            if (num2.HasValue)
            {
                Console.WriteLine($"num2: {num2}");
            }
            else
            {
                Console.WriteLine("num2 is null");
            }

            Console.WriteLine("---");

            Nullable<int> num3 = new Nullable<int>();
            Console.WriteLine(num3); // null
            Console.WriteLine("---");

        }

    }
}
