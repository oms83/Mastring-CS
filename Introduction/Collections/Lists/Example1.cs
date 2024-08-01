using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Collections.Lists
{

    public class Country
    {
        public string ISOCode { get; set; }
        public string Name { get; set; }

        public override int GetHashCode()
        {
            // reduce overflow
            unchecked
            {
                var hash = 19;
                hash = hash * 397 + ISOCode.GetHashCode();
                hash = hash * 397 + Name.GetHashCode();
                return hash;
            }
        }
        public override bool Equals(object obj)
        {
            var country = obj as Country;
            if (country is null)
            {
                return false;
            }
            return this.Name.Equals(country.Name, StringComparison.OrdinalIgnoreCase) &&
                   this.ISOCode.Equals(country.ISOCode, StringComparison.OrdinalIgnoreCase);
        }
        public override string ToString()
        {
            return $"{Name}-{ISOCode}";
        }
    }

    public class Example1
    {
        public static void Print<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
        }

        public static void run()
        {
            List<Country> list = new List<Country>()
            {
                new Country { ISOCode = "SY", Name = "Syria" },
                new Country { ISOCode = "TR", Name = "Turkey" },
                new Country { ISOCode = "EG", Name = "Egypt" }, 
                new Country { ISOCode = "JO", Name = "Jordan" },
                new Country { ISOCode = "US", Name = "United States" },
                new Country { ISOCode = "CA", Name = "Canada" },
                new Country { ISOCode = "GB", Name = "United Kingdom" },
                new Country { ISOCode = "DE", Name = "Germany" },
                new Country { ISOCode = "FR", Name = "France" },
                new Country { ISOCode = "JP", Name = "Japan" },
                new Country { ISOCode = "CN", Name = "China" },
                new Country { ISOCode = "IN", Name = "India" },
                new Country { ISOCode = "BR", Name = "Brazil" },
                new Country { ISOCode = "RU", Name = "Russia" },
                new Country { ISOCode = "IRQ", Name = "Iraq" },

            };
            list.ForEach(country => Console.WriteLine(country));

            list.Add(new Country { ISOCode = "IRQ", Name = "Iraq" });

            Console.WriteLine("\n\nRemove");
            list.Remove(new Country { ISOCode = "IRQ", Name = "Iraq" });
            list.ForEach(country => Console.WriteLine(country));

            Console.WriteLine("\n\nRemove All");
            list.RemoveAll(n => n.Name == "Iraq");
            list.ForEach(country => Console.WriteLine(country));

        }
        public static void run2()
        {
            Country[] countries =
            {
                new Country { ISOCode = "SY", Name = "Syria" },
                new Country { ISOCode = "TR", Name = "Turkey" },
                new Country { ISOCode = "EYG", Name = "Eygpt" },
                new Country { ISOCode = "JOR", Name = "Jordan" },
            };

            foreach (Country country in countries) Console.WriteLine(country + ", ");

            List<Country> list = new List<Country>()
            {
                new Country { ISOCode = "SY", Name = "Syria" },
                new Country { ISOCode = "TR", Name = "Turkey" },
                new Country { ISOCode = "EYG", Name = "Eygpt" },
                new Country { ISOCode = "JOR", Name = "Jordan" },
            };

            list.ForEach(country => Console.WriteLine(country + ", "));

            
            
            list.Add(new Country { ISOCode = "BRA", Name = "Brasil" }); // O(1)

            
            Country Ameriaca = new Country { ISOCode = "USA", Name = "America" };
            Country Rusia =  new Country { ISOCode = "RUS", Name = "Rusia" };
            Country[] arr =
            {
                Ameriaca, Rusia
            };
            list.AddRange(arr); // O(1)


            Country Iraq = new Country { ISOCode = "IRQ", Name = "Iraq" };
            list.Insert(3, Iraq);



            List<int> numbers = new List<int>(5);
            numbers.Add(1); numbers.Add(2); numbers.Add(3); numbers.Add(4); numbers.Add(5); numbers.Add(6);

            Console.WriteLine($"\n\nCapacity: {numbers.Capacity}");
            Console.WriteLine($"Count: {numbers.Count}");

            string[] names = { "omer", "ali", "osman" };
            List<string> lstNames = new List<string>(names);

            Console.WriteLine(string.Join(", ", lstNames));

            Print(lstNames);
        }


    }
}
