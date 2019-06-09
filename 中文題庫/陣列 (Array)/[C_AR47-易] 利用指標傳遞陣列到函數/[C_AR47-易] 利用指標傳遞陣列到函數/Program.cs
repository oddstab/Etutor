using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR47_易__利用指標傳遞陣列到函數
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] NOr = Console.ReadLine().Split(' ');
            Array.Reverse(NOr);
            string str = "";
            foreach (string s in NOr) str += s+" ";
            Console.WriteLine(str.TrimEnd(' '));
        }
    }
}
