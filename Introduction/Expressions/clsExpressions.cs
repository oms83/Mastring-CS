using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Expressions
{
    internal class clsExpressions
    {
        public static void ex()
        {
            //Null coalescing
            string name = null;
            Console.WriteLine(name); // null
            name = name ?? "omer";
            Console.WriteLine(name); // omer

            // Null Conditional
            name = name is null ? null : name.ToUpper();


        }
    }
}
