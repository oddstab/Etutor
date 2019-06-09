using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST14_易__數字直角三角形輸出
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    for(int j =n;j>=1; j--)
                    {
                        if (j > i) Console.Write(" ");
                        else Console.Write(j);
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int j = n, a = 1; j >= 1; j--)
                    {
                        if (j <= i)
                        {
                            Console.Write(a);
                            a++;
                        }
                        else Console.Write(" ");
                    }
                    Console.WriteLine();
                }              
            }
        }
    }
}