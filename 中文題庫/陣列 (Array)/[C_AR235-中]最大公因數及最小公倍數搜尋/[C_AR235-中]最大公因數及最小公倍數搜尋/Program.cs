using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR235_中_最大公因數及最小公倍數搜尋
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] ip = Console.ReadLine().Split();
                int a = int.Parse(ip[0]);
                int b = int.Parse(ip[1]);
                Console.WriteLine(GCD(a,b)+" "+a*b/GCD(a,b));
            }
        }
        static int GCD(int A, int B)
        {
            B %= A;
            if (B == 0) return A;
            return GCD(B, A);
        }
    }
}