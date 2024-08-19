using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Strings
{
    public class StringLiteral_StringObject
    {
        public static void run()
        {
            //RunStringLiteralVsObject();

            //RunStringLiteralKey();

            RunStringIntern();
        }

        private static void RunStringLiteralVsObject()
        {
            string str1 = "omer memes"; // string literal

            char[] charArray = { 'o', 'm', 'e', 'r', ' ', 'm', 'e', 'm', 'e', 's' };
            string str2 = new string(charArray); // string object

            Console.WriteLine(str2 == str1); // true
            Console.WriteLine(str1.Equals(str2)); // true

            Console.WriteLine((Object)str1 == (Object)str2);  // false
            Console.WriteLine(ReferenceEquals(str2, str1)); // false
        }
        private static void RunStringLiteralKey()
        {
            string str1 = "omer memes"; // string literal

            string str2 = "omer" + " memes"; // literal object

            Console.WriteLine(str2 == str1);  // true
            Console.WriteLine(str1.Equals(str2)); // true

            Console.WriteLine((Object)str1 == (Object)str2); // true
            Console.WriteLine(ReferenceEquals(str2, str1)); // true
        }

        // retun the reference of string value from string pool 
        private static void RunStringIntern()
        {
            string str1 = "omer";
            string str2 = new string(new[] { 'o', 'm', 'e', 'r' });

            Console.WriteLine(str2 == str1); // true
            Console.WriteLine(str1.Equals(str2)); // true

            Console.WriteLine((Object)str1 == (Object)str2);  // false
            Console.WriteLine(ReferenceEquals(str2, str1)); // false

            string referenceToStr1 = string.Intern(str1);
            string referenceToStr2 = string.Intern(str2);

            Console.WriteLine(referenceToStr1);

            Console.WriteLine(referenceToStr2);

        }

    }

}
