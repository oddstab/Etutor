using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.線段切割
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                List<int> TLen = new List<int>();
                int n = int.Parse(Console.ReadLine());
                for (int i = 1, sum = 0; sum <= n; i++)
                {
                    sum += i;
                    TLen.Add(i);
                }
                Console.WriteLine(TLen.Count - 1);
            }            
        }
    }
}