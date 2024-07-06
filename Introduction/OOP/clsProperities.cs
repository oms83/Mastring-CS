using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.OOP
{
    public class clsDollar
    {
        private decimal _amount;

        // property initialization
        public int amount { get; } = 10;
        public clsDollar()
        {
            
        }
        public clsDollar(decimal amount)
        {
            if (amount > 0)
            {
                _amount = amount;
            }
            else
            {
                _amount = 0;
            }
        }

        private void Validate(decimal amount)
        {
            if (amount > 0)
            {
                _amount = amount;
            }
            else
            {
                _amount = 0;
            }
        }

        public decimal Amount
        {
            get => _amount;
            set => Validate(value);
        }
    }

    public class  clsProperties
    {
        public static void run()
        {
            clsDollar dollar = new clsDollar();

            dollar.Amount = 100;
        }

    }
}
