using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Introduction.Tuples
{
    public class Location
    {
        public Location(string name, double distanceInKM)
        {
            Name = name;
            DistanceInKM = distanceInKM;
        }

        public string Name { get; set; }
        public double DistanceInKM { get; set;}

        public override string ToString()
        {
            // .ToString("F2") tow decimal digit after the coma
            return $"Name: {Name} .......... Distance In KM: {DistanceInKM.ToString("F2")}";
        }

    }

    public class FacilityDistanceCalculator
    {
        private static Random random = new Random();
        public static Location GetFacilityLocationInfoV1(string facilityName)
        {
            return new Location(name: facilityName, distanceInKM: random.NextDouble()*10.0);    
        }

        public static void GetFacilityLocationInfoV2(string facilityName, out string name, out double distance)
        {
            name = facilityName;
            distance = random.NextDouble() * 10.0;
        }

    }

    public class Example
    {
        public static void run()
        {
            var facilityInfo = FacilityDistanceCalculator.GetFacilityLocationInfoV1("Hospital");
            Console.WriteLine(facilityInfo);

            double distance = default;
            string name = default;

            FacilityDistanceCalculator.GetFacilityLocationInfoV2("Hospital", out name, out distance);
            Console.WriteLine($"Name: {name} .......... Distance In KM: {distance.ToString("F2")}");
        }
    }
} 
  