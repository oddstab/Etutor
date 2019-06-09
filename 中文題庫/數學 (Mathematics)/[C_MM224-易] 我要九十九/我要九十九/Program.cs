using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 我要九十九
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double ip = double.Parse(Console.ReadLine());
                int c = 0;
                if (ip == -1) break;
                while (ip < 99)
                {
                    ip = Math.Sqrt(ip) * 10;
                    c++;
                }
                Console.WriteLine(c);
            }
        }
    }
}
