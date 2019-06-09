using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST20_易__字謎遊戲
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string CP1 = Console.ReadLine();
                string CP2 = Console.ReadLine();
                if (CP1.Length != CP2.Length) Console.WriteLine(0);
                else if (Game(CP1, CP2)) Console.WriteLine(1);
                else Console.WriteLine(0);
            }
        }
        static bool Game(string one, string two)
        {
            char[] CP1 = Bubblesort(one.ToCharArray());
            char[] CP2 = Bubblesort(two.ToCharArray());
            for (int i = 0; i < CP1.Length; i++) if (CP1[i] != CP2[i]) return false;           
            return true;
        }
        static char[] Bubblesort(char[] x)
        {
            char[] Sorting = x;
            char temp = ' ';
            for (int i = 0; i < Sorting.Length; i++)
            {
                for (int j = 1; j < Sorting.Length - i; j++)
                {
                    if (Sorting[j - 1] > Sorting[j])
                    {
                        temp = Sorting[j - 1];
                        Sorting[j - 1] = Sorting[j];
                        Sorting[j] = temp;
                    }
                }
            }
            return Sorting;
        }
    }
}