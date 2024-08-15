using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Foreach_Yeild
{
    public class YEILD
    {
        public static void run()
        {
            IEnumerable<int> nums = GenerateV1();
            Console.WriteLine("\n\nusing collection");
            foreach (int i in nums)
            {
                Console.Write($" {i}");
            }

            Console.WriteLine("\n\nusing yield");
            foreach (int i in GenerateV2())
            {
                Console.Write($" {i}");
            }

            Console.WriteLine("\n\nusing yield v3");
            foreach (int i in GenerateV3())
            {
                Console.Write($" {i}");
            }
        }

        static IEnumerable<int> GenerateV1()
        {
            List<int> list = new List<int>();   
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            return list;
        }

        static IEnumerable<int> GenerateV2()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }
        }
        static IEnumerable<int> GenerateV3()
        {
            yield return 0;
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
            yield return 5;
            yield return 6;
            yield return 7;
            yield return 8;
            yield return 9;
            yield break;
            yield return 10;
            yield return 11;
        }
    }
}
