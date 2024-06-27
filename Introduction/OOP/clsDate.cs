using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.OOP
{
    public class clsDate
    {
        private static readonly int[] DaysToMonth365 = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] DaysToMonth366 = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        // Read-only means that a read-only field can only change its value in the constructor
        private readonly int year = 01;
        private readonly int month = 01;
        private readonly int day = 01;

        public clsDate(int year, int month, int day)
        {
            // constructor helps us validate the data when we set it
            bool isLeap = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

            if (year > 1 && year < 9999 & month > 1 && month < 12)
            {
                int [] days = isLeap ? DaysToMonth366 : DaysToMonth365;

                if (day <= days[month] && day >= 1) 
                {
                    this.year = year;
                    this.month = month;
                    this.day = day;
                }
                else
                {
                    this.year = 01;
                    this.month = 01;
                    this.day = 01;
                }

            }
            else
            {
                this.year = 01;
                this.month = 01;
                this.day = 01;
            }
        }

        // overloading
        public clsDate(int year) : this(year, 01, 01)
        {

        }
        public string GetDate()
        {
            return $"{day.ToString().PadLeft(2, '0')}/{month.ToString().PadLeft(2, '0')}/{year}";
        }
    }
    public class clsEmployees
    {
        //public clsEmployees(int id)
        //{
        //    this.id = id;
        //}

        // The private modifier is not applicable to top-level classes, only to nested classes and class members.
        private clsEmployees(int id)
        {
            this.id = id;
        }

        public int id;
        public string FirstName; 
        public string LastName;
        public double Wage;

        // factory method
        public static clsEmployees Create(int id)
        {
            return new clsEmployees(id);
        }
    }

    public class clsConstructor
    {
        private static void print(clsEmployees employee)
        {
            Console.WriteLine($"id: {employee.id}");
            Console.WriteLine("full name: " + employee.FirstName + " " + employee.LastName);
            Console.WriteLine("wage: " + employee.Wage);
        }
        public static void run()
        {
            clsDate date = new clsDate(1999, 2, 28);

            Console.WriteLine(date.GetDate());


            // object initilaizer
            //clsEmployees employees = new clsEmployees(10)
            //{
            //    FirstName = "Omer",
            //    LastName = "MEMES",
            //    Wage = 15500,
            //};

            clsEmployees employees = clsEmployees.Create(100);
            employees.FirstName = "Omer";
            employees.LastName = "MEMES";
            employees.Wage = 15500;


            print(employees);
        }
    }

}
