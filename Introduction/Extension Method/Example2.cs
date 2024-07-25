using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Extension_Method
{
    public class Pizza
    {
        public string Content { get; set; }
        public decimal TotalPrice { get; set; }

        public Pizza AddSauce()
        {
            this.Content = $"Tomato sauce X $5.00";
            this.TotalPrice += 5;
            return this;
        }
        public override string ToString()
        {
            return $"{Content}\n-----------------------\n{TotalPrice.ToString("#.##")}\n";
        }
    }
    public static class PizzaExtension
    {
        public static Pizza AddDough(this Pizza value, string type)
        {
            value.Content += $"{type} Dough X $4.00\n";
            value.TotalPrice += 4m;
            return value;
        }
        public static Pizza AddSauce(this Pizza value)
        {
            value.Content += $"Tomato sauce X $2.00\n";
            value.TotalPrice += 2m;
            return value;
        }
        public static Pizza AddCheeze(this Pizza value, bool extra)
        {
            value.Content += $"{(extra ? "extra" : "regular")}  X ${(extra ? "$6.00" : "$4.00" )}\n";
            value.TotalPrice += extra ? 6m : 4m;
            return value;
        }
        public static Pizza AddToppings(this Pizza value, string type, decimal price)
        {
            value.Content += $"{type} X ${price.ToString("#.##")}\n";
            value.TotalPrice += price;
            return value;
        }
    }

    internal class Example2
    {
        public static void run()
        {
            Pizza pizza = new Pizza();

            //pizza = PizzaExtension.AddDough(PizzaExtension.AddSauce(PizzaExtension.AddCheeze(PizzaExtension.AddToppings(pizza, "black olives", 3.5m), true)), "thin");

            pizza.AddDough("thin")
                .AddSauce()
                .AddCheeze(true)
                .AddToppings("black olives", 3.5m);
            /*
                اقرب مثال لاستخدام الاكستنشن مثود هو مع الديت الفانكشنس اللي موفرتها مكروسوفت ممكن نضيف عليها 
            كستوم فانكشنس 

            لما بكون عندي اكستنشن مثود وانستنس مثود, الانستنس مثود على اللي بتشتغل
             */
            Console.WriteLine(pizza.ToString());
        }
    }
}
