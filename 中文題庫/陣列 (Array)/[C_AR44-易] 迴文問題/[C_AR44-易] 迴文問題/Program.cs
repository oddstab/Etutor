using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR44_易__迴文問題
{
    class Program
    {
        static void Main(string[] args)
        {
            string bestr = Console.ReadLine();
            char[] after = bestr.ToCharArray();
            Array.Reverse(after);
            if (bestr == new string(after)) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
