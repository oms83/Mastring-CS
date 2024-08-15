using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Records
{
    public class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point()
        {
            
        }
        //public int X { get; init; } allow in .NET 7.3 we can set to field in initialize case
        public int X { get; }
        public int Y { get; }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
    public class init_readonly
    {
        public static void run()
        {
            //Point point = new Point { X = 0, Y = 0 }; cannot be assigned it is readonly
            Point point = new Point(1, 2);

        }

    }
}
