using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _C_AR20_易__檢查數值是否有重複
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] Data = new string[n];
            Data = Console.ReadLine().Split(' ');
            if (YorN(Data)) Console.WriteLine(1);
            else Console.WriteLine(0);
        }
        static bool YorN(string[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                string temp = x[i];
                x[i] = "X";
                if (x.Contains(temp)) return false;
            }
            return true;
        }
    }
}
