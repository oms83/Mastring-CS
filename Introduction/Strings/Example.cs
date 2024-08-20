using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Strings
{
    internal class Example
    {
        public static void run()
        {
            //CopyToMethod();
            //CompareMethod();
            //StringFoundMethod();
            //StringFormatMethod();
            //StringModifyMethod();
            //ToCaseMethod();
            //TremMethod();
            //ToCharacterArrayMethod();
            //SplitMethod();
            JoinMethod();
        }

        static void CopyToMethod()
        {
            string str1 = "omer";
            char[] chs = { 'm', 'e', 'm', 'e', 's', ' ', '?', '?', '?', '?'};
            // من اي اندكس رح يتم النسخ
            // على شو رح يتم النسخ
            // array من وين رح يتم البدء بالنسخ على ال
            // عدد الاحرف اللي بدو يتم نسخها
            Console.WriteLine(chs);

            str1.CopyTo(0, chs, 6, str1.Length);

            Console.WriteLine(chs);
        }

        static void CompareMethod()
        {
            string s1 = "omer";
            string s2 = "Omer";

            // asci sort order (integer, capital, small)
            // a12Bv => 12Bav


            // لا تدقق على الاحرف الكبيرة والصغيرة
            Console.WriteLine(string.Compare(s1, s2, true));  // 0

            // دقق على الاحرف الكبيرة والصغير
            Console.WriteLine(string.Compare(s1, s2, false)); //  -1

            // دقق على الاحرف الكبيرة والصغير
            Console.WriteLine(string.Compare(s2, s1, false)); // 1

        }

        static void StringFoundMethod()
        {
            string str = "omer memes";

            Console.WriteLine(str.StartsWith("om")); // true

            Console.WriteLine(str.Contains("meme")); // true

            Console.WriteLine(str.EndsWith("r"));  // false

            Console.WriteLine(str.IndexOf("me")); // 1

            Console.WriteLine(str.IndexOf("ali"));  // -1

        }

        static void StringFormatMethod()
        {
            List<dynamic> users = new List<dynamic>()
            {
                new {UserName = "user1", Since = new DateTime(2023, 9, 2), Followers = 1221 },
                new {UserName = "user2", Since = new DateTime(2021, 1, 21), Followers = 400 },
                new {UserName = "user3", Since = new DateTime(2024, 1, 2), Followers = 5000 },
            };

            var header = String.Format("{0,-12}{1,8}{2,12}\n", "Username", "CreatedAt", "Followers");
            Console.WriteLine(header);
            foreach (dynamic user in users)
            {
                Console.WriteLine(string.Format("{0,-12}{1,8:yyyy}{2,12:N0}", user.UserName, user.Since, user.Followers));
            }
            /*
                Username CreatedAt   Followers

                user1           2023       1,221
                user2           2021         400
                user3           2024       5,000
            */
        }

        static void StringIsNullOrEmptyMethod()
        {
            string s1 = null;
            string s2 = string.Empty;
            string s3 = "";
            string s4 = " ";
            string s5 = "omer";

            Console.WriteLine(s1); // true
            Console.WriteLine(s2); // true
            Console.WriteLine(s3); // true
            Console.WriteLine(s4); // false
            Console.WriteLine(s5); // false
        }

        static void StringIsNullOrWhiteSpaceMethod()
        {
            string s1 = null;
            string s2 = string.Empty;
            string s3 = "";
            string s4 = " ";
            string s5 = "omer";

            Console.WriteLine(s1); // false
            Console.WriteLine(s2); // false
            Console.WriteLine(s3); // false
            Console.WriteLine(s4); // true
            Console.WriteLine(s5); // false
        }

        static void StringModifyMethod()
        {
            string name = "omer MEMES";

            name = name.Insert(5, "ahmed ");

            Console.WriteLine(name); // omer ahmed MEMES

            
            name = name.Replace("MEMES", "memes");
            
            Console.WriteLine(name); // omer ahmed memes


            name = name.Remove(10, 6);
            
            Console.WriteLine(name); // omer ahmed

        }

        static void ToCaseMethod()
        {
            string name = "omer memes";

            Console.WriteLine(name.ToUpper()); // OMER MEMES

            Console.WriteLine(name.ToLower()); // omer memes

            name = "ömer memes";
            // ما بتعنيني ثقافة اللغة
            Console.WriteLine(name.ToUpperInvariant()); // ömer memes
            Console.WriteLine(name.ToUpper());
        }

        static void TremMethod()
        {
            string name = "    omer    ";
            string name2 = "---------omer----------";
            Console.WriteLine(name.Trim(' ')); // omer 
            Console.WriteLine(name2.TrimEnd('-')); // ---------omer
            Console.WriteLine(name2.TrimStart('-')); // omer----------
            Console.WriteLine(name2.TrimStart()); // ---------omer----------
            Console.WriteLine(name.TrimStart()); // omer
        }

        static void ToCharacterArrayMethod()
        {
            string name = "omer memes";
            char[] chars;
            chars = name.ToCharArray();
            Console.WriteLine(chars);
        }

        static void SplitMethod()
        {
            string name = "omer memes";

            string[]words = name.Split(' ');

            foreach (string word in words)
            {
                Console.WriteLine(word);
                //omer
                //memes
            }
        }

        static void JoinMethod()
        {
            string[] name = { "omer", "ahmed", "memes" };

            Console.WriteLine(string.Join(",", name)); // omer,ahmed,memes
        }
    }
}
