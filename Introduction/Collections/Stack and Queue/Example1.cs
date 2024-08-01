using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Collections.Stack_and_Queue
{
    /*
     
        Stack & Queue

        - Discard after processing التخلص بعد المعاالجة
        - Fast remove and retrieval اضافة وازلة سريعة
        - Sequential access  الوصول المتسلسل
        - Order of access الوصول بالترتيب
        - Contiguous memory ذاكرة متقاربة
     
     */

    public class Command
    {
        private readonly DateTime _createdAt = DateTime.Now;
        private readonly string _url;

        public Command(string url)
        {
            _createdAt = DateTime.Now;
            _url = url;
        }

        public override string ToString()
        {
            return $"[{this._createdAt.ToString("yyyy-MM-dd hh:mm")}] {this._url}";
        }
    }

    internal class Example1
    {
        public static void Print(string name, Stack<Command> commands)
        {
            Console.WriteLine($"{name} history");
            Console.BackgroundColor = name == "back" ? ConsoleColor.DarkYellow : ConsoleColor.DarkBlue;
            foreach (var command in commands)
            {
                Console.WriteLine($"\t{command}");
            }

            Console.BackgroundColor= ConsoleColor.Black;
        }

        public static void run()
        {
            Stack<Command> redo = new Stack<Command>();
            Stack<Command> undo = new Stack<Command>();

            string line;

            while (true)
            {
                Console.Write("Url ('exit' to quit): ");
                line = Console.ReadLine();

                if (line == "exit")
                {
                    break;
                }
                else if (line == "back")
                {
                    if (undo.Count > 0)
                    {
                        var item = undo.Pop();
                        redo.Push(item);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (line == "forward")
                {
                    if (redo.Count > 0)
                    {
                        var item = redo.Pop();
                        undo.Push(item);
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    undo.Push(new Command(line));
                }

                Console.Clear();
                Print("back", undo);
                Print("forward", redo);
            }

        }
    }
}
