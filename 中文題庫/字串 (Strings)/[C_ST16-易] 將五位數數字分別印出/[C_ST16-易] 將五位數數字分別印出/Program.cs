using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST16_易__將五位數數字分別印出
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] S = Console.ReadLine().ToCharArray();
            string str = "";
            foreach (char s in S) str += s + "   ";
            Console.WriteLine(str.TrimEnd(' '));
        }
    }
}
