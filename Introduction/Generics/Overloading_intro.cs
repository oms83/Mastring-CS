using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Generics
{
    namespace overloading
    {
        /*
            these waye lead to problems in:
                performance
                type saftey
                avoid mistakes

            generics solve some problems:
                reusability
                type safety
                efficiency
         */
        public class Person
        {
            public string Name { get; set; }
            public short Age { get; set; }

        }

        public class example
        {
            public void Print(int value) => Console.WriteLine(value);
            public void Print(string value) => Console.WriteLine(value);
            public void Print(char value) => Console.WriteLine(value);
            public void Print(double value) => Console.WriteLine(value);
            public void Print(decimal value) => Console.WriteLine(value);
            public void Print(Person person)
            {
                Console.WriteLine($"Name: {person.Name} Age: {person.Age}");
            }
            public void Print(Object obj)
            {
                Console.WriteLine(obj);
            }
        }

        internal class Overloading_intro
        {
            public static void run()
            {
                example ex = new example();
                ex.Print(10);
                ex.Print(10.4m);
                ex.Print(10.4d);
                ex.Print('c');
                ex.Print("Omer MEMES");

                //anonymouse object Print(Object obj)
                ex.Print(new { Name = "Omer MEMES", Age = 24 });
                
                ex.Print(new Person { Name = "Omer MEMES", Age = 24 });

            }
        }
    }
}
