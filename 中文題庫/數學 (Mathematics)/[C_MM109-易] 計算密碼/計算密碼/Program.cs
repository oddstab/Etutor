using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 計算密碼
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double ffx = 0;
                double x = double.Parse(Console.ReadLine());
                double sub = double.Parse(Console.ReadLine());
                for (uint i = 1; i <= x; i++) ffx += 1.0 / factorial(i);
                Console.WriteLine(ffx.ToString().Substring((int)sub + 1, 4));

            }
        }
        static double factorial(uint x)
        {
            double f = 1; ;
            for (uint i = 1; i <= x; i++) f *= i;
            return f;
        }
    }
}
