using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST12_易__星號依規則輸出
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] SP = Console.ReadLine().Split(' ');

                int a = int.Parse(SP[0]);
                int b = int.Parse(SP[1]);
                if (a < b)
                {
                    for (int i = a; i < b; i++)
                    {
                        for (int j = 0; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    for (int i = a; i >= b; i--)
                    {
                        for (int j = i; j >= 1; j--)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }
            }           
        }
    }
}
