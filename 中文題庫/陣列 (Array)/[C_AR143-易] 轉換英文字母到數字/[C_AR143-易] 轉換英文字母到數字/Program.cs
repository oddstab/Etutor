using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR143_易__轉換英文字母到數字
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] ip = Console.ReadLine().ToCharArray();
            for(int i =0;i<ip.Length; i++)
            {
                Console.Write("({0})",ip[i]-97);
            }
            Console.WriteLine();
        }
    }
}