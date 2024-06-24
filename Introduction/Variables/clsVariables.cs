using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Variables
{
    internal class clsVariables
    {
        public static void ex()
        {
            var @float = 0f;
            var @decimal = 0m;
            var @double = 0d;
            var u = 0u;
            var @long = 0l;
            var @unsignlong = 9ul;

            int oneMillion = 1_000_000;

            int y;
            //var x; error

            var x = 10;
            //x = "omer"; error

            dynamic m = 10;
            m = "omer";
            m = 10.3;
            m = 'o';


        }
    }
}
