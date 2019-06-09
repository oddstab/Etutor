using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace 過半元素
{
    class Program
    {
        static void Main(string[] args)
        {
            bool s = true;
            string IP = Console.ReadLine();
            string[] Y = IP.Split(' ');
            for (int i = 0; i < Y.Length; i++)
            {
                if (Regex.Matches(IP, Y[i]).Count > Y.Length / 2)
                {
                    Console.WriteLine(Y[i]);
                    s = false;
                    break;
                }
            }
            if (s) Console.WriteLine("NO");
        }
    }
}