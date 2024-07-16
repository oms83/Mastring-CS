using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Delegation.Generic_Delegate
{
    public class Example2
    {
        public Predicate<int>Filter;
        public static void Filter1(IEnumerable<int> genericCollection, Predicate<int> filter)
        {
            foreach (var n in genericCollection)
            {
                if (filter(n))
                {
                    Console.Write($"{n}, ");
                }
            }
            Console.WriteLine();
        }
        public static void run()
        {
            IEnumerable<int> arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            IEnumerable<int> lst = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Filter1(arr, n => n >= 5);
            Filter1(arr, n => n % 2 == 0);
            Filter1(arr, n => n % 2 != 0);

            Filter1(lst, n => n >= 5);
            Filter1(lst, n => n % 2 == 0);
            Filter1(lst, n => n % 2 != 0);
        }
    }
}
