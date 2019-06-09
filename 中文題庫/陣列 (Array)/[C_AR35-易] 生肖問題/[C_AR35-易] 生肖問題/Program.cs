using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR35_易__生肖問題
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Yearname = new string[] { "rat", "ox", "tiger", "rabbit", "dragon", "snake", "horse", "sheep", "monkey", "rooster", "dog", "pig" };
            int i = int.Parse(Console.ReadLine()) - 2008;
            i %= 12;
            if (i < 0) i += 12;
            Console.WriteLine(Yearname[i]);
        }
    }
}

