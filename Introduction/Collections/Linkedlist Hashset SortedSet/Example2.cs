using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Introduction.Collections.Linkedlist_Hashset_SortedSet
{
    public class Customer : IComparable<Customer>
    {
        public Customer(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }

        public string Name { get; set; }
        public string Phone { get; set; }

        public override int GetHashCode()
        {
            var hash = 17;
            hash = hash * 397 + Phone.GetHashCode();

            return hash;
        }

        public override bool Equals(object obj)
        {
            var other = obj as Customer;
            
            if (other is null)
            {
                return false;
            }

            return this.Phone.Equals(other.Phone);
        }
        public override string ToString()
        {
            return $"{Name} - [{Phone}]";
        }

        public int CompareTo(Customer other)
        {
            if (object.ReferenceEquals(this, other))
            {
                return 0;
            }

            if (other == null)
            {
                return -1;
            }

            return this.Name.CompareTo(other.Name);
        }
    }

    public class Example2
    {
        public static void run()
        {
            Customer customer1 = new Customer("Omer MEMES", "+90 539 891 48 01");
            Customer customer2 = new Customer("Ali MEMES", "+90 539 891 48 02");
            Customer customer3 = new Customer("Osman MEMES", "+90 539 891 48 03");
            Customer customer4 = new Customer("Yusuf MEMES", "+90 539 891 48 04");
            Customer customer5 = new Customer("Musa MEMES", "+90 539 891 48 05");
            Customer customer6 = new Customer("Osama MEMES", "+90 539 891 48 06");

            Console.WriteLine(customer1 == customer2);
            Console.WriteLine(customer1.Equals(customer2));

            List<Customer> customers = new List<Customer>()
            {
                customer1,
                customer2,
                customer3,
                customer4,
                customer5,
                customer6,
            };

            HashSet<Customer> hstCustomers = new HashSet<Customer>(customers);
            hstCustomers.Add(customer1);
            hstCustomers.Add(customer1); // hash set will not allows duplicated data and we 
                                         // will not take an exception

            foreach (Customer customer in hstCustomers)
            {
                Console.WriteLine(customer);
            }

            HashSet<Customer> hstCustomers2 = new HashSet<Customer>()
            {
                new Customer("Abdulrahamn MEMES", "+90 539 891 48 00"),
                new Customer("Abdullah MEMES", "+90 539 891 48 09"),
                new Customer("Muhammed MEMES", "+90 539 891 48 10"),
            };

            hstCustomers.UnionWith(hstCustomers2);

            Console.WriteLine();
            foreach (Customer customer in hstCustomers)
            {
                Console.WriteLine(customer);
            }
            //Failed to compare two elements in the array
            /*
                we should be inherit ICompareble and implement compare method
             */


            SortedSet<Customer> customers1 = new SortedSet<Customer>(customers);
            foreach (Customer customer in customers1)
            {
                Console.WriteLine(customer);
            }

        }
    }
}
