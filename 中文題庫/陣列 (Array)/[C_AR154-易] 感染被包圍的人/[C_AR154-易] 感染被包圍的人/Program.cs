using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR04_易__邊緣偵測
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ip;
            int m = 7;
            int n = 7;
            string[,] Edge = new string[m, n];
            for (int i = 0; i < m; i++)
            {
                ip = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    Edge[i, j] = ip[j];
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (Edge01(Edge, i, j)) Console.Write("I{0}", j != 6 ? " " : "");
                    else Console.Write("{1}{0}", j != 6 ? " " : "", Edge[i, j] == "0" ? "0" : "X");
                }
                Console.WriteLine();
            }
        }
        static bool Edge01(string[,] edge, int i, int j)
        {
            try
            {
                if (edge[i, j] == "X") return false;
                return edge[i - 1, j] == "X" && edge[i + 1, j] == "X" && edge[i, j - 1] == "X" && edge[i, j + 1] == "X";
            }
            catch
            {
                return false;
            }
        }
    }
}