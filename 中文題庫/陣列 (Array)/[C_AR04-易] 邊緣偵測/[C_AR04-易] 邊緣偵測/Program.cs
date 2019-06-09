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
            while (true)
            {
                int s = int.Parse(Console.ReadLine());
                for (int a = 0; a < s; a++)
                {
                    string[] ip = Console.ReadLine().Split();
                    int m = int.Parse(ip[0]);
                    int n = int.Parse(ip[1]);
                    string[,] Edge = new string[m, n];
                    for (int i = 0; i < m; i++)
                    {
                        ip = Console.ReadLine().Split();
                        for (int j = 0; j < n; j++) Edge[i, j] = ip[j];
                    }
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (Edge01(Edge, i, j)) Console.Write(0 + " ");
                            else Console.Write("_ ");
                        }
                        Console.WriteLine();
                    }
                    if (a != s - 1) Console.WriteLine();
                }
            }
        }
        static bool Edge01(string[,] edge, int i, int j)
        {
            if (edge[i, j] == "0") return false;
            else
            {
                int len1 = edge.GetLength(0);
                int len2 = edge.GetLength(1);
                //上
                if (i - 1 >= 0)
                {
                    if (edge[i - 1, j] == "0") return true;
                }
                //下
                if (i + 1 < len1)
                {
                    if (edge[i + 1, j] == "0") return true;
                }
                //左
                if (j - 1 >= 0)
                {
                    if (edge[i, j - 1] == "0") return true;
                }
                //右
                if (j + 1 < len2)
                {
                    if (edge[i, j + 1] == "0") return true;
                }
            }
            return false; 
        }
    }
}