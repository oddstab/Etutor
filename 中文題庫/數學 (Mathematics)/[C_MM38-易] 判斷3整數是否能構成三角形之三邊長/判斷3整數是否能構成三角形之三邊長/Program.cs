using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 判斷3整數是否能構成三角形之三邊長
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] t = Console.ReadLine().Split(' ');
                int x = int.Parse(t[0]);
                int y = int.Parse(t[1]);
                int z = int.Parse(t[2]);
                if (x + y > z && x + z > y && z + y > x) Console.WriteLine("fit");
                else Console.WriteLine("unfit");
            }
        }
    }
}
