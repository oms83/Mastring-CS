using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Reflection
{
    internal class Example1
    {
        public class Employee
        {
            public int Id { get; set; } 
        }

        public static void run()
        {
            var type = typeof(DateTime);
            Console.WriteLine($"Name: {type.Name}");
            Console.WriteLine($"FullName: {type.FullName}");
            Console.WriteLine($"BaseType: {type.BaseType}");
            Console.WriteLine($"Namespace: {type.Namespace}");
            Console.WriteLine($"IsPublic: {type.IsPublic}");
            Console.WriteLine($"Assembly: {type.Assembly}");


            Type type3 = typeof(int[,]);
            Console.WriteLine($"Name: {type3.Name}");
            Console.WriteLine($"FullName: {type3.FullName}");
            Console.WriteLine($"BaseType: {type3.BaseType}");
            Console.WriteLine($"Namespace: {type3.Namespace}");

            var nestedTypes = typeof(Employee).GetNestedTypes();
            for (int i = 0; i < nestedTypes.Length; i++)
            {
                Console.WriteLine(nestedTypes[i]);
            }

        }
    }
}
