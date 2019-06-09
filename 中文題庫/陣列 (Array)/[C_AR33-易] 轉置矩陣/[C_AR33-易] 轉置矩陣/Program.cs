using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR33_易__轉置矩陣
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ip = Console.ReadLine().Split(' ');
            int one_length = int.Parse(ip[0]);
            int two_length = int.Parse(ip[1]);
            int[,] Zarr = new int[one_length, two_length];
            for (int i = 0; i < one_length; i++)
            {
                ip = Console.ReadLine().Split(' ');
                for (int j = 0; j < ip.Length; j++)
                {
                    Zarr[i, j] = int.Parse(ip[j]);
                }
            }
            //print transposed matrix arr
            int a = Zarr.GetLength(0);
            int b = Zarr.GetLength(1);
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write(Zarr[j,i]);
                    if (j != a - 1) Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
