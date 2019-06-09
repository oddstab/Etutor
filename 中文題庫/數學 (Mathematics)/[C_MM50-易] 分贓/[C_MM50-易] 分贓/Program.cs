using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_MM50_易__分贓
{
    class Program
    {
        static void Main(string[] arg)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string[] ip = Console.ReadLine().Split();
            int sum1 = 0, sum2 = 0;
            int tmp = 0;
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(ip[i]);
            }
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (sum1 < sum2)
                {
                    sum1 += a[i];
                }
                else
                {
                    sum2 += a[i];
                }
            }
            Console.WriteLine(Math.Abs(sum1 - sum2));
        }
    }
}