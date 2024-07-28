using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Reflection
{
    
    public class Goon
    {
        public override string ToString()
        {
            return $"{{ Speed: {20}, HitPower: {13}, Strenght:{7} }}";
        }
    }
    public class Agar
    {
        public override string ToString()
        {
            return $"{{ Speed: {21}, HitPower: {15}, Strenght:{5} }}";
        }
    }
    public class Pixa
    {
        public override string ToString()
        {
            return $"{{ Speed: {18}, HitPower: {12}, Strenght:{8} }}";
        }
    }

    public class ActivatorClass
    {
        public static void run()
        {
            int i = new Int32();

            int number = (int)Activator.CreateInstance(typeof(int));

            number = 2;

            Console.WriteLine($"number: {number}");

            DateTime dt = (DateTime) Activator.CreateInstance(typeof(DateTime), 2024, 01, 01);
            Console.WriteLine(dt);

        }

        public static void run2()
        {
            do
            {
                object obj = null;
                Console.WriteLine("\n\nEnter Class Name: ");
                var input = Console.ReadLine();
                try
                {

                    var AssemblyName = typeof(ActivatorClass).Namespace;
                    var enemy = Activator.CreateInstance(typeof(ActivatorClass).Assembly.GetName().Name, $"{AssemblyName}.{input}");
                    obj = enemy.Unwrap();
                }
                catch
                {

                }
                switch (obj)
                {
                    case Goon goon:
                        Console.WriteLine(goon.ToString());
                        break;
                    case Agar agar:
                        Console.WriteLine(agar.ToString());
                        break;
                    case Pixa pixa:
                        Console.WriteLine(pixa.ToString());
                        break;
                    default:
                        Console.WriteLine("Unknown Enemy");
                        break;
                }

            } while (true);
        }
    }
}
