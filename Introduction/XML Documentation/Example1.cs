using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.XML_Documentation
{

    /// <include file='Generator.xml' path='doc/members[@name="Generator"]/generator/*'/>
    public class Generator
    {

        /// <include file='Generator.xml' path='doc/members[@name="Generator"]/field/*'/>   
        public static int LastIdSequence { get; private set; } = 1;


        /// <include file='Generator.xml' path='doc/members[@name="Generator"]/generate/*'/>   
        public static string GenerateId(string FirstName, string LastName, DateTime? HireDate)
        {
            if (FirstName is null)
            {
                throw new InvalidOperationException($"{nameof(FirstName)} can not be null");
            }

            if (LastName is null)
            {
                throw new InvalidOperationException($"{nameof(LastName)} can not be null");
            }

            if (HireDate is null)
            {
                HireDate = DateTime.Now;
            }
            else
            {
                if (HireDate.Value.Date < DateTime.Now.Date)
                {
                    throw new InvalidOperationException($"{nameof(HireDate)} can not be in the past");
                }

            }
            
            var yy = HireDate.Value.ToString("yy");
            var mm = HireDate.Value.ToString("MM");
            var dd = HireDate.Value.ToString("dd");

            var code = $"{{\n   {FirstName.ToUpper()[0]}{LastName.ToUpper()[0]}\n   {yy}\n   {mm}\n   {dd}\n   {(LastIdSequence++).ToString().PadLeft(2, '0')}\n}}";

            return code;
        }
        /// TODO
        /// <include file='Generator.xml' path='doc/members[@name="Generator"]/generate/*'/>   
        public static string GeneratePassword()
        {
            string characters = "1234567890abcdefghicklmnopqrstuvwxyzABCDEFGHIGKLMNOPQRSTUVWXYZ/+-*#";
            Random rnd = new Random();
            string password = string.Empty;

            for (int i = 1; i < 8; i++)
            {
                //password += characters[rnd.Next(0, 66)];
                password += characters[rnd.Next(characters.Length)];
            }

            return password;
        }

    }

    internal class Example1
    {
        public static void run()
        {
            Console.WriteLine($"{Generator.GenerateId("Omer", "MEMES", new DateTime(year: 2025, month: 08, day: 25))}");
            Console.WriteLine($"{Generator.GeneratePassword()}");
        }
    }
}
