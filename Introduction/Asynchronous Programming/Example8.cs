using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Introduction.Asynchronous_Programming
{
    internal class Example8
    {
        public static async void run()
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            await DoCheck03(cts);
        }

        static async Task DoCheck01(CancellationTokenSource cts)
        {

            // thread running in background there is no neeed to using await
            // if we use an await the thread will wait us to enter Q character.

            Task.Run(() =>
            {
                var input = Console.ReadKey();
                if (input.Key == ConsoleKey.Q)
                {
                    cts.Cancel();
                    Console.WriteLine("Task has been cancelled!!");
                }
            });


            // if cts excuted it will return true other than this it will return false

            /*
                The IsCancellationRequested property of a CancellationToken associated 
                with a CancellationTokenSource will return true if the cancellation has been requested, 
                meaning if Cancel() has been called on the CancellationTokenSource. Otherwise, it will return false. 
            */

            // in this usage when we press to the Q Character the cancellationtoken wait the 4 seconds to ends before cancelling
            while (!cts.Token.IsCancellationRequested)
            {
                Console.WriteLine("Checking ...");

                await Task.Delay(4000);

                Console.WriteLine($"Complated on {DateTime.Now}");

                Console.WriteLine();
            }

            Console.WriteLine("\nCheck was Terminated");

            cts.Dispose();
        }

        static async Task DoCheck02(CancellationTokenSource cts)
        {

            // thread running in background there is no neeed to using await
            // if we use an await the thread will wait us to enter Q character.

            Task.Run(() =>
            {
                var input = Console.ReadKey();
                if (input.Key == ConsoleKey.Q)
                {
                    cts.Cancel();
                    Console.WriteLine("Task has been cancelled!!");
                }
            });


            // if cts excuted it will return true other than this it will return false

            /*
                The IsCancellationRequested property of a CancellationToken associated 
                with a CancellationTokenSource will return true if the cancellation has been requested, 
                meaning if Cancel() has been called on the CancellationTokenSource. Otherwise, it will return false. 
            */

            // in this usage the token directly cancelled when we press on the Q ch..
            while (true)
            {
                Console.WriteLine("Checking ...");

                await Task.Delay(4000 ,cts.Token);

                Console.WriteLine($"Complated on {DateTime.Now}");

                Console.WriteLine();
            }

            Console.WriteLine("\nCheck was Terminated");

            cts.Dispose();
        }

        static async Task DoCheck03(CancellationTokenSource cts)
        {

            // thread running in background there is no neeed to using await
            // if we use an await the thread will wait us to enter Q character.

            Task.Run(() =>
            {
                var input = Console.ReadKey();
                if (input.Key == ConsoleKey.Q)
                {
                    cts.Cancel();
                    Console.WriteLine("Task has been cancelled!!");
                }
            });


            // if cts excuted it will return true other than this it will return false

            /*
                The IsCancellationRequested property of a CancellationToken associated 
                with a CancellationTokenSource will return true if the cancellation has been requested, 
                meaning if Cancel() has been called on the CancellationTokenSource. Otherwise, it will return false. 
            */


            try
            {
                while (!cts.Token.IsCancellationRequested)
                {
                    Console.WriteLine("Checking ...");

                    cts.Token.ThrowIfCancellationRequested();

                    await Task.Delay(4000);

                    Console.WriteLine($"Complated on {DateTime.Now}");

                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("\nCheck was Terminated");
                cts.Dispose();
            }

        }
    }
}
