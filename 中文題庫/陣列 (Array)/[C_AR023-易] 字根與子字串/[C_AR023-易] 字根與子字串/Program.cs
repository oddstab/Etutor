using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR023_易__字根與子字串
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();
                if (Console.ReadLine().IndexOf(s) >= 0) Console.WriteLine("YES");
                else Console.WriteLine("NO");
            }            
        }
    }
}
