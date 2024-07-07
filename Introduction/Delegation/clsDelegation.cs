using Introduction.OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Delegation
{
    public class clsRepo
    {
        private static List<clsEmpoyees> repo = new List<clsEmpoyees>()
        {
            new clsEmpoyees("Omer", "MEMES", 24, 20000m),
            new clsEmpoyees("Ali", "Sultan", 23, 15000m),
            new clsEmpoyees("Yusuf", "MEMES", 21, 13000m),
            new clsEmpoyees("Osman", "Sultan", 20, 19000m),
        };

        public static List<clsEmpoyees> GetAllEmployees()
        {
            return repo;
        }
        public void AddNewEmployee(clsEmpoyees employee)
        {
            repo.Add(employee);
        }
    }
    public class clsReport
    {
        public delegate bool employeesFilteringCondition(clsEmpoyees employee);
        public static void EmployeesSalariesAreGreaterThan20000(List<clsEmpoyees> empoyees, string message)
        {
            Console.WriteLine(message);
            foreach (clsEmpoyees empoyee in empoyees)
            {
                if (empoyee.Salary >= 20000m)
                {
                    Console.WriteLine($"Full Name: {empoyee.FirstName} {empoyee.LastName}   Age: {empoyee.Age}   Salary: {empoyee.Salary}");
                }
            }
        }
        public static void EmployeesNamesStartWithO(List<clsEmpoyees> empoyees, string message)
        {
            Console.WriteLine(message);
            foreach (clsEmpoyees empoyee in empoyees)
            {
                if (empoyee.FirstName.ToLowerInvariant().StartsWith("o"))
                {
                    Console.WriteLine($"Full Name: {empoyee.FirstName} {empoyee.LastName}   Age: {empoyee.Age}   Salary: {empoyee.Salary}");
                }
            }
        }

        public static void Filter(List<clsEmpoyees> employees, employeesFilteringCondition filter, string message)
        {
            Console.WriteLine(message);

            foreach (clsEmpoyees employee in employees)
            {
                if (filter(employee))
                {
                    Console.WriteLine($"Full Name: {employee.FirstName} {employee.LastName}   Age: {employee.Age}   Salary: {employee.Salary}");
                }
            }
        }
    }

    public class clsEmpoyees
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public short Age { get; set; }

        public decimal Salary { get; set; }

        public clsEmpoyees(string firstName, string lastName, short age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

    }

    public static class clsDelegation
    {
        public static bool EmployeesSalariesAreGreaterThan20000(clsEmpoyees emp) => emp.Salary >= 20000m;
        public static bool EmployeesNamesStartWithO(clsEmpoyees emp) => emp.FirstName.ToLowerInvariant().StartsWith("o");
        public static void run()
        {

            var lstEmployees = clsRepo.GetAllEmployees();

            clsReport.EmployeesSalariesAreGreaterThan20000(lstEmployees, "\nEmployee salaries are greater than 20,000\n");
            clsReport.EmployeesNamesStartWithO(lstEmployees, "\n\nEmployees Names Start With \'O\'\n");

            clsReport.Filter(lstEmployees, EmployeesSalariesAreGreaterThan20000, "\nEmployee salaries are greater than 20,000\n");
            clsReport.Filter(lstEmployees, EmployeesNamesStartWithO, "\n\nEmployees Names Start With \'O\'\n");

            clsReport.Filter(lstEmployees, delegate(clsEmpoyees emp) { return emp.Salary >= 20000m; }, "\nEmployee salaries are greater than 20,000\n");
            clsReport.Filter(lstEmployees, delegate (clsEmpoyees emp) { return emp.FirstName.ToLowerInvariant().StartsWith("o"); }, "\n\nEmployees Names Start With \'O\'\n");

            clsReport.Filter(lstEmployees, (clsEmpoyees emp) => emp.Salary >= 20000m , "\nEmployee salaries are greater than 20,000\n");
            clsReport.Filter(lstEmployees, (clsEmpoyees emp) => emp.FirstName.ToLowerInvariant().StartsWith("o"), "\n\nEmployees Names Start With \'O\'\n");

            clsReport.Filter(lstEmployees, emp => emp.Salary >= 20000m, "\nEmployee salaries are greater than 20,000\n");
            clsReport.Filter(lstEmployees, emp => emp.FirstName.ToLowerInvariant().StartsWith("o"), "\n\nEmployees Names Start With \'O\'\n");


        }
    }
}
