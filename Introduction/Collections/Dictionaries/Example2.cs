using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Collections.Dictionaries
{
    /*
        List & Dictionary

        - Random Access الوصول العشوائي
        - Kept in memory after processing الاحتفاز بالذاكرة بعد المعالجة
        - Contiguous memory ذاكرة متجاورة
    */
    public class Employee
    {
        public Employee(int iD, string name, int ?reportTo)
        {
            ID = iD;
            Name = name;
            ReportTo = reportTo;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int? ReportTo { get; set; }

        public override string ToString()
        {
            return $"{ID} - {Name} - {ReportTo}";
        }

    }

    public class Example2
    {
        public static void run()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(1, "Omer", null),
                new Employee(101, "Ali", 1),
                new Employee(102, "Osman", 101),
                new Employee(103, "Yusuf", 1),
                new Employee(104, "Musa", 103),
                new Employee(105, "Muhammed", 101),
            };

            var emps = employees.ToLookup(e => e.ReportTo).ToDictionary(x => x.Key ?? -1, x => x.ToList());
       
            Console.WriteLine("\n\n");
            foreach (var employee in emps)
            {
                if (employee.Key == -1)
                    continue;

                //Console.WriteLine($"\n{employee.Key}");
                var manager = employees.FirstOrDefault(y => y.ID == employee.Key);
                Console.WriteLine($"\n{manager}");

                foreach (var item in employee.Value)
                {
                    Console.WriteLine($"\t{item}");
                }
            }

            Console.WriteLine();
        }
    }
}

