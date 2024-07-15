using System;

namespace Introduction.OOP.Inheritance
{
    namespace Practices
    {
        public abstract class clsEmployee
        {
            public enum enWagePerHour { Developer = 14, Sales = 8, Maintenance = 9, Manager = 10 }

            private const decimal MinLoggedHours = 176;
            private const decimal OverTimeRate = 1.25m;
            public int ID { get; set; }
            public string Name { get; set; }
            public decimal LoggedHours { get; set; }
            public decimal Wage { get; set; }
            public decimal OverTime => CalculateOverTime();
            public decimal BasicSalary { get => Wage * LoggedHours; private set => BasicSalary = value; }
            public abstract decimal NetSalary { get; } 

            private decimal CalculateOverTime()
            {
                decimal TotalHours = LoggedHours - MinLoggedHours;
                decimal AdditionalHours = TotalHours >= 0 ? TotalHours : 0;
                return AdditionalHours * Wage * OverTimeRate;
            }
            protected virtual decimal CalculateSalary()
            {
                decimal TotalHours = LoggedHours - MinLoggedHours;
                decimal AdditionalHours = TotalHours >= 0 ? TotalHours : 0;

                return (Wage * MinLoggedHours) + (AdditionalHours * Wage * OverTimeRate);
            }
            public clsEmployee(int ID, string Name, decimal LoggedHours, decimal Wage)
            {
                this.ID = ID;
                this.Name = Name;
                this.LoggedHours = LoggedHours;
                this.Wage = Wage;
            }

            public override string ToString()
            {
                return $@"ID: {ID}
Name: {Name}
Wage: {Wage}
Logged Hours: {LoggedHours}
Over Time: {OverTime}
Net Salary: {Math.Round(NetSalary, 2):N0}";
            }
        }
    }
}
