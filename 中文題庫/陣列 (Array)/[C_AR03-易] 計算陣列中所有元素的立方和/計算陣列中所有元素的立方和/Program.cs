using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 計算陣列中所有元素的立方和
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] threeeeee = new string[6];
                int[] g = new int[6];
                threeeeee = Console.ReadLine().Split(' ');
                for (int i = 0; i < 6; i++) g[i] = int.Parse(threeeeee[i]);
                int a = (g[0] + g[1]) * ((int)Math.Pow(g[0], 2) - (g[0] * g[1]) + (int)Math.Pow(g[1], 2));
                int b = (g[2] + g[3]) * ((int)Math.Pow(g[2], 2) - (g[2] * g[3]) + (int)Math.Pow(g[3], 2));
                int c = (g[4] + g[5]) * ((int)Math.Pow(g[4], 2) - (g[4] * g[5]) + (int)Math.Pow(g[5], 2));
                Console.WriteLine(a + b + c);
                Console.ReadKey();
            }
        }
    }
}
