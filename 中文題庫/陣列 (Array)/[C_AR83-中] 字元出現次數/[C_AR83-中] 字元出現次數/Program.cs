using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _C_AR83_中__字元出現次數
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string str = Console.ReadLine();
                if (str== "end") break;
                Console.WriteLine(Regex.Matches(str, Console.ReadLine()).Count);
            }            
        }
    }
}
