using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.OOP
{
    // class modifiers -> private, protected, public, internal (default)
    /*
        public: The class is accessible from any other code in the same assembly or another assembly 
                that references it. 

        internal: The class is accessible only within files in the same assembly.

        protected: The protected modifier is not applicable to classes, only to class members. However, 
                   a class can be nested within another class and have protected access.

        private: The private modifier is not applicable to top-level classes, only to nested classes and class members.

        Inheritance Modifiers

        abstract: The class cannot be instantiated. Other classes must derive from this class.
        
        sealed: The class cannot be inherited.
        
        static: The class cannot be instantiated. It can only contain static members.

        static: The class cannot be instantiated. It can only contain static members.
    */
    public class clsEmployee
    {
        // Access modifiers: public, protected, private
        public const double TAX = 0.03;

        // fields
        public string FName;
        public string LName;
        public double Wage;
        public double LoggedHours;

        public clsEmployee() { }
        public clsEmployee(string fName, string lName, double wage, double loggedHours)
        {
            FName = fName;
            LName = lName;
            Wage = wage;
            LoggedHours = loggedHours;
        }

        public override string ToString()
        {
            // without constructor does not work
            return $"Full Name: {FName} {LName}\nWage: {Wage}\nLogged Hours: {LoggedHours}";
        }
    }

    public class OOP
    {
        private static void print(clsEmployee employee)
        {
            Console.WriteLine(employee.FName + " " + employee.LName);
            Console.WriteLine(employee.LoggedHours);
            Console.WriteLine(employee.Wage);
        }
        public static void run()
        {
            //------------------------------------------------------

            // object(instance)
            clsEmployee employee = new clsEmployee();

            employee.LName = "omer";
            employee.FName = "memes";
            employee.LoggedHours = 10;
            employee.Wage = 200;

            print(employee);

            //------------------------------------------------------

            clsEmployee employee2 = new clsEmployee();

            Console.WriteLine("enter your first name: ");
            employee2.LName = Console.ReadLine();

            Console.WriteLine("enter your last name: ");
            employee2.FName = Console.ReadLine();

            Console.WriteLine("enter logged hours: ");
            employee2.LoggedHours = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter wage per hour: ");
            employee2.Wage = Convert.ToDouble(Console.ReadLine());

            print(employee2);



            //------------------------------------------------------

            clsEmployee employee3 = new clsEmployee("omer", "memes", 122, 430);
            Console.WriteLine(employee3.ToString());


            //------------------------------------------------------
            clsEmployee[] arrEmployees = new clsEmployee[10];
            arrEmployees[0] = new clsEmployee();
            arrEmployees[0].LName = "osman";
            arrEmployees[0].FName = "osman";
            arrEmployees[0].LoggedHours = 100;
            arrEmployees[0].Wage = 50;

            arrEmployees[1] = employee2 as clsEmployee;
            Console.WriteLine(employee2.ToString());


        }
    }
}
