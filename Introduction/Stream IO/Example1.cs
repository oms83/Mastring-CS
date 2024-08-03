using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Stream_IO
{
    public class CurrencyService : IDisposable
    {
        private readonly HttpClient _httpClient;
        private bool _disposed = false;
        public CurrencyService()
        {
            _httpClient = new HttpClient();
        }

        // diposing: true (dispose managed + unmanaged)
        // diposing: false (dispose managed + large fields)
        public virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                _httpClient.Dispose();
            }

            _disposed = true;
        }

        public void Dispose()
        {
            this.Dispose(true);
        }

        public string GetCurrencies()
        {
            string url = "https://coinbase.com/api/v2/currencies";
            var data = _httpClient.GetStringAsync(url).Result;
            return data;
        }
        ~CurrencyService()
        {
            Dispose(false);
            GC.SuppressFinalize(this); // suppress finalize كبح
        }
    }

    public class Example1
    {
        public static void run()
        {
            // 1 not recommeded
            //CurrencyService service = new CurrencyService();
            //string currencies = service.GetCurrencies();
            //service.Dispose();
            //Console.WriteLine(currencies);

            // 2 recommended
            //CurrencyService service = null;
            //try
            //{
            //    service = new CurrencyService();
            //    string currencies = service.GetCurrencies();
            //    Console.WriteLine(currencies);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("error");
            //}
            //finally
            //{
            //    service?.Dispose();
            //}


            // using already implementation of try catch
            // 3 more recommended
            using (CurrencyService service = new CurrencyService())
            {
                string currencies = service.GetCurrencies();
                Console.WriteLine(currencies);
            }
        }
    }
}
