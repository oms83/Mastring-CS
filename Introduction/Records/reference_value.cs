using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Records
{
    // reference type (heap)
    public class clsPoint
    {
        public clsPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X {  get; set; }
        public int Y { get; set; }
    }
    // value type (stack)
    public struct stPoint
    {
        public int X;
        public int Y;

        public stPoint(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class reference_value
    {
        public static void run()
        {
            clsPoint point1 = new clsPoint(1, 2);
            clsPoint point2 = new clsPoint(1, 2);

            Console.WriteLine("Class: " + point1.Equals(point2));
            Console.WriteLine("Class: " + Object.ReferenceEquals(point2, point1));

            stPoint point3 = new stPoint(1, 2);
            stPoint point4 = new stPoint(1, 2);

            Console.WriteLine("Sturct: " + point3.Equals(point4));
            Console.WriteLine("Sturct: " + Object.ReferenceEquals(point4, point3));
        }
    }
}
