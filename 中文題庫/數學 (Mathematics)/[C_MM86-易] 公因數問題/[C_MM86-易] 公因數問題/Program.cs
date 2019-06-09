using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_MM86_易__公因數問題
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] Ip = Console.ReadLine().Split(' ');
                int Max = GCD(int.Parse(Ip[0]), int.Parse(Ip[1]));
                Console.Write("Common factor in ascending order: ");
                string str = "";
                for (int i = 2; i <= Math.Max(Max, int.Parse(Ip[2])); i++)
                {
                    if (Max % i == 0 && int.Parse(Ip[2]) % i == 0) str += i+" ";
                }
                Console.WriteLine(str.TrimEnd(' '));
            }
        }
        static int GCD(int a, int b)
        {
            if (b == 0) return a;
            else return GCD(b, a % b);
        }
    }
}
