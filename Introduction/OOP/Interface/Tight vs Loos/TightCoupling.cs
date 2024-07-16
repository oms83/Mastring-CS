using System;


namespace Introduction.OOP.Interface.Tight_vs_Loos
{
    class Cash
    {
        public void pay(decimal amount)
        {
            Console.WriteLine($"cash pay: {Math.Round(amount, 2):C}");
        }
    }
    class Debit
    {
        public void pay(decimal amount)
        {
            Console.WriteLine($"debit pay: {Math.Round(amount, 2):N0}");
        }
    }
    class Viza
    {
        public void pay(decimal amount)
        {
            Console.WriteLine($"viza pay: {Math.Round(amount, 2):N0}");
        }
    }
    class Mastercart
    {
        public void pay(decimal amount)
        {
            Console.WriteLine($"mastercart pay: {Math.Round(amount, 2):N0}");
        }
    }
    class Cashier
    {
        Mastercart mastercart;
        Viza viza;
        Cash cash;
        Debit debit;

        public Cashier(Mastercart mastercart) => this.mastercart = mastercart;
        public Cashier(Debit debit) => this.debit = debit;
        public Cashier(Cash cash) => this.cash = cash;
        public Cashier(Viza viza) => this.viza = viza;

        public void CheckOut_Debit(decimal amount)
        {
            debit.pay(amount);
        }
        public void CheckOut_Mastercart(decimal amount)
        {
            mastercart.pay(amount);
        }
        public void CheckOut_Cash(decimal amount)
        {
            cash.pay(amount);
        }
        public void CheckOut_Viza(decimal amount)
        {
            viza.pay(amount);
        }

    }

    public class TightCoupling
    {

        public static void run()
        {
            Cash cash1 = new Cash();
            Viza viza1 = new Viza();
            Mastercart mastercart1 = new Mastercart();
            Debit debit1 = new Debit();
            

            Cashier cashier = new Cashier(cash1);
            cashier.CheckOut_Cash(100);

            cashier = new Cashier(viza1);
            cashier.CheckOut_Viza(120);

            cashier = new Cashier(mastercart1);
            cashier.CheckOut_Mastercart(160);

            cashier = new Cashier(debit1);
            cashier.CheckOut_Debit(150);
        }
    }
}
