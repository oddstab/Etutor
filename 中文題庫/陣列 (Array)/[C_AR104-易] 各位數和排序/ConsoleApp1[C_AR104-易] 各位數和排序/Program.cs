using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 題目26.各位數和排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] ip = Console.ReadLine().Split();
            int[] intip = new int[ip.Length];
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < ip[i].Length; j++)
                {
                    sum += int.Parse(ip[i].Substring(j, 1));
                }
                intip[i] = sum;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < n - i; j++)
                {
                    if (intip[j - 1] > intip[j]) Swap(ip, intip, j - 1, j);
                    else if (intip[j - 1] == intip[j])
                    {
                        if (int.Parse(ip[j - 1]) > int.Parse(ip[j])) Swap(ip, intip, j - 1, j);
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(ip[i]);
                if (i != n - 1) Console.Write(" ");
            }
            Console.WriteLine();
        }
        static void Swap(string[] m, int[] intm, int a, int b)
        {
            string temp = m[a];
            m[a] = m[b];
            m[b] = temp;

            int temp2 = intm[a];
            intm[a] = intm[b];
            intm[b] = temp2;
        }
    }
}