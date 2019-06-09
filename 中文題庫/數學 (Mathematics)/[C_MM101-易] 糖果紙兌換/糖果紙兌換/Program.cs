using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 糖果紙兌換
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                int t = n;
                int candypaper = 0,tot=0;
                while (n / 3 != 0)
                {
                    candypaper = n %3;
                    n /= 3;
                    tot += n;
                    n += candypaper;
                }
                Console.WriteLine(tot+t);
            }
        }
    }
}
