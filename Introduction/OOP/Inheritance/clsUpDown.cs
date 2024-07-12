using System;

/*
    why inheritance ? 
    reusability 
    maintainability
    extensibility
    
    upcasting: creates a base class reference from a sub class reference
    downcasting: creates a sub class reference from a base class refernce 
*/

namespace Introduction.OOP.Inheritance
{
    public class Animal
    {
        protected void Move()
        {
            Console.WriteLine("moving");
        }
    }

    public class Eagle : Animal
    {
        public void Flying()
        {
            Console.WriteLine("flying");
        }
    }
    public class Falcon : Animal
    {
        public void Flying()
        {
            Console.WriteLine("flying");
        }
    }
    public class clsUpDown
    {
        public static void run()
        {
            Eagle eagle1 = new Eagle();
            Animal animal1 = new Animal();

            // upcastring (implicitly)
            animal1 = eagle1;

            // downcasting (explicitly)
            eagle1 = (Eagle)animal1;

            // if it cannot casting then will return null
            eagle1 = animal1 as Eagle;

            //---------------------------------
            Animal animal2 = new Animal();
            Eagle eagle2 = new Eagle();
            Falcon falcon1 = new Falcon();

            animal1 = eagle1;

            //falcon1 = (Falcon)animal1; // --> will take exception

            falcon1 = animal1 as Falcon; // if cannot casting then will return null (no exception)

            if (falcon1 is Falcon)
            {
                Console.WriteLine("it is falcon");
            }
            else
            {
                Console.WriteLine("it is not falcon");
            }






        }
    }
}
