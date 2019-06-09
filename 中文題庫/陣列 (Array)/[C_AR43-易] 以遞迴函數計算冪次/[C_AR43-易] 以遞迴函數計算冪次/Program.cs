using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR43_易__以遞迴函數計算冪次
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] str = Console.ReadLine().Split(' ');
                if (int.Parse(str[0]) < 0 && int.Parse(str[1]) < 0) break;
                Console.WriteLine(Power(int.Parse(str[0]), int.Parse(str[1])));
            }            
        }
        static int Power(int x, int y)
        {
            if (y == 0) return 1;
            else return x * Power(x, y - 1);
        }
    }
}
