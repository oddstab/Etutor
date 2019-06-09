using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST49_易__字串取代
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] RStr = { { "hate", "love" }, { "stupid", "smart" }, { "angry", "happy" }, { "dirty", "clean" } };
            string s = Console.ReadLine();
            for (int i = 0; i < RStr.GetLength(0); i++) s = s.Replace(RStr[i, 0], RStr[i, 1]);
            Console.WriteLine(s);
        }
    }
}