using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.OOP.Operating_Overloading
{
    public class Money
    {
        private decimal _amount;
        public decimal Amount => _amount;
        public Money(decimal amount)
        {
            _amount = Math.Round(amount, 2);
        }

        public static Money operator +(Money one, Money two)
        {
            return new Money(one.Amount + two.Amount);
        }
        public static Money operator -(Money one, Money two)
        {
            return new Money(one.Amount + two.Amount);
        }
        public static bool operator >(Money one, Money two)
        {
            return one.Amount > two.Amount;
        }
        public static bool operator <(Money one, Money two)
        {
            return one.Amount < two.Amount;
        }

        public static bool operator >=(Money one, Money two)
        {
            return one.Amount >= two.Amount;
        }
        public static bool operator <=(Money one, Money two)
        {
            return one.Amount <= two.Amount;
        }
        public static bool operator ==(Money one, Money two)
        {
            return one.Amount > two.Amount;
        }
        public static bool operator !=(Money one, Money two)
        {
            return one.Amount > two.Amount;
        }

        public static Money operator ++(Money one)
        {
            decimal value = one.Amount; 
            return new Money(++value);
        }

        public static Money operator --(Money one)
        {
            decimal value = one.Amount;
            return new Money(--value);
        }
    }

    public class clsOperatorOverLoading
    {
        public static void run()
        {
            Money money1 = new Money(150);
            Money money2 = new Money(100);

            Money money3 = money1 + money2;
            Money money4 = money1 - money2;
            Money money5 = ++money1;

            Console.WriteLine($"money1 + money2 = {money3.Amount}");
            Console.WriteLine($"money1 - money2 = {money4.Amount}");
            Console.WriteLine($"++money1 = {money5.Amount}");
            Console.WriteLine($"++money1 = {(++money5).Amount}");

            bool value = money1 > money2;

            Console.WriteLine($"money1 > money2 = {value}");
        }
    }
}
