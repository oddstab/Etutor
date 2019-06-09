using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_MM163_易__輾轉相除法
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x = Console.ReadLine().Split();
            int a = int.Parse(x[0]);
            int b = int.Parse(x[1]);
            Console.WriteLine(GCD(a,b));
        }
        static int GCD(int A, int B)
        {
            B %= A;
            if (B == 0) return A;
            return GCD(B, A);
        }
    }
}