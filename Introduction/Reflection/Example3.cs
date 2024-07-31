using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Reflection
{
    public class Example3
    {
        public static void run()
        {
            var path = "C:\\Users\\omerm\\Desktop\\FIRAT.dll";

            var assembly = Assembly.LoadFile(path);

            var types = assembly.GetTypes();

            foreach (var type in types)
            {
                Console.WriteLine(type);
            }


        }
    }
}
