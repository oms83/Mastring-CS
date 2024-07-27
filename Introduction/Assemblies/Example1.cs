using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Assemblies
{
    public class Employee
    {

    }

    internal class Example1
    {
        public static void run()
        {
            Type type = typeof(Employee);
            Console.WriteLine($"BaseType: {type.BaseType}");
            Console.WriteLine($"Name: {type.Name}");
            Console.WriteLine($"FullName: {type.FullName}");

            Type type2 = typeof(Employee);
            var assembly = type2.Assembly;
            Console.WriteLine($"FullName: {assembly.FullName}");

            var assembly2 = Assembly.GetExecutingAssembly();
            Console.WriteLine(assembly2);

            Console.WriteLine(typeof(DateTime).Assembly.FullName);

            /*
            Type type = typeof(Program);
            Console.WriteLine($"FullName: {type.FullName}");
            Console.WriteLine($"BaseType: {type.BaseType}");
            Console.WriteLine($"Name: {type.Name}");
            var assembly = type.Assembly;
            Console.WriteLine($"Location: {assembly.Location}");
            Console.WriteLine($"FullName: {assembly.FullName}");
            Console.WriteLine($"GetName: {assembly.GetName()}");
            Console.WriteLine($"CodeBase: {assembly.CodeBase}");
            Console.WriteLine("\n\n");
            */
        }

    }
}
