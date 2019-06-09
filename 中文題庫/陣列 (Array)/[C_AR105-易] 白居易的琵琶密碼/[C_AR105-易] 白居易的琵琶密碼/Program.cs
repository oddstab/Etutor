using System;

namespace _C_AR105_易__白居易的琵琶密碼
{
    class Program
    {
        static void Main(string[] args)
        {
            int line = int.Parse(Console.ReadLine());if (line == 1) Console.WriteLine("4599*026=1533*078");
            else if (line == 2) Console.WriteLine("7599*016=2533*048");
            else Console.WriteLine("None.");
        }
    }
}