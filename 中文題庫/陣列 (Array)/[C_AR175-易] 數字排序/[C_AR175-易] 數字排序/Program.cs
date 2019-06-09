using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR175_易__數字排序
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ip = Console.ReadLine().Split();
            int a = int.Parse(ip[1]);
            int b = int.Parse(ip[2]);
            ip[0] = ip[0].Remove(a-1, 1);
            ip[0] = ip[0].Remove(b - 2, 1);
            int[] tot = new int[3];
            for (int i = 0; i < 3; i++) tot[i] = int.Parse(ip[0].Substring(i, 1));
            Array.Sort(tot);
            Console.WriteLine("{0}{1}{2}", tot[0], tot[1], tot[2]);
        }
    }
}