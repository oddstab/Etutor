using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 判斷基數偶數
{
    class Program
    {
        static void Main(string[] args)
        {
            int xx = int.Parse(Console.ReadLine());
            if (xx % 2 == 0) Console.WriteLine("even");
            else if (xx % 2 != 0) Console.WriteLine("odd");
            Console.ReadKey();
        }
    }
}
