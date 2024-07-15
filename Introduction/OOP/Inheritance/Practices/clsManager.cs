using System;

namespace Introduction.OOP.Inheritance
{
    namespace Practices
    {
        public class clsManager : clsEmployee
        {
            public const decimal Allowance = 0.05m;

            private decimal CalculateAllowance => base.CalculateSalary() * Allowance;

            protected override decimal CalculateSalary()
            {
                return base.CalculateSalary() + CalculateAllowance;
            }
            public override decimal NetSalary
            {
                get
                {
                    return this.CalculateSalary();
                }
            }
            public clsManager(int ID, string Name, decimal LoggedHours, decimal Wage)
                : base(ID, Name, LoggedHours, Wage)
            {

            }
            public override string ToString()
            {
                return $@"{base.ToString()}
Allowance: {Allowance}
Net Salary: {Math.Round(NetSalary, 2):N0}";
            }
        }
    }
   
}
