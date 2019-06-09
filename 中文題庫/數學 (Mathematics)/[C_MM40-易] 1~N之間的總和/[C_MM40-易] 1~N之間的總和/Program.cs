using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_MM40_易__1_N之間的總和
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), sum = 0;
            string str = "";
            for (int i = 1; i <= n; i++)
            {
                sum += i;
                str += i + " + ";
            }
            if (n == 1) Console.WriteLine("1 = 1");
            else Console.WriteLine(str.Substring(0, str.Length - 3) + " = " + sum);
        }
    }
}
