using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _C_AR152_易__正整數統計
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> any = new List<int>();
            List<int> tot = new List<int>();
            List<int> Q = new List<int>();
            int n = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) any.Add(int.Parse(Console.ReadLine()));
            for (int i = 0; i < n; i++)
            {
                if (!tot.Contains(any[i]))
                {
                    int total = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (any[i] == any[j]) total++;
                    }
                    if (total >= max)
                    {
                        tot.Add(any[i]);
                        Q.Add(total);
                    }
                }
            }
            for (int i = 0; i < tot.Count; i++)
            {
                for (int j = 1; j < tot.Count - i; j++)
                {
                    if (tot[j - 1] > tot[j])
                    {
                        int temp = tot[j - 1];
                        tot[j - 1] = tot[j];
                        tot[j] = temp;

                        temp = Q[j - 1];
                        Q[j - 1] = Q[j];
                        Q[j] = temp;
                    }
                }
            }
            for (int i = 0; i < tot.Count; i++)
            {
                Console.WriteLine(tot[i] + "," + Q[i]);
            }
            Console.ReadKey();
        }
    }
}