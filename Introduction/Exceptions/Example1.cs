using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*

    Exception
    │
    ├── SystemException
    │   ├── ArgumentException
    │   │   ├── ArgumentNullException
    │   │   └── ArgumentOutOfRangeException
    │   ├── ArithmeticException
    │   │   ├── DivideByZeroException
    │   │   └── OverflowException
    │   ├── ArrayTypeMismatchException
    │   ├── BadImageFormatException
    │   ├── DataMisalignedException
    │   ├── IndexOutOfRangeException
    │   ├── InvalidCastException
    │   ├── InvalidOperationException
    │   ├── NotImplementedException
    │   ├── NotSupportedException
    │   ├── NullReferenceException
    │   ├── OutOfMemoryException
    │   ├── StackOverflowException
    │   └── TypeInitializationException
    │
    ├── ApplicationException
    │   └── CustomApplicationException (Example of a user-defined exception)
    │
    ├── IOException
    │   ├── DirectoryNotFoundException
    │   ├── DriveNotFoundException
    │   ├── EndOfStreamException
    │   ├── FileNotFoundException
    │   ├── PathTooLongException
    │   └── SocketException
    │
    └── WebException
        ├── ProtocolViolationException
        ├── TimeoutException
        └── UnauthorizedAccessException
 
 
*/
namespace Introduction.Exceptions
{
    internal class Example1
    {
        public static void badMethod()
        {
            short x = 10;
            short y = 0;

            // System.DivideByZeroException: 'Attempted to divide by zero.'
            Console.WriteLine(x / y);
        }

        public static void badMethod2()
        {
            short x = 10;
            short y = 0;
            try
            {
                Console.WriteLine(x / y);
            }
            // stackTrace: use to show where the error/exception occured

            // we can add condtion on the exception, in this example catch will not
            // catch the exception because we write "when (e.Source != "Mastring CS")" this condition
            catch (Exception e) when (e.Source != "Mastring CS")
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("end");
            }
        }
        public static void run()
        {
            badMethod2();
        }

    }
}
