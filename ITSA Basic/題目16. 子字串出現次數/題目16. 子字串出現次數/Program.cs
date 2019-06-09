using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 題目16.子字串出現次數
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string sub = Console.ReadLine();
                string TrueStr = Console.ReadLine();
                int len_sub = sub.Length;
                int c = 0;
                for (int i = 0; i < (TrueStr.Length - len_sub + 1); i++)
                {
                    if (TrueStr.Substring(i, len_sub) == sub) c++;
                }
                Console.WriteLine(c);
            }
        }
    }
}
