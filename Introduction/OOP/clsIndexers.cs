using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.OOP
{
    public class clsIP
    {
        private int[] segments = new int[4];

        public string Address
        {
            get => string.Join(".", segments);
        }

        // indexer
        public int this[int index]
        {
            get => segments[index];
            set => segments[index] = value;
        }
        public clsIP(int segment1, int segment2, int segment3, int segment4)
        {
            segments[0] = segment1;
            segments[1] = segment2;
            segments[2] = segment3;
            segments[3] = segment4;
        }

        public clsIP(string address)
        {
            var segs = address.Split('.');
            
            for (int i = 0; i < segs.Length; i++)
            {
                segments[i] = Convert.ToInt32(segs[i]);
            }
        }
    }

    public class clsSuduko
    {
        private int[,] _matrix = new int[9, 9];
        public int this[int row, int col]
        {
            get
            {
                if (row < 0 || col < 0)
                {
                    return -1;
                }
                else
                {
                    return _matrix[row, col];
                }
            }
            set
            {
                if (!(row < 0 || col < 0) && !(row > _matrix.GetLength(0) - 1 || col > _matrix.GetLength(0) - 1)) 
                {
                    _matrix[row, col] = value;      
                }
                
            }
        }

        public clsSuduko(int[,]matrix)
        {
            _matrix = matrix;
        }
    }

    public class clsIndexers
    {
        public static void run()
        {
            clsIP ip = new clsIP(198, 120, 66, 10);

            Console.WriteLine(ip.Address);

            // indexer
            Console.WriteLine(ip[0]);
            Console.WriteLine(ip[1]);
            Console.WriteLine(ip[2]);


            clsIP ip2 = new clsIP("198.122.66.10");
            Console.WriteLine(ip2.Address);

            Console.WriteLine("\n\n-------------------------------------------------------\n\n");
            
            int[,] matrix = new int[,]
            {
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }
            };

            clsSuduko suduko = new clsSuduko(matrix);
            Console.WriteLine(suduko[1,1]);
            suduko[1, 1] = 19;
            Console.WriteLine(suduko[1,1]);
        }

    }
}
