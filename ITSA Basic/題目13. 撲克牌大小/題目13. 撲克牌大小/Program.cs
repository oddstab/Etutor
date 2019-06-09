using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 題目13.撲克牌大小
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int g = 0; g < n; g++)
            {
                string[] c = Console.ReadLine().Split();
                for (int i = 0; i < c.Length; i++)
                {
                    for (int j = 1; j < c.Length - i; j++)
                    {
                        string sub1 = c[j - 1].Substring(0, 1);
                        string sub2 = c[j].Substring(0, 1);
                        if (string.Compare(sub2, sub1) > 0) Swap(c, j, j - 1);
                        else if (sub1 == sub2)
                        {
                            int a = int.Parse(c[j - 1].Substring(1));
                            int b = int.Parse(c[j].Substring(1));
                            if (a < b) Swap(c, j, j - 1);
                        }
                    }
                }
                for(int i =0;i<c.Length; i++)
                {
                    Console.Write(c[i]);
                    if (i != c.Length - 1) Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void Swap(string[] x, int a, int b)
        {
            string temp = x[a];
            x[a] = x[b];
            x[b] = temp;
        }
    }
}