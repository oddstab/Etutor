using System;
using System.Text.RegularExpressions;
namespace _C_SO09_易__字串重排
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string ip = Console.ReadLine();
                int one = Regex.Matches(ip, "1").Count;
                int len = ip.Length;
                ip = "";
                for (int i = 0; i < one; i++) ip += "1";
                Console.WriteLine(ip.PadRight(len, '0'));
            }
        }
    }
}