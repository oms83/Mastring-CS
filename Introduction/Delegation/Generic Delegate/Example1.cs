using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Introduction.Delegation.Generic_Delegate.Example1;

namespace Introduction.Delegation.Generic_Delegate
{
    public class Example1
    {
        public delegate bool predicate<in T>(T number); // == public predicate<int>Filter;
        public delegate bool delFilter(int number);
        public delegate T1 delWhere<out T1, in T2>(T2 number);
        public static void Filter1(int[] arr, delFilter filter)
        {
            foreach (var n in arr)
            {
                if (filter(n))
                {
                    Console.Write($"{n}, ");
                }
            }
            Console.WriteLine();
        }

        public static void Filter2(int[] arr, delWhere<bool, int> filter)
        {
            foreach (var n in arr)
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
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            delWhere<bool, int> _where = n => n%2==0;
            Filter2(arr, _where);

            delWhere<bool, int> _where2 = delegate (int n) { return n % 2 != 0; };
            Filter2(arr, _where2);


            Filter1(arr, n => n >= 5);
            Filter1(arr, n => n % 2 == 0);
            Filter1(arr, n => n % 2 != 0);
        }
    }
}
