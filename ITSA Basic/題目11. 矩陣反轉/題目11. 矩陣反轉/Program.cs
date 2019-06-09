using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.矩陣反轉
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    string[] ip = Console.ReadLine().Split();
                    int M = int.Parse(ip[0]);
                    int N = int.Parse(ip[1]);
                    int[,] mn = new int[M, N];
                    string[] temp = new string[N];
                    for (int g = 0; g < M; g++)
                    {
                        temp = Console.ReadLine().Split();
                        for (int j = 0; j < N; j++)
                        {
                            mn[g, j] = int.Parse(temp[j]);
                        }
                    }
                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < M; j++)
                        {
                            Console.Write(mn[j, i]);
                            if (j != M - 1) Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                }
                catch
                {
                    break;
                }
            }
        }
    }
}