using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Extension_Method
{
    public static class DateTimeHelper
    {
        public static bool IsWeekEnd(DateTime value)
        {
            return value.DayOfWeek == DayOfWeek.Sunday || value.DayOfWeek == DayOfWeek.Saturday;
        }

        public static bool IsWeekDay(DateTime value)
        {
            return !IsWeekEnd(value);
        }
    }
    public static class clsDateTimHelper
    {
        public static bool IsWeekEnd(this DateTime value)
        {
            return value.DayOfWeek == DayOfWeek.Sunday || value.DayOfWeek == DayOfWeek.Saturday;
        }

        public static bool IsWeekDay(this DateTime value)
        {
            return !IsWeekEnd(value);
        }
    }
    internal class Example1
    {
        public static void run()
        {
            DateTime DT = DateTime.Now;
            Console.WriteLine($"date : {DT}");

            DateTime DT2 = new DateTime(2024, 02, 13);
            Console.WriteLine(DT2);

            DateTimeOffset DT3 = DateTimeOffset.Now;

            Console.WriteLine(DT3);

            DateTimeOffset dt4 = DateTimeOffset.UtcNow;
            Console.WriteLine(dt4);

            // time span فترة ومنية
            TimeSpan ts = new TimeSpan(2, 15, 0);
            DT = DT.Add(ts);
            Console.WriteLine($"date : {DT}");
            DT = DT.AddDays(10);
            Console.WriteLine($"date : {DT}");

            DateTime dt = new DateTime(2024, 07, 26);
            Console.WriteLine($"is week end: {DateTimeHelper.IsWeekEnd(dt)}");
            Console.WriteLine($"is week day: {DateTimeHelper.IsWeekDay(dt)}");

            Console.WriteLine($"is week end: {dt.IsWeekEnd()}");
            Console.WriteLine($"is week day: {dt.IsWeekDay()}");

            /*
                Extension Methods
                should be in a static class 
                    and should be a static method 
                        and should includ this key word befor data type of parameter
             */

        }
    }
}
