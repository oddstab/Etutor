using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR77_易__二維陣列反轉
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[,] MxN = new int[m, n];
            int Q = m * n;
            string str = "";
            for (int i = m - 1; i >= 0; i--)
            {
                str = "";
                for (int j = n - 1; j >= 0; j--, Q--)
                {
                    MxN[i, j] = Q;
                    str += MxN[i, j] + " ";
                }
                Console.WriteLine(str.TrimEnd(' '));
            }
        }
    }
}
