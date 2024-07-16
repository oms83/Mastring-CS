using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.OOP.Interface.Tight_vs_Loos
{
    namespace Loos
    {
        class Cash : IPayment
        {
            public void pay(decimal amount)
            {
                Console.WriteLine($"cash pay: {Math.Round(amount, 2):C}");
            }
        }
        class Debit : IPayment
        {
            public void pay(decimal amount)
            {
                Console.WriteLine($"debit pay: {Math.Round(amount, 2):C}");
            }
        }
        class Viza : IPayment
        {
            public void pay(decimal amount)
            {
                Console.WriteLine($"viza pay: {Math.Round(amount, 2):C}");
            }
        }
        class Mastercart : IPayment
        {
            public void pay(decimal amount)
            {
                Console.WriteLine($"mastercart pay: {Math.Round(amount, 2):C}");
            }
        }

        public interface IPayment
        {
            void pay(decimal amount);
        }

        public class Cashier
        {
            IPayment payment;

            public Cashier(IPayment payment)
            {
                this.payment = payment;
            }

            public void Checkout(decimal amount)
            {
                payment.pay(amount);
            }
        }

        internal class LoosCoupling
        {
           public static void run()
            {
                Cashier cashier = new Cashier(new Cash());
                cashier.Checkout(120);

                cashier = new Cashier(new Mastercart());
                cashier.Checkout(150);

                cashier = new Cashier(new Viza());
                cashier.Checkout(552);

                Debit debit = new Debit();
                cashier = new Cashier(debit);
                cashier.Checkout(100);
                
            }
        }
    }
}
