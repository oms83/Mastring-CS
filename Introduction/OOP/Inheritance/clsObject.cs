using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.OOP.Inheritance
{
    namespace OBJ
    {
        /*
         
            When a class does not inherit any class, it has already implicitly inherited the Object class
            In inheritance only constructor does not inherit implicitly 
        
         */
        public class Animal : Object
        {
            public string Name { get; set; }
            public Animal(string name)
            {
                base.GetType();
                Name = name;
            }
            public override string ToString()
            {
                return base.ToString();
            }

            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }
        }

        public class Dog : Animal
        {
            public Dog(string name) : base(name)
            {

            }
        }

        public class clsObject
        {
            public static void run()
            {
                Animal animal = new Animal("dog losi");

                
                Console.WriteLine(animal.ToString()); // animal.ToString(): Introduction.OOP.Inheritance.OBJ.Animal

                Console.WriteLine(typeof(Animal)); // Introduction.OOP.Inheritance.OBJ.Animal
                
                Console.WriteLine(animal.GetType()); // Introduction.OOP.Inheritance.OBJ.Animal
            }
        }
    }
}
