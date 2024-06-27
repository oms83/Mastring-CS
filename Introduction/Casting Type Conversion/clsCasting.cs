using System;

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
        public static void examle2()
        {
            string strNum = "12";
            int num = int.Parse(strNum);
            //strNum = "w12";
            //num = int.Parse(strNum); // error
            

        }

        public static void example3()
        {
            string input = "123";
            int result;

            // Attempt to parse the string to an integer
            bool success = int.TryParse(input, out result);

            if (success)
            {
                Console.WriteLine($"Parsing succeeded. The number is {result}.");
            }
            else
            {
                Console.WriteLine("Parsing failed.");
            }

            // Example with an invalid input
            input = "abc";
            success = int.TryParse(input, out result);

            if (success)
            {
                Console.WriteLine($"Parsing succeeded. The number is {result}.");
            }
            else
            {
                Console.WriteLine("Parsing failed.");
            }
        }

        public static void example4()
        {
            string number = "122";
            int result1  = Convert.ToInt32(number); // true

            string number2 = "99999999999999999999999999999";
            int result2 = Convert.ToInt32(number2); // error over flow exception

            string number3 = "12j";
            int result3 = Convert.ToInt32(number3); // format exception
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
