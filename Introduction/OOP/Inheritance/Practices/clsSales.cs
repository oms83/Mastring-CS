using System;

namespace Introduction.OOP.Inheritance
{
    namespace Practices
    {
        public class clsSales : clsEmployee
        {
            protected override decimal CalculateSalary()
            {
                return base.CalculateSalary() + Bouns;
            }
            public override decimal NetSalary
            {
                get
                {
                    return this.CalculateSalary();
                }
            }
            public decimal Bouns => Commission * Sales;

            public decimal Commission { get; set; }
            public decimal Sales { get; set; }

            public clsSales(int ID, string Name, decimal LoggedHours, decimal Wage, decimal Commission, decimal Sales)
                : base(ID, Name, LoggedHours, Wage)
            {
                this.Commission = Commission;
                this.Sales = Sales;
            }

            public override string ToString()
            {
                return $@"{base.ToString()}
Sales: {Sales}
Commission: {Commission}
Bouns: {Bouns}
Net Salary: {Math.Round(NetSalary, 2):N0}";
            }
        }
    }
   
}
