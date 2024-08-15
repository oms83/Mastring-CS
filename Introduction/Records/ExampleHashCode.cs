using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Records
{
    public class Emplyee
    {
        public Emplyee(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }

    }
    public struct Customer
    {
        public Customer(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }

    }

    public class ExampleHashCode
    {
        public static void run()
        {
            Emplyee emplyee1 = new Emplyee(1, "Omer MEMES"); // 46104728
            Emplyee emplyee2 = new Emplyee(1, "Omer MEMES"); //12289376
            Console.WriteLine(emplyee1.GetHashCode());
            Console.WriteLine(emplyee2.GetHashCode());

            Customer customer1 = new Customer(2, "Ali MEMES"); // 346948958
            Customer customer2 = new Customer(2, "Ali MEMES"); // 346948958
            Console.WriteLine(customer1.GetHashCode());
            Console.WriteLine(customer2.GetHashCode());
        }
    }
}
