using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_CH10_中__The_3n___1_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                List<int> tot = new List<int>();
                List<int> maxlen = new List<int>();
                string[] ab = Console.ReadLine().Split();
                int a = int.Parse(ab[0]);
                int b = int.Parse(ab[1]);
                int min = a < b ? a : b;
                int max = a > b ? a : b;
                for (int i = min, t = i; i <= max; i++, t = i)
                {
                    Console.Write(i+" = ");
                    while (t != 1)
                    {
                        tot.Add(t);
                        Console.Write(t + " ");
                        t = WTFrecursive(t);
                    }
                    maxlen.Add(tot.Count + 1);
                    Console.WriteLine("("+i + "的總長度為"+(tot.Count+1)+")");
                    tot = new List<int>();
                    
                }
                maxlen.Sort();
                Console.WriteLine("\n答案："+a + " " + b + " " + maxlen[maxlen.Count - 1]);
            }           
        }
        static int WTFrecursive(int n)
        {
            if (n == 1) return 1;
            else if (n % 2 != 0) return n = 3 * n + 1;
            else return n /= 2;
        }
    }
}