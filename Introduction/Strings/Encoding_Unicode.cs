using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Strings
{
    public class Encoding_Unicode
    {
        public static void run()
        {
            // using quoted string letters
            string str1 = "message";
            Console.WriteLine(str1);

            // using string constructor
            char[] chs = { 'm', 'e', 's', 's', 'a', 'g', 'e' };
            string str2 = new string(chs);
            Console.WriteLine(str2);


            // repeating characters
            string str3 = new string('m', 2);
            Console.WriteLine(str3);


            // using pointer to character
            char[] letters = { 'a', 'b', 'c', 'd' };
            string str4 = null;
            unsafe
            {
                fixed (char* p = letters)
                {
                    str4 = new string(p);
                    Console.WriteLine(str4);
                }
            }

            // using concatenation
            string name = "Omer";
            string surname = "MEMES";

            string str5 = name + " " + surname;
            Console.WriteLine(str5);

            // string interpolation
            string str6 = $"{name} {surname}";
            Console.WriteLine(str6);

            string customer = "Omer MEMES";
            DateTime shippingDate = DateTime.Now;
            DateTime expectedDate = shippingDate.AddDays(7);
            decimal shippingCost = 32.43m;

            // using formatted 
            string str7 = string.Format(
                "\nDear {0}" +
                "\nAt {1:t} on {1:D}, the order is on its way to you" +
                "\nIt's excepted to be delivered at {2:t} on {2:D}, the order is on its way to you" +
                "\nShipping cost {3:c}." +
                "\n\t\t\tThanks for shopping with us!",
                customer, shippingDate, expectedDate, shippingCost
                );

            Console.WriteLine(str7);


            // using verbatim with string interpolation 
            string str8 = string.Format(
$@"Dear {customer}
At {shippingDate:t} on {shippingDate:D}, the order is on its way to you
It's excepted to be delivered at {expectedDate:t} on {expectedDate:D}, the order is on its way to you
Shipping cost {shippingCost:c}.
Thanks for shopping with us!",
                customer, shippingDate, expectedDate, shippingCost
                );
            Console.WriteLine(str8);

            // using row string c# 11
            //string str9 = """
            //             <nav class="navigation">
            //                  <ul>
            //                      Navigation
            //                      <li>link1</li>
            //                      <li>link 2</li>
            //                      <li>link 3</li>
            //                      <li>link 4</li>
            //                      <li>link 6</li>
            //                  </ul>
            //              </nav>
            //              """;


        }

        public static async Task run1()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string filePath = $"{path}\\utf8NewsContent.txt";

            using (HttpClient client = new HttpClient())
            {
                Uri uri = new Uri("https://www.aljazeera.net/news/");

                using (HttpResponseMessage response = new HttpResponseMessage())
                {
                    var byteArray = await client.GetByteArrayAsync(uri);
                    string result = Encoding.UTF8.GetString(byteArray);
                    //string result = Encoding.ASCII.GetString(byteArray);
                    File.WriteAllText(filePath, result);
                }

            }
        }
    }
}
