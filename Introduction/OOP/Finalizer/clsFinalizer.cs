using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.OOP.Finalizer
{
    public class Example
    {
        public Example()
        {
            Console.WriteLine("object is constructred");
        }
        ~Example()
        {
            Console.WriteLine("object is destroyed");
        }

        public static void MakeSomeGarbage()
        {
            Version v;

            for (int i = 0; i < 1000; i++)
            {
                v = new Version();
            }
        }

    }
    public class clsFinalizer
    {
        static public void run()
        {
            Example ex = new Example();

            Example.MakeSomeGarbage();

            Console.WriteLine($"Memory used before collection {GC.GetTotalMemory(false):N0}");
            GC.Collect(); // Explicit cleaning
            Console.WriteLine($"Memory used before collection {GC.GetTotalMemory(false):N0}");
        }
        
    }
}
