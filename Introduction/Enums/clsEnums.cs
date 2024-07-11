using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Enums
{
    public class clsEnums
    {
        public enum enMonths : short 
        {
            JAN = 1,
            FEB = 2,
            MAR,
            APR,
            MAY, 
            JUN,
            JUL,
            AUG,
            SEP,
            OCT,
            NOV,
            DEC
        }

        [Flags]
        public enum enFlag
        {
            NONE        = 0b_0000_0000, // 0
            MONDAY      = 0b_0000_0001, // 1
            TUESDAY     = 0b_0000_0010, // 2
            WEDNESDAY   = 0b_0000_0100, // 4
            THURSDAY    = 0b_0000_1000, // 8
            FRIDAY      = 0b_0001_0000, // 16
            SATURDAY    = 0b_0010_0000, // 32
            SUNDAY      = 0b_0100_0000, //  64

            WEEK_END = SUNDAY | SATURDAY, 
            BUSINESS_DAYS = MONDAY | TUESDAY | FRIDAY | WEDNESDAY | THURSDAY,
        }

        public static void run1()
        {
            var day1 = enFlag.WEEK_END;
            var day2 = (enFlag.SUNDAY | enFlag.SATURDAY);

            if (day2.HasFlag(enFlag.WEEK_END))
            {
                Console.WriteLine("enjoy your weekend");
            }
        }

        
        public static void run2()
        {
            var day = "FEB";

            Console.WriteLine(Enum.Parse(typeof(enMonths), day));

            if (Enum.TryParse(day, out enMonths month))
            {
                Console.WriteLine("valid month");
            }
            else
            {
                Console.WriteLine("invalid");
            }
            day = "feb";
            if (Enum.IsDefined(typeof(enMonths), day))
            {
                Console.WriteLine(Enum.Parse(typeof(enMonths), day));

                Console.WriteLine("valid month");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }

        public static void run()
        {
            foreach (var month in Enum.GetNames(typeof(enMonths)))
            {
                Console.WriteLine($"{month} : {(short)Enum.Parse(typeof(enMonths), month)}");
            }
            /*
             JAN
             FEB
             MAR
             APR
             MAY
             JUN
             JUL
             AUG
             SEP
             OCT
             NOV
             DEC
                JAN : 1
                FEB : 2
                MAR : 3
                APR : 4
                MAY : 5
                JUN : 6
                JUL : 7
                AUG : 8
                SEP : 9
                OCT : 10
                NOV : 11
                DEC : 12
            */
        }


    }
}
