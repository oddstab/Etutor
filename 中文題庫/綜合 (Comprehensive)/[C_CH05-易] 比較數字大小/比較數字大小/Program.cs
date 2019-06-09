using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 比較數字大小
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] n = Console.ReadLine().Split(' ');
                int x, y, z;
                x = int.Parse(n[0]);
                y = int.Parse(n[1]);
                z = int.Parse(n[2]);
                if (x > y && x > z)
                {
                    if (y > z) Console.WriteLine("{0}>{1}>{2}", x, y, z);
                    else Console.WriteLine("{0}>{1}>{2}", x, z, y);
                }
                else if (y>x&&y>z)
                {
                    if(z>x) Console.WriteLine("{0}>{1}>{2}", y, z, x);
                    else Console.WriteLine("{0}>{1}>{2}", y, x, z);
                }
                else if (z > y && z > x)
                {
                    if(y>x) Console.WriteLine("{0}>{1}>{2}", z, y, x);
                    else Console.WriteLine("{0}>{1}>{2}", z,x ,y );
                }
                Console.ReadKey();
            }
        }
    }
}
