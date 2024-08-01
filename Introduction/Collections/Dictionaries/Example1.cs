using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Collections.Dictionaries
{
    public class Example1
    {
        public static void run()
        {
            string article = @"Generic collections in C# provide type safety, 
improved performance, and better code readability. 
They are essential for managing collections of 
data efficiently and effectively. Understanding when and how to use each type 
of generic collection can significantly enhance the quality and maintainability of your code.";

            Dictionary<char, List<string>> keyValuePairs = new Dictionary<char, List<string>>();

            foreach (var word in article.Split())
            {
                foreach (var ch in word)
                {
                    if (!keyValuePairs.ContainsKey(ch))
                    {
                        keyValuePairs.Add(ch, new List<string>() { word });
                    }
                    else
                    {
                        keyValuePairs[ch].Add(word);
                    }
                }
            }

            foreach (var keyValue in keyValuePairs)
            {
                Console.WriteLine($"\n\n'{keyValue.Key}'");

                foreach (var word in keyValue.Value)
                {
                    Console.WriteLine($"       '{word}'");
                }
            }
        }
    }
}
