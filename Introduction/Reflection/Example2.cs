using Introduction.OOP.Inheritance.Practices;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Reflection
{
    public class BankAccount
    {
        private string _accountNo;
        private string _holder;
        private decimal _balance;

        public string AccountNo => _accountNo;
        public string Holder => _holder;
        public decimal Balance => _balance;

        public event EventHandler <decimal>OnNegativeBalance;
        public BankAccount(string accountNo, string holder, decimal balance)
        {
            this._accountNo = accountNo;
            this._holder = holder;
            this._balance = balance;
        }

        
        public void Deposit(decimal amount)
        {
            this._balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            this._balance -= amount;

            if (this._balance < 0)
            {
                OnNegativeBalance.Invoke(this, this.Balance);
            }
        }

        public override string ToString()
        {
            return $"Account No: {_accountNo},  Holder: {_holder},   Balance: ${_balance}";
        }
    }

    public class Example2
    {
        public static void run()
        {
            BankAccount bnk = new BankAccount("4444", "Omer MEMES", 1444.32m);
            Console.WriteLine(bnk.ToString());
            bnk.OnNegativeBalance += OnNegative_Balance;

            bnk.Deposit(100);
            Console.WriteLine(bnk.ToString());

            bnk.Withdraw(2000);
            Console.WriteLine(bnk.ToString());
        }
        public static void OnNegative_Balance(object sender, decimal amount)
        {
            var banckAccount = (BankAccount)sender;

            var banckAccount2 = sender as BankAccount;
            
            Console.WriteLine($"Negative Balance!!! Balance: ${banckAccount2.Balance}");
        }

    }
}
