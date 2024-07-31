using Introduction.OOP.Inheritance.Practices;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Reflection
{
    public class BankAccount
    {
        public string name;

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
        private static void OnNegative_Balance(object sender, decimal amount)
        {
            var banckAccount = (BankAccount)sender;

            var banckAccount2 = sender as BankAccount;
            
            Console.WriteLine($"Negative Balance!!! Balance: ${banckAccount2.Balance}");
        }

        public static void run2()
        {
            Console.WriteLine("\n\nMemeber Info");
            MemberInfo[] members = typeof(BankAccount).GetMembers(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance); 

            foreach (MemberInfo member in members)
            {
                Console.WriteLine(member);
            }




            Console.WriteLine("\n\nField Info");
            FieldInfo[] fields = typeof(BankAccount).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (MemberInfo field in fields)
            {
                Console.WriteLine(field);
            }




            Console.WriteLine("\n\nProperty Info");
            PropertyInfo[] properties = typeof(BankAccount).GetProperties(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (MemberInfo property in properties)
            {
                Console.WriteLine(property);
            }




            BankAccount bnk = new BankAccount("4444", "Omer MEMES", 4000m);

            bnk.name = "Ziraat Bank";

            Console.WriteLine($"{bnk.name} {bnk.ToString()}");




            Console.WriteLine("\n\nConstructor Info");
            ConstructorInfo[] constructorInfos = typeof(BankAccount).GetConstructors();
            foreach (ConstructorInfo constructor in constructorInfos)
            {
                Console.WriteLine(constructor);
            }



            Console.WriteLine("\n\nCtors");

            MemberInfo[] ctors = typeof(BankAccount).GetMember(".ctor");
            foreach (MemberInfo ctor in ctors)
            {
                Console.WriteLine(ctor);
            }

            Console.WriteLine("\n\nProperties");
            MemberInfo[] properties2 = typeof(BankAccount).GetMember("");
            foreach(MemberInfo property in properties2)
            { 
                Console.WriteLine(property);
            }


            // invoke method
            var account = new BankAccount("1234", "Ali MEMES", 1000m);
            Type t = typeof(BankAccount);
            Type[] parametersType = { typeof(decimal) };
            MethodInfo method = t.GetMethod("Deposit");
            method.Invoke(account, new object[] {500m});

            Console.WriteLine(account) ;
        } 

    }
}
