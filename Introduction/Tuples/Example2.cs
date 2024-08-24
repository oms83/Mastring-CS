using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Tuples
{
    public class clsFacilityDistanceCalculator
    {
        private static Random rnd = new Random();
        public static Tuple<string, string> CalculateFacilityDistanceV1(string facilityName)
        {
            return Tuple.Create(facilityName, (rnd.Next() * 10.0).ToString("F2"));
        }
        public static Tuple<string, string> CalculateFacilityDistanceV2(string facilityName)
        {
            return new Tuple<string, string>(facilityName, (rnd.Next() * 10.0).ToString("F2"));
        }
    }

    internal class Example2
    {
        public static void run()
        {
            var facilityInfo = clsFacilityDistanceCalculator.CalculateFacilityDistanceV2("Hospital");
            Console.WriteLine(facilityInfo);
        }
    }
}
