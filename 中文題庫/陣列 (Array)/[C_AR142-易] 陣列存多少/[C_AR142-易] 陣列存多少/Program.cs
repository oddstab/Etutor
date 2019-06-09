using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR142_易__陣列存多少
{
    class Program
    {
        static void Main(string[] args)
        {
            double c = 0;
            string[] mn = Console.ReadLine().Split();
            int m = int.Parse(mn[0]);
            int n = int.Parse(mn[1]);
            double[] sqrt = new double[m];
            for (int i = 1; i <= m; i++) sqrt[i - 1] = i * i;
            for (int i = 0; i < sqrt.Length; i++) if (sqrt[i] % n == 0) c += sqrt[i];
            Console.WriteLine(c);
        }
    }
}