using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Generics
{
    public class Person
    {
        public string Name { get; set; }
        public short Age { get; set; }

        public override string ToString()
        {
            return $"{Name} {Age}";
        }

    }
    public class Any<T>
    {
        T[] _items;

        public void Add(T item)
        {
            if (_items is null || _items.Length == 0)
            {
                _items = new T[] { item }; 
            }
            else
            {
                T[]dest = new T[_items.Length + 1];
                for (int i = 0; i < _items.Length; i++)
                {
                    dest[i] = _items[i];
                }
                dest[_items.Length] = item;

                _items = dest;
            }

        }
        public void RemoveAt(int Position)
        {
            if (Position < 0 || Position >= _items.Length)
            {
                return;
            }
            else
            {
                T[] dest = new T[_items.Length - 1];
                int index = 0;
                for (int i = 0; i < _items.Length; i++)
                {
                    if (Position == i)
                    {
                        continue;
                    }
                    dest[index++] = _items[i];
                }
                _items = dest;
            }

        }
        public void Print()
        {
            for (int i = 0; i < _items.Length; ++i)
            {
                Console.Write(_items[i]);
                if (i < _items.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("\n");
        }
    }

    public class GenericClass
    {
        private void Print<T>(T[] _items)
        {
            for (int i = 0; i < _items.Length; ++i)
            {
                Console.Write(_items[i]);
                if (i < _items.Length - 1)
                {
                    Console.Write(", ");
                }
            }
        }
        public static void run()
        {
            var numbers = new Any<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Print();

            numbers.RemoveAt(4);
            numbers.Print();

            Console.WriteLine("-------------------------------");

            Any<string> names = new Any<string>();
            names.Add("Omer");
            names.Add("Ali");
            names.Add("Osman");
            names.Add("Yusuf");

            names.Print();

            Console.WriteLine("-------------------------------");

            Any<Person> persons = new Any<Person>();
            persons.Add(new Person { Name = "Omer", Age = 24 });
            persons.Add(new Person { Name = "Ali", Age = 20 });

            persons.Print();

        }
    }
}
