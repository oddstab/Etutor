using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST45_易__名字反了
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    char[] D = Console.ReadLine().ToLower().ToCharArray();
                    Array.Reverse(D);
                    string S = new string(D);
                    Console.WriteLine(S.Substring(0, 1).ToUpper() + S.Substring(1, S.Length - 1));
                }
            }            
        }
    }
}
