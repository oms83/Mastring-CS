using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    public class ForeachAndYeild
    {
        public static void run()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            Console.WriteLine("\n\nUsing For");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }

            Console.WriteLine("\n\nUsing Foreach");
            foreach (int i in arr) 
            {
                Console.Write(i);
            }

            Console.WriteLine("\n\nUsing Foreach under the hood");
            Foreach(arr);
        }
        static void Foreach<T>(IEnumerable<T> source)
        {
            // poiter on the collection
            IEnumerator<T> enumerator = source.GetEnumerator(); 

            IDisposable disposable;
            
            try
            {
                while (enumerator.MoveNext())
                {
                    var item = enumerator.Current;
                    Console.Write($" {item}");
                }
            }
            finally
            {
                disposable = enumerator as IDisposable;
                disposable?.Dispose();
                enumerator.Reset();
            }
            
        }

    }

}
