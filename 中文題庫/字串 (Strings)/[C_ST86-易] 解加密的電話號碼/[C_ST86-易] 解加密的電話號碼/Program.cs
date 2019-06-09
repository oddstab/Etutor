using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST86_易__解加密的電話號碼
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kpn = Console.ReadLine().Split();
            int d = 0, k = int.Parse(kpn[0]);
            for (int i = 1; i < kpn.Length; i++)
            {
                int a = int.Parse(kpn[i]);
                d = 10 - (a - k - 48);
                if (d == 10) d = 0;
                Console.Write(d);
            }
            Console.WriteLine();
        }
    }
}