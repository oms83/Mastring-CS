using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.String_Builder
{
    internal class Example2
    {
        public static void run()
        {
            //RunStringBuilderProperties(); 
            //RunStringBuilder();
            RunStringBuilder01();
            /*
                append
                appendline
                appendformat
                insert
                replace 
                remove
                clear
                getchuncks
                insurecapacity
                copyto
                
            */
            
        }
        static void RunArrayOfCharacterConcept()
        {
            // mutable
            char[] characters = new char[4];
            characters[0] = 'o';
            characters[0] = 'm';
            characters[0] = 'e'; // mutate
            characters[0] = 'r';

            char[] characters2 = new char[4] { 'o', 'm', 'e', 'r'}; 


            char[] characters3 = new char[] { 'o', 'm', 'e', 'r'}; 
        }
        static void RunStringBuilderProperties()
        {
            StringBuilder name = new StringBuilder("omer");

            Console.WriteLine(name.Length);
            Console.WriteLine(name.Capacity);//16 default
            Console.WriteLine(name.Append(" memes")); 
            Console.WriteLine(name.MaxCapacity); // 2 147 483 647
            Console.WriteLine(name[0]); // indexer
        }

        static void RunStringBuilder()
        {
            StringBuilder name = new StringBuilder();

            name.Append("omer");
            Console.WriteLine(name.Length); // 4
            Console.WriteLine(name.Capacity); // 16 
            Console.WriteLine(name.MaxCapacity); // 2 147 483 647

            name.Append("ahmed omer memes ");
            Console.WriteLine(name.Length); // 21
            Console.WriteLine(name.Capacity); // 32
            Console.WriteLine(name.MaxCapacity); // 2 147 483 647

        }

        static void RunStringBuilder01()
        {
            var sb1 = new StringBuilder("omer");

            var sb2 = new StringBuilder(4);
            sb2.Append("omer");

            var sb3 = new StringBuilder();
            sb3.AppendLine("omer");

            // if capacity less than zero => ArgumentOutOfRangeExceotion
            // additional allocation if the number of chars stored exceed capacity
            var sb4 = new StringBuilder("omer", 3);



            // StringBuilder (int capacity, int maxCapacity);
            // if capacity less than zero => ArgumentOutOfRangeException
            // if maxcapacity less than one => ArgumentOutOfRangeException
            // if capacity is zero implementation default capacity is used
            // if capacity exeeds max capacity ArgumentOutOfRangeException
            var sb5 = new StringBuilder(0, 9);



            // StringBuilder (string? value, int startIndex, int length, int capacity);
            // If capacity is zero, the implementation-specific default capacity
            // if capacity less than zero => ArgumentOutOfRangeException
            // additional allocation if the number of chars stored exceed capacity
            // startIndex+length is not a position within value.=> ArgumentOutOfRangeException
            var sb6 = new StringBuilder("omer ahmed memes", 11, 5, 5);
            Console.WriteLine(sb6);

        }


    }
}
