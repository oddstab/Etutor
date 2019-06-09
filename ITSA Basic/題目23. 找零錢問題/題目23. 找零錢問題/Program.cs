using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 找錢
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] T = Console.ReadLine().Split(',');
                int a1 = int.Parse(T[1]) * 15;
                int a2 = int.Parse(T[2]) * 20;
                int a3 = int.Parse(T[3]) * 30;
                int tot = int.Parse(T[0]) - a1 - a2 - a3;
                if (int.Parse(T[0]) < (a1 + a2 + a3)) Console.WriteLine(0);
                else Console.WriteLine(X(tot));
            }
        }
        static string X(int Q)
        {
            int[] a = new int[3];
            while (Q != 0)
            {
                if (Q >= 50) { Q -= 50; a[2]++; continue; }
                if (Q >= 5) { Q -= 5; a[1]++; continue; }
                if (Q >= 1) { Q -= 1; a[0]++; continue; }
            }
            return a[0] + "," + a[1] + "," + a[2];
        }
    }
}