using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Introduction.OOP.Inheritance
{
    namespace Practices
    {

        static class Practice
        {
            public static void run()
            {
                // with constructor
                clsDeveloper dev = new clsDeveloper(1, "Omer MEMES", 180, (decimal)clsEmployee.enWagePerHour.Developer, true);
                Console.WriteLine(dev.ToString());



                Console.WriteLine("\n========================================================\n");

                clsSales sls = new clsSales(1, "Omer MEMES", 180, (decimal)clsEmployee.enWagePerHour.Sales, 10, 15);
                Console.WriteLine(sls.ToString());



                Console.WriteLine("\n========================================================\n");

                clsMaintenance mn = new clsMaintenance(1, "Omer MEMES", 180, (decimal)clsEmployee.enWagePerHour.Maintenance);
                Console.WriteLine(mn.ToString());


                Console.WriteLine("\n========================================================\n");

                clsManager mng = new clsManager(1, "Omer MEMES", 180, (decimal)clsEmployee.enWagePerHour.Manager);
                Console.WriteLine(mng.ToString());

                // object initializer without constructor for all derive class and base class
                /*
                    clsDeveloper dev2 = new clsDeveloper
                    {
                        ID = 2,
                        Name = "Ali MEMES",
                        LoggedHours = 190,
                        Wage = (decimal)clsEmployee.enWagePerHour.Developer,
                        TaskCompleted = true
                    };
                    Console.WriteLine(dev2.ToString());
                */

            }
        }
    }
   
}
