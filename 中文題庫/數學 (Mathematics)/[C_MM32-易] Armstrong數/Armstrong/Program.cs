using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string ip = Console.ReadLine();
                int xend = int.Parse(ip);
                int x1 = int.Parse(ip.Substring(0,1));
                int x2 = int.Parse(ip.Substring(1,1));
                int x3 = int.Parse(ip.Substring(2));
                double sbigggg = Math.Pow(x1, 3) + Math.Pow(x2, 3) + Math.Pow(x3, 3);
                if (sbigggg != xend) Console.WriteLine("NO");
                else Console.WriteLine("YES");
            }
        }
    }
}
