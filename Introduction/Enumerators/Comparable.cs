using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Enumerators
{
    public class Temperature : IComparable
    {
        private int _value;
        public int Value
        {
            set { _value = value; }
            get { return _value; }
        }

        public Temperature(int value)
        {
            this._value = value;
        }

        int IComparable.CompareTo(object obj)
        {
            if (obj is null)
            {
                return 1;
            }

            var temp = obj as Temperature;

            if (temp is null)
            {
                throw new ArgumentException("objcet is not a temperature object");
            }

            return temp._value.CompareTo(this.Value); // asc
            //return this._value.CompareTo(temp.Value); // desc


        }
    }

    internal class Comparable
    {
        private static void FillListWithTemps(List<Temperature> lst)
        {
            Random rnd = new Random();
            for (int i = 0; i < 101; i++)
            {
                lst.Add(new Temperature(rnd.Next(-30, 50)));
            }
        }

        private static void SortList(List<Temperature> lst)
        {
            lst.Sort();

            foreach (var item in lst)
            {
                Console.Write($", {item.Value}");
            }
        }
        public static void run()
        {
            List<Temperature> lst = new List<Temperature>();

            FillListWithTemps(lst);
            SortList(lst);
        }
    }
}
