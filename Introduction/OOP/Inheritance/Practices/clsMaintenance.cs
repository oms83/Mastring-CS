using System;

namespace Introduction.OOP.Inheritance
{
    namespace Practices
    {
        public class clsMaintenance : clsEmployee
        {
            private decimal CalculateHardship => CalculateSalary() + HardShip;

            public override decimal NetSalary
            {
                get
                {
                    return CalculateSalary() + CalculateHardship;
                }
            }

            public const decimal HardShip = 100m;

            public clsMaintenance(int ID, string Name, decimal LoggedHours, decimal Wage)
                : base(ID, Name, LoggedHours, Wage)
            {
            }

            public override string ToString()
            {
                return $@"{base.ToString()}
Hard Ship: {HardShip}
Net Salary: {Math.Round(NetSalary, 2):N0}";
            }
        }
    }
   
}
