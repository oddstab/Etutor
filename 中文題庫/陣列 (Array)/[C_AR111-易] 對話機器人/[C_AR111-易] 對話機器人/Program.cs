using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR111_易__對話機器人
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                string ip = Console.ReadLine().ToLower();
                if (ip.Substring(0, 1) == "h")
                {
                    if (i == 0) Console.WriteLine("Hi");
                    if (i == 1) Console.WriteLine("Hello");
                    if (i == 2) Console.WriteLine("How do you do");
                    if (i == 3) Console.WriteLine("How are you");
                    i = i == 3 ? 0 : ++i;
                }
                else
                {
                    Console.WriteLine("Sorry");
                    i = 0;
                }               
            }
        }
    }
}