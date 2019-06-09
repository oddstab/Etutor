using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    bool flag = false;
                    int ip = int.Parse(Console.ReadLine());

                    for (int i = 2; i < ip; i++)
                    {
                        if (ip % i == 0)
                        {
                            flag = true;
                            break;
                        }
                    }
                    Console.WriteLine(flag ? "NO" : "YES");
                }
                catch
                {
                    break;
                }
            }
        }
    }
}
