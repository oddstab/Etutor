using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST11_易__星號菱形輸出
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                int x, b;
                x = (n - 1) / 2;
                string[] star = new string[x + 1];
                b = x;
                for (int i = 1, a = 1; i <= b + 1; i++, a += 2, x--)
                {
                    for (int j = 1; j <= x + a; j++)
                    {
                        if (j <= x) star[i - 1] += " ";
                        else star[i - 1] += "*";
                    }
                    Console.WriteLine(star[i - 1]);
                }
                for (int i = star.Length - 2; i >= 0; i--) Console.WriteLine(star[i]);
            }
        }
    }
}