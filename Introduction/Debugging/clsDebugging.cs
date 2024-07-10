using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Debugging
{
    internal class clsDebugging
    {
        /*
            Error types:
                syntax error
                runtime error => try, cath
                logical error

        */
        static decimal ConvertCelisiusToFehrenhite(decimal celisius)
        {
            var fehrenhite = 0m;
            fehrenhite = (celisius * 9 / 5) + 32;
            return fehrenhite;
        }
        static decimal ConvertFehrenhiteToCelisius(decimal fehrenhite)
        {
            var celisius = 0m;
            celisius = (fehrenhite - 32) * 5 / 9;
            return celisius;
        }
        public static void run()
        {
            Console.WriteLine($"F To C: {ConvertFehrenhiteToCelisius(32)}");
            Console.WriteLine($"C To F: {ConvertCelisiusToFehrenhite(0)}");
        }
    }
}
