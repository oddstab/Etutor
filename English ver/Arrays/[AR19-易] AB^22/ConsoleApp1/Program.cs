using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string str = Console.ReadLine();
                if (str == null) return;
                List<int> inint = new List<int>();
                int n = int.Parse(str);
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0) inint.Add(i);
                }
                for (int i = 0; i < inint.Count; i++)
                {
                    for (int j = 0; j < inint.Count; j++)
                    {
                        if (Math.Pow(inint[j], 2) * i == n)
                        {
                            Console.WriteLine("{0} = {1}*{2}^2", n, i, inint[j]);
                        }
                    }
                }
            }
        }
    }
}