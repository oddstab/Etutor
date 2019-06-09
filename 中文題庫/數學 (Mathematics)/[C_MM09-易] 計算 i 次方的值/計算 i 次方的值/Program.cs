using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 計算_i_次方的值
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            if (x < 31) Console.WriteLine(Math.Pow(2, x));
            else Console.WriteLine("Value of more than 31");
            Console.ReadKey();
        }
    }
}
