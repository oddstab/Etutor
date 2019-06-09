using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 遞迴程式練習
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(F(k));
        }
        static int F(int n)
        {
            if (n == 0 || n == 1) return n + 1;
            return F(n - 1) + F((int)Math.Truncate((double)n / 2));
        }
    }
}
