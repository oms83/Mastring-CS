using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Assemblies
{
    internal class Example2
    {
        public static void run()
        {
            var type = typeof(Example2);
            var assembly = type.Assembly;

            Console.WriteLine(type);
            var stream = assembly.GetManifestResourceStream("Introduction.Assemblies.data.json");
            var data = new BinaryReader(stream).ReadBytes((int)stream.Length);
            for (int i = 0; i < data.Length; i++)
            {
                System.Threading.Thread.Sleep(200);
                Console.Write($"{(char)data[i]}");
            }
            stream.Close(); 
            Console.WriteLine(stream.Length);
        }
    }
}
