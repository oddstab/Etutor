using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _AR04_易__Pyramids
{
    class Program
    {
        static string[][] star;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            star = new string[n][];
            for (int i = n; i > 1; i--)
            {
                Pyramid(i);
            }
        }
        static void Pyramid(int n)
        {
            int space = (n - 1) / 2;
            int b = space;
            for (int i = 1, a = 1; i <= b + 1; i++, a += 2, space--)
            {
                for (int j = 1; j <= space + a; j++)
                {
                    if (j <= space) star[i-1][i-1]+= " ";
                    else star[i - 1][i - 1] += "*";
                }
                star[i - 1][i - 1] = star[i - 1][i - 1].PadRight(n*2-1,'S');
            }
        }
    }
}