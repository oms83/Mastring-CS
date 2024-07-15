using System;

namespace Introduction.OOP.Inheritance
{
    namespace Practices
    {
        public class clsDeveloper : clsEmployee
        {
            private const decimal Commission = .03m;

            protected override decimal CalculateSalary()
            {
                return this.Bouns + base.CalculateSalary();
            }

            public override decimal NetSalary
            {
                get
                {
                    return CalculateSalary();
                }
            }

            public decimal Bouns => TaskCompleted ? Commission * base.CalculateSalary() : 0;

            public bool TaskCompleted { get; set; }

            public clsDeveloper(int ID, string Name, decimal LoggedHours, decimal Wage, bool TaskCompleted) 
                : base(ID, Name, LoggedHours, Wage)
            {
                this.TaskCompleted = TaskCompleted;
            }

            public override string ToString()
            {
                return $@"{base.ToString()}
TaskCompleted: {TaskCompleted}
Bouns: {Bouns}
Commission: {Commission}
Net Salary: {Math.Round(NetSalary, 2):N0}";
            }
        }
    }
   
}
