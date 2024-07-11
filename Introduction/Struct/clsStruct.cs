using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Struct
{
    public readonly struct stPerson
    {
        public readonly int age;
        public readonly string name;

        // here we cannot use non readonlye field because the struct already is readonly
        //public string surname;
        /*
            readonly case we can use it with struct but we cannot use it with class 
            readonly case allow us to set value to field only by field initialzition and in constructor.
        */
        public stPerson(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
    }

    public class clsStruct
    {
        public readonly int age;
        public readonly string name;
        // here we can use non readonly field
        public string surname;

        public clsStruct(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public struct stWithNew
        {
            public int id;
            public void show() => Console.WriteLine("st with new");
        }
        public struct stWithoutNew
        {
            public int id;
            public void show() => Console.WriteLine("st without new");
        }

        public static void run()
        {
            // date time is a readonly struct
            DateTime dateTime = new DateTime(2024, 3, 8, 23, 44, 1);
            dateTime.AddYears(1);
            dateTime.AddMonths(1);
            dateTime.AddDays(1);
            dateTime.AddHours(1);
            dateTime.AddMinutes(1);
            dateTime.AddSeconds(1);
            dateTime.AddMilliseconds(1);

            // cannot be assigned, it is readonly 😊
            //dateTime.Day = 2;
            DateTime DT = dateTime;
            dateTime.AddHours(10);
            Console.WriteLine(DT);
            Console.WriteLine(dateTime);

            //-----------------------------

            stWithNew instanse1 = new stWithNew();
            stWithoutNew instance2;
            
            // we must be initialized all field in struct when we not use the new keyword
            instance2.id = 1;
            instance2.show();



        }
    }
}
