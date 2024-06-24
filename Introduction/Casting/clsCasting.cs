using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Casting
{
    public class clsCasting
    {
        Int16 @short = 10;
        Int32 @int = 20;
        Int64 @long = 30;
        uint @uint = 31;
        ulong @ulong = 32;

        public void ex()
        {
            // boxing   -> value to referece
            // unboxing -> reference to value

            // Implicit Casting (automatically)
            int num = 123;
            double dNum = num; // int to double

            Console.WriteLine($"Implicit Casting: int {num} to double {dNum}");

            // Explicit Casting (manually)
            double anotherDouble = 123.45;
            int anotherInt = (int)anotherDouble; // double to int

            Console.WriteLine($"Explicit Casting: double {anotherDouble} to int {anotherInt}");

            // Casting with classes
            Animal myAnimal = new Dog(); // Implicit casting from Dog to Animal
            Dog myDog = (Dog)myAnimal; // Explicit casting from Animal to Dog

            Console.WriteLine("Animal is now casted to Dog:");
            myDog.Bark();
        }
    }
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }
}
