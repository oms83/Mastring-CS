using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Stream_IO
{
    public class Example3
    {
        // get file information
        public static void run1()
        {
            string path = @"C:\\Users\\omerm\\Desktop\\Mastring CS\\Mastring CS\\Introduction\\Stream IO\\Text.txt";

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
            {
                Console.WriteLine($"Length: {fs.Length}");
                Console.WriteLine($"CanRead: {fs.CanRead}");
                Console.WriteLine($"CanWrite: {fs.CanWrite}");
                Console.WriteLine($"CanSeek: {fs.CanSeek}");
                Console.WriteLine($"CanTimeout: {fs.CanTimeout}");
                Console.WriteLine($"Position: {fs.Position}");
                fs.WriteByte(65);
                Console.WriteLine($"Position: {fs.Position}");

            }

		}
        // read from file
		public static void run2()
		{
			string path = @"C:\\Users\\omerm\\Desktop\\Mastring CS\\Mastring CS\\Introduction\\Stream IO\\Text.txt";

			using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
			{
				byte[]data = new byte[fs.Length];
                int numBytesToRead = (int)fs.Length;
                int numBytesRead = 0;

                while (numBytesToRead > 0)
                {
                    int n = fs.Read(data, numBytesRead, numBytesToRead);

                    if (n == 0)
                    {
                        break;
                    }

                    numBytesRead += n;
                    numBytesToRead -= n;
                }
                Console.WriteLine($"{numBytesToRead},  {numBytesRead}");
            }

		}
        // read and write to file
        public static void run3()
        {
            string path = @"C:\\Users\\omerm\\Desktop\\Mastring CS\\Mastring CS\\Introduction\\Stream IO\\Text.txt";

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
            {
                byte[] data = new byte[fs.Length];
                int numBytesToRead = (int)fs.Length;
                int numBytesRead = 0;

                while (numBytesToRead > 0)
                {
                    int n = fs.Read(data, numBytesRead, numBytesToRead);

                    if (n == 0)
                    {
                        break;
                    }

                    numBytesRead += n;
                    numBytesToRead -= n;
                }
                Console.WriteLine($"{numBytesToRead},  {numBytesRead}");

                var NewPath = @"C:\\Users\\omerm\\Desktop\\Mastring CS\\Mastring CS\\Introduction\\Stream IO\\Text2.txt";
                using (FileStream sw = new FileStream(NewPath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    sw.Write(data, 0, data.Length);
                }
            }
        }
        public static void run4()
        {
            string path = @"C:\\Users\\omerm\\Desktop\\Mastring CS\\Mastring CS\\Introduction\\Stream IO\\Text3.txt";

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                fs.Seek(20, SeekOrigin.Begin);
                fs.WriteByte(65);
                fs.Position = 0;

                for (int i = 0; i < fs.Length; i++)
                {
                    Console.WriteLine(fs.ReadByte());
                }
            }
        }
        public static void run5()
        {
            string path = @"C:\\Users\\omerm\\Desktop\\Mastring CS\\Mastring CS\\Introduction\\Stream IO\\Text4.txt";

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("this");
                sw.WriteLine("is");
                sw.WriteLine("C#");
            }
        }
        public static void run6()
        {
            string path = @"C:\\Users\\omerm\\Desktop\\Mastring CS\\Mastring CS\\Introduction\\Stream IO\\Text4.txt";

            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.Peek() > 0)
                {
                    Console.Write((char)sr.Read());
                }
            }
        }

        public static void run7()
        {
            string path = @"C:\\Users\\omerm\\Desktop\\Mastring CS\\Mastring CS\\Introduction\\Stream IO\\Text4.txt";

            using (StreamReader sr = new StreamReader(path))
            {
                string line = string.Empty;
                while ((line = sr.ReadLine()) != null) 
                {
                    Console.WriteLine(line);
                }
            }
        }
        // file facade operation
        public static void run8()
        {
            string path = @"C:\\Users\\omerm\\Desktop\\Mastring CS\\Mastring CS\\Introduction\\Stream IO\\Text5.txt";

            string[] line =
            {
                "C#",
                "Is",
                "Amazing",
                "Language"
            };

            // بدون الدخول بكافة التفاصيل السابقة
            File.WriteAllLines(path, line);

        }
        // file facade operation
        public static void run9()
        {
            string path = @"C:\\Users\\omerm\\Desktop\\Mastring CS\\Mastring CS\\Introduction\\Stream IO\\Text5.txt";

            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

        public static void run10()
        {
            string path = @"C:\\Users\\omerm\\Desktop\\Mastring CS\\Mastring CS\\Introduction\\Stream IO\\Text6.txt";

            string text = "c# is amazing language";
            File.WriteAllText(path, text);
        }
        public static void run11()
        {
            string path = @"C:\\Users\\omerm\\Desktop\\Mastring CS\\Mastring CS\\Introduction\\Stream IO\\Text6.txt";

            Console.WriteLine(File.ReadAllText(path));
        }

        public static void run()
        {
            using (var binFile = File.Create("data.bin"))
            {
                using (var ds = new DeflateStream(binFile, CompressionMode.Compress))
                {
                    ds.WriteByte(65);
                    ds.WriteByte(66);
                }
            }

            using (var binFile = File.OpenRead("data.bin"))
            {
                using (var ds = new DeflateStream(binFile, CompressionMode.Decompress))
                {
                    for (int i = 0; i < binFile.Length; i++)
                    {
                        Console.WriteLine((char)ds.ReadByte());
                    }
                }
            }
        }
    }
}
