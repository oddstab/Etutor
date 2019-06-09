using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST22_易__迴文字串_II
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] P = Console.ReadLine().ToCharArray();
            Array.Reverse(P);
            for (int i = 0; i < P.Length; i++)
            {
                if (P[i] >= 65 && P[i] <= 90) Console.Write((char)(P[i] + 32));
                else if (P[i] >= 97 && P[i] <= 122) Console.Write((char)(P[i] - 32));
                else Console.Write(P[i]);
            }
            Console.WriteLine();
        }
    }
}
