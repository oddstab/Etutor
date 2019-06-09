using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 遞迴f91
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int f91 = int.Parse(Console.ReadLine());
                string[] testdata = new string[f91];
                testdata = Console.ReadLine().Split(' ');
                for (int i = 1; i <= f91; i++) Console.WriteLine(F91(int.Parse(testdata[i - 1])));
            }
        }
        static int F91(int x)
        {
            if (x <= 100) return F91(F91(x + 11));
            else return x - 10;
        }
    }
}
