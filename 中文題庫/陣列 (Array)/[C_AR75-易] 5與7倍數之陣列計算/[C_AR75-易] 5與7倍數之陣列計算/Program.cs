using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR75_易__5與7倍數之陣列計算
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int h = 0; h < n; h++)
            {
                int g = int.Parse(Console.ReadLine());
                List<int> fand7 = new List<int>();
                for (int i = 1; i <= g; i++) if (i % 5 == 0 || i % 7 == 0) fand7.Add(i);
                int[] f7 = fand7.ToArray();
                double sum = 0, avg = 0, o = 0;
                for (int i = 0; i < f7.Length; i++)
                {
                    if (i % 2 == 0) sum += f7[i];
                    else
                    {
                        avg += f7[i];
                        o++;
                    }
                }
                double temp = Math.Round(avg / o, 1, MidpointRounding.AwayFromZero);
                Console.WriteLine("{0}\n{1}", sum, temp);
            }
        }
    }
}