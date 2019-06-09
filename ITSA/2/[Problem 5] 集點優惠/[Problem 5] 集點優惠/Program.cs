using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Problem_5__集點優惠
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0) break;
                int TotalPoint = 0, T = n;
                int point = 0;
                while ((n / 6 != 0))
                {
                    point = n % 6;
                    n /= 6;
                    TotalPoint += n;
                    n += point;
                }
                Console.WriteLine(TotalPoint + T + " " + (TotalPoint + T) % 6);
            }
        }
    }
}
