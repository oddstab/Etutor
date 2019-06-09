using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR192_易__判断任意字串中的字元是否有重複
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] ip = Console.ReadLine().ToCharArray();
            if (YES(ip)) Console.WriteLine("true");
            else Console.WriteLine("false");
        }
        static bool YES(char[] n)
        {
            for (int i = 0; i < n.Length; i++)
            {
                for (int j = 0; j < n.Length - 1; j++)
                {
                    if (j == i) continue;
                    if (n[i] == n[j]) return false;
                }
            }
            return true;
        }
    }
}
