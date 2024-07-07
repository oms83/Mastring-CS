using System;

namespace Introduction.OOP.Events
{
    public delegate void StockPriceChangeHandler(Stock stock, decimal oldPrice);
    public class Stock
    {
        public event StockPriceChangeHandler OnStockChnaged;
        private string _name;

        public string Name => _name;

        private decimal _price;
        public decimal Price { get => _price; set { _price = value; } }

        public Stock(string name)
        {
            this._name = name;
        }

        public void StockPriceChange(decimal Percent)
        {
            decimal oldPrice = this._price;

            this._price += Math.Round(Percent * this._price, 2);

            if (OnStockChnaged != null)
            {
                OnStockChnaged(this, oldPrice);
            }
        }
    }

    public class clsEvents
    {
        private static void HandleStockPriceChange(Stock stock, decimal oldPrice)
        {
            if (stock.Price > oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (stock.Price < oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            Console.WriteLine($"{stock.Name}: {stock.Price:C}");
        }
        public static void run()
        {
            Stock _stock = new Stock("Gold");

            _stock.Price = 100m;
            Console.WriteLine($"{_stock.Name}: {_stock.Price:C}");


            //stock.OnStockChnaged += HandleStockPriceChange;
            _stock.OnStockChnaged += (Stock stock, decimal oldPrice) =>
            {
                if (stock.Price > oldPrice)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (stock.Price < oldPrice)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                Console.WriteLine($"{stock.Name}: {stock.Price:C}"); 
            };

            _stock.StockPriceChange(0.05m);
            _stock.StockPriceChange(-0.03m);
            _stock.StockPriceChange(0.07m);
            _stock.StockPriceChange(0m);
        }

    }
}
