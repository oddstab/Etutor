using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST01_易__數制轉換
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] IP = Console.ReadLine().Split(' ');
                int a = int.Parse(IP[0]);
                int b = int.Parse(IP[1]);
                if (a == 16) Console.WriteLine(Convert.ToString((int)b, a).ToUpper());
                else
                {
                    string str = "";
                    while (b != 0)
                    {
                        str += b % a;
                        b /= a;
                    }
                    char[] t = str.ToCharArray();
                    Array.Reverse(t);
                    Console.WriteLine(new string(t));
                }
            }
        }
    }
}