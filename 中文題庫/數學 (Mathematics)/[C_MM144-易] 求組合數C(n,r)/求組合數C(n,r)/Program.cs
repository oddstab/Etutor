using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 求組合數C_n_r_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                decimal tot = 1;
                string[] nr = Console.ReadLine().Split(' ');
                decimal m = decimal.Parse(nr[0]), n = decimal.Parse(nr[1]);
                for(decimal i=1;i<=n; i++)
                {
                    tot = (tot * (m - n + i))/i;
                }
                Console.WriteLine(tot);
            }
        }
    }
}
