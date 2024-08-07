using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Introduction.Threading_
{
    public class Wallet
    {
        private readonly object _locker = new object();
        public Wallet(string name, decimal bitcoin)
        {
            Name = name;
            Bitcoin = bitcoin;
        }

        public string Name { get; set; }
        public decimal Bitcoin { get; set; }

        public void Credit(decimal amount)
        {
            Bitcoin += amount;
        }
        public void Debit(decimal amount)
        {
            lock (_locker)
            {
                if ((Bitcoin - amount) > 0)
                {
                    Bitcoin -= amount;
                }
                else
                {
                    throw new Exception("Your wallet is not enough to withdraw the amount");
                }
            }
        }
        public void RunRandomTransactions()
        {
            decimal[] amounts = { 10m, 20m, 30m, 40m, -40m, -20m, -10m };
            decimal absValue = 0m;

            foreach (decimal amount in amounts)
            {
                absValue = Math.Abs(amount);

                if (amount < 0)
                {
                    this.Debit(absValue);
                }
                else
                {
                    this.Credit(absValue);
                }
            }
        }
        public override string ToString()
        {
            return $"[{this.Name} -> '{this.Bitcoin:N0}' Bitcoins]";
        }
    }

    public class TransferManager
    {
        private Wallet From;
        private Wallet To;
        private decimal amountToTransfer;
        public TransferManager(Wallet from, Wallet to, decimal amountToTransfer)
        {
            From = from;
            To = to;
            this.amountToTransfer = amountToTransfer;
        }
        public void Transfer()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} trying to lock ... {From}");
            lock (From)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} lock acquired ... {From}");
                Thread.Sleep(1000);

                Console.WriteLine($"{Thread.CurrentThread.Name} trying to lock ... {To}");
                //lock (To)
                //{
                //    From.Debit(amountToTransfer);
                //    To.Credit(amountToTransfer);
                //}

                if (Monitor.TryEnter(To, 1000))
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} lock acquired ... {To}");
                    try
                    {
                        From.Debit(amountToTransfer);
                        To.Credit(amountToTransfer);
                    }
                    catch
                    {

                    }
                    finally
                    {
                        Monitor.Exit(To);
                    }
                }
                else
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} unable to acquire lock on ... {To}");
                }
            }
        }
    }

    public class Example1
    {
        public static void run()
        {
            Wallet wallet1 = new Wallet("Omer MEMES", 44);

            Wallet wallet2 = new Wallet("Ali MEMES", 50);
            Console.WriteLine("------------------------------");
            Console.WriteLine($"{wallet1}");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"{wallet2}");
            Console.WriteLine("------------------------------\n\n");

            TransferManager transferManager1 = new TransferManager(wallet1, wallet2, 20);
            TransferManager transferManager2 = new TransferManager(wallet2, wallet1, 10);
            transferManager1.Transfer();
            var t1 = new Thread(transferManager1.Transfer);
            var t2 = new Thread(transferManager2.Transfer);
            t1.Name = "T1";
            t2.Name = "T2";
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            Console.WriteLine("------------------------------");
            Console.WriteLine($"{wallet1}");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"{wallet2}");
            Console.WriteLine("------------------------------");

        }
        public static void run3()
        {
            Wallet wallet = new Wallet("Omer MEMES", 44);

            Thread t1 = new Thread(()=>wallet.Debit(45));
            Thread t2 = new Thread(()=>wallet.Credit(50));

            Console.WriteLine(wallet);

            t1.Start();
            t2.Start();

            t1.Join();  
            t2.Join();

            Console.WriteLine(wallet);
        }
        public static void run2()
        {
            Thread.CurrentThread.Name = "Main Thread";
            Wallet wallet = new Wallet("Omer MEMES", 44);
            Console.WriteLine(Thread.CurrentThread.Name);
            Console.WriteLine(Thread.CurrentThread.IsBackground);


            Console.WriteLine(wallet);
            Thread t1 = new Thread(wallet.RunRandomTransactions);
            t1.Name = "t1";
            Console.WriteLine($"t1 background thread: {t1.IsBackground}");
            Console.WriteLine($"after declaration {t1.Name} state is: {t1.ThreadState}");

            t1.Start();
            t1.Join();
            Console.WriteLine($"after declaration {t1.Name} state is: {t1.ThreadState}");
            Thread t2 = new Thread(new ThreadStart(wallet.RunRandomTransactions));
            t2.Start();

            Console.WriteLine(wallet);
            Console.WriteLine($"after declaration {t2.Name} state is: {t2.ThreadState}");
        }
        public static void run1()
        {
            Console.WriteLine($"Process: {Process.GetCurrentProcess().Id}");
            Console.WriteLine($"Process: {Process.GetCurrentProcess().ProcessName}");
            Console.WriteLine($"Process: {Process.GetCurrentProcess().MainModule}");
            Console.WriteLine($"Process: {Process.GetCurrentProcess().MachineName}");
            Console.WriteLine($"Thread: {Thread.CurrentThread.ManagedThreadId}");
        }

        
    }
}
