using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR171_易__矩陣旋轉
{
    class Program
    {
        static void Main(string[] args)
        {
            int mn = int.Parse(Console.ReadLine());
            string[,] MXN = new string[mn, mn];
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < mn; i++)
            {
                string[] ip = Console.ReadLine().Split();
                for (int j = 0; j < mn; j++) MXN[i, j] = ip[j];
            }
            for (int i = 0; i < n; i++) MXN = Right(MXN);
            for (int i = 0; i < mn; i++)
            {
                for (int j = 0; j < mn; j++)
                {
                    Console.Write(MXN[i,j]);
                    if (j != mn - 1) Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
        static string[,] Right(string[,] m)
        {
            string[,] copy = m;
            int len = m.GetLength(0);
            m = new string[len, len];
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    m[i, j] = copy[len - 1 - j, i];
                }
            }
            return m;
        }
    }
}