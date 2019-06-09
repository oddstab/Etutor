using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST02_易__迴文字串
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i =0;i<n; i++)
            {
                char[] P = Console.ReadLine().ToCharArray();
                Array.Reverse(P);
                Console.WriteLine(new string(P));
            }
        }
    }
}
