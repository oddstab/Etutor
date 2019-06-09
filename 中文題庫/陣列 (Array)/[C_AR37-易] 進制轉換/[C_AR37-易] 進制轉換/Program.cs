using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR37_易__進制轉換
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] IP = Console.ReadLine().Split(' ');
            Console.Write("The base {0} representation of {1} is ",IP[1],IP[0]);
            Console.WriteLine(Convert.ToString(int.Parse(IP[0]),int.Parse(IP[1]))+".");
        }
    }
}
