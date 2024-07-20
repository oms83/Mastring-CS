using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Enumerators
{
    public class FiveIntegers : IEnumerable
    {
        public int[] values;
        public FiveIntegers(int n1, int n2, int n3, int n4, int n5)
        {
            values = new int[] { n1, n2, n3, n4, n5 };
        }

        public IEnumerator GetEnumerator() => new Enumerator(this);

        private class Enumerator : IEnumerator
        {
            private int _currentIndex = -1;
            private FiveIntegers _integers;

            public Enumerator(FiveIntegers integers)
            {
                _integers = integers;
            }
            public object Current
            {
                get
                {
                    if (_currentIndex == -1)
                        throw new InvalidOperationException("Enumeration not started!");
                    
                    if (_currentIndex >= _integers.values.Length)
                        throw new InvalidOperationException("Enumeration is ended");

                    return _integers.values[_currentIndex];
                }
            }

            public bool MoveNext()
            {
                if (_integers.values.Length - 1 <= _currentIndex) 
                {
                    return false;
                }

                return ++_currentIndex < _integers.values.Length;

            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }

    internal class Enumerator_IEnumerable
    {
        public static void run()
        {
            FiveIntegers ints = new FiveIntegers(1, 2, 3, 4, 5);

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }

        }
    }
}
