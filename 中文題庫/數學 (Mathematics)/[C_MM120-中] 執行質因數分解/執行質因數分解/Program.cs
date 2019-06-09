using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 執行質因數分解
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                long ip = long.Parse(Console.ReadLine());
                Console.Write(ip+"=");
                if (ip == 1)
                {
                    Console.WriteLine(1);
                    continue;
                }
                for(long i = 2; i <= ip; i++)
                {
                    while (ip % i == 0)
                    {
                        Console.Write(i);
                        ip /= i;
                        if (ip != 1) Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }


    }
}
