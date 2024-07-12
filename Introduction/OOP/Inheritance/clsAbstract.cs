using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.OOP.Inheritance
{
    /*
                         ABSTRACT CLASS

        1- we cannot create object from abstract class.
        2- abstract class contains abstract memebers.


                        SEALED CLASS

        1- cannot be inherited
    */
    abstract public class clsAnimal
    {
        public void moving()
        {
            Console.WriteLine();
        }
    }
    sealed public class clsEagle : clsAnimal
    {
        public void flying()
        {
            Console.WriteLine();
        }

    }

    //public class AmericanEagle : clsEagle =====> cannot be inherited
    public class AmericanEagle 
    {

    }

    public class clsAbstract
    {
        public static void run()
        {
            //clsAnimal a = new clsAnimal(); error

        }
    }
}
