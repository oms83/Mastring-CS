using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.String_Builder
{
    public class Example
    {
        public static void run()
        {
            GenerateWithString();
            GenerateWithStringBulider();
        }

        static void GenerateWithString()
        {
            // string class is immutable data type
            string name = null;

            name += String.Format("om{0}{1}", 'e', 'r'); // new sapace in memeory

            name += String.Concat(new char[] { ' ', 'm', 'e', 'm', 's', 'e' }); // new sapace in memeory

            name = "Name: " + name; // new sapace in memeory

            name = name.Replace("memse", "memes"); // new sapace in memeory

            Console.WriteLine(name);
        }

        static void GenerateWithStringBulider()
        {
            // string class is mutable data type
            StringBuilder name = new StringBuilder();

            name.AppendFormat("om{0}{1}", 'e', 'r'); // same sapace in memeory

            name.Append(new char[] { ' ', 'm', 'e', 'm', 's', 'e' }); // same sapace in memeory

            name.Insert(0, "Name: "); // same sapace in memeory

            name.Replace("memse", "memes"); // same sapace in memeory

            Console.WriteLine(name);
        }
    }
}
