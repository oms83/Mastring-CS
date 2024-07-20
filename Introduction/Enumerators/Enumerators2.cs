using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Enumerators
{
    /*
        The yield keyword in C# is used to create iterators, which allow you to generate a sequence of values 
        over time, rather than returning all the values at once. The yield keyword is useful when 
        dealing with large data sets or when you want to optimize performance by creating 
        elements on demand.


        There are two main yield expressions:

        yield return: Used to return one element at a time from the sequence.
        yield break: Used to terminate the sequence prematurely.
 
    */
    public class SixIntegers : IEnumerable
    {
        public int[] values;
        public SixIntegers(int n1, int n2, int n3, int n4, int n5, int n6)
        {
            values = new int[] { n1, n2, n3, n4, n5, n6 };
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var i in values)
            {
                yield return i;
            }
        }

    }
    internal class Enumerators2
    {
        public static void run()
        {
            SixIntegers ints = new SixIntegers(1, 2, 3, 4, 5, 6);

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }

        }
    }
}
