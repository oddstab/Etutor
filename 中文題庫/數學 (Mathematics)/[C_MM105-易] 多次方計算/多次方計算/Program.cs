using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多次方計算
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] ip = Console.ReadLine().Split(' ');
                int i1 = int.Parse(ip[0]);
                int i2 = int.Parse(ip[1]);
                Console.WriteLine(Math.Pow(i1,i2));
            }
        }
    }
}
