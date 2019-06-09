using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] twoint = Console.ReadLine().Split(' ');
            int x, y, z;
            x = int.Parse(twoint[0]);
            y = int.Parse(twoint[1]);
            z = x % y;
            Console.WriteLine(x + "+" + y + "=" + (x + y));
            Console.WriteLine(x + "*" + y + "=" + (x * y));
            Console.WriteLine(x + "-" + y + "=" + (x - y));
            if (z < 0)
            {
                Console.WriteLine("{0}/{1}={2}...{3}", x, y, (x / y) - 1, z + y);
            }
            else Console.WriteLine(x+"/"+y+"="+(x/y)+"..."+x%y);


            //Console.WriteLine((x/y)-1);
            //Console.WriteLine((x%y)+y);

            //-7 / 2 = 3..- 1;
            //-7 = (3) * 2 + -1;

            // o = 3 * 2 + -1;
            //-7   商  除  餘
            
            Console.ReadKey();
        }
    }
}
