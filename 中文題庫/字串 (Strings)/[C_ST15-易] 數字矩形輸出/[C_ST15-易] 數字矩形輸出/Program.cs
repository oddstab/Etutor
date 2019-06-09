using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST15_易__數字矩形輸出
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i < n; i++)
                {
                    for (int j = 1, a = 0; j <= n; j++)
                    {
                        if (j <= i) Console.Write(j);
                        else
                        {
                            Console.Write(n - a);
                            a++;
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}