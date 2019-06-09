using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                    Console.Write(" ");
                for (int k = 1; k <= i * 2 - 1; k++)
                    Console.Write("*");
                Console.WriteLine("");
            }
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write(" ");
                for (int k = 1; k <= 7 - 2 * i; k++)
                    Console.Write("*");
                Console.WriteLine("");
            }
        }
    }
}
