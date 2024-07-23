using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.XML_Documentation
{
   /// <summary>
   /// The main generate class
   /// </summary>
   /// <remarks>
   /// This class can generate employee Id's and random password
   /// </remarks>
    public class Generator
    {
        /// <value>value of last id sequance</value>
        public static int LastIdSequence { get; private set; } = 1;

        /// <summary>
        /// This method return employee id contains the name, surname, hire data and last id sequence 
        /// Generate employee id processing by <paramref name="FirstName"/>, <paramref name="LastName"/>, <paramref name="HireDate"/>
        /// <list type="bullet">
        /// <item>
        /// <term>II</term>
        /// <description>Employee initials (First lette if <paramref name="FirstName"/>) and (First name of <paramref name="LastName"/>)</description>
        /// </item>
        /// <item>
        /// <term>HD</term>
        /// <description>Employee Hire Data <paramref name="HireDate"/></description>
        /// </item>
        /// <item>BB</item>
        /// <description></description>
        /// <item>
        /// <term>CC</term>
        /// <description>sequence (1,99)</description>
        /// </item>
        /// </list>
        /// <list type="table">
        /// <item>
        /// <term>CC</term>
        /// <description>ds</description>
        /// </item>
        /// <item>
        /// <term>CC</term>
        /// <description>ds</description>
        /// </item>
        /// <item>
        /// <term>CC</term>
        /// <description>ds</description>
        /// <description>ds</description>
        /// </item>
        /// <example>
        /// <code>var id = Generator.GenerateId("Omer", "MEMES", new DateTime(2000, 08,03))</code>
        /// </example>
        /// </list>
        /// <exception cref="System.InvalidOperationException">Thrown when <paramref name="FirstName"/> is null </exception>
        /// <exception cref="System.InvalidOperationException">Thrown when <paramref name="LastName"/> is null </exception>
        /// <exception cref="System.InvalidOperationException">Thrown when <paramref name="HireDate"/> in the past </exception>
        ///
        /// </summary>
        /// <param name="FirstName">employee firstname</param>
        /// <param name="LastName">employee lastname</param>
        /// <param name="HireDate">employee hire date</param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
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
