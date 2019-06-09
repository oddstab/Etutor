using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST17_易__判斷是否為迴文
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] t = s.ToCharArray();
            Array.Reverse(t);
            if (s == new string(t)) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
