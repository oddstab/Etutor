using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 費式數列
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                decimal ip = decimal.Parse(Console.ReadLine());
                Console.WriteLine(Fibb(ip));
            }
        }
        static decimal Fibb(decimal q)
        {
            decimal F0 = 0, F1 = 1, Fn = 0;
            if (q == 0) return 0;
            else if (q == 1) return 1;
            else
            {
                for (int i = 2; i <= q; i++)
                {
                    Fn = F0 + F1;
                    F0 = F1;
                    F1 = Fn;
                }
                return Fn;
            }
        }
    }
}
