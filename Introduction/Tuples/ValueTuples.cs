using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Tuples
{
    public class clsFacilityDistanceCalculator2
    {
        private static Random rnd = new Random();

        // ValueTupe.Create
        public static ValueTuple<string, string> CalculateFacilityDistanceV1(string facilityName)
        {
            return ValueTuple.Create(facilityName, (rnd.Next() * 10.0).ToString("F2"));
        }

        // using constructor
        public static ValueTuple<string, string> CalculateFacilityDistanceV2(string facilityName)
        {
            return new ValueTuple<string, string>(facilityName, (rnd.Next() * 10.0).ToString("F2"));
        }

        // implicit names
        public static (string, string) CalculateFacilityDistanceV3(string facilityName)
        {
            return ValueTuple.Create(facilityName, (rnd.Next() * 10.0).ToString("F2"));
        }

        // explicit names
        public static (string name, string distance) CalculateFacilityDistanceV4(string facilityName)
        {
            return ValueTuple.Create(facilityName, (rnd.Next() * 10.0).ToString("F2"));
        }
    }
    internal class ValueTuples
    {
        public static void run()
        {
            // value type stored on the stack
            ValueTuple<string, double> t1 = new ValueTuple<string, double>("Hospital", (new Random()).Next() * 10.0);


            // reference type stored on the heap
            Tuple<string, double> t2 = new Tuple<string, double>("Hospital", (new Random()).Next() * 10.0);

            Console.WriteLine(clsFacilityDistanceCalculator2.CalculateFacilityDistanceV1("Hospital"));
            Console.WriteLine(clsFacilityDistanceCalculator2.CalculateFacilityDistanceV2("Hospital"));
            Console.WriteLine(clsFacilityDistanceCalculator2.CalculateFacilityDistanceV3("Hospital"));

            var info = clsFacilityDistanceCalculator2.CalculateFacilityDistanceV4("Hospital");
            Console.WriteLine(info);
            Console.WriteLine(info.name);
            Console.WriteLine(info.distance);

            (string nm, string ds) = info;

            Console.WriteLine(nm);
            Console.WriteLine(ds    );

        }
    }
}
