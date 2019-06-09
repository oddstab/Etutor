using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_MM85_易__完美數問題
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ulong ip = ulong.Parse(Console.ReadLine());
                Console.WriteLine("{0} is perfect number", isperfect(ip));
            }
        }
        static string isperfect(ulong pnum)
        {
            ulong o = 0;
            string tot = "";
            ulong[] pn = { 6, 28, 496, 8128, 33550336 };
            for (ulong i = 0; i < pnum; i+=2)
            {
                if (i == pn[o])
                {
                    tot += pn[o]+" ";
                    o++;
                }
            }
            tot=tot.TrimEnd(' ');
            return tot;
        }
    }
}
