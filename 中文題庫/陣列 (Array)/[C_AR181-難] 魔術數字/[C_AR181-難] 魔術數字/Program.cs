using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR181_難__魔術數字
{
    class Program
    {
        static void Main(string[] args)
        {
            string origin = "CELAMGIGOOC";
            string ip = Console.ReadLine();
            char[] t = ip.ToCharArray();
            Array.Reverse(t);
            int temp = int.Parse(new string(t));
            int f12 = Math.Abs(temp - int.Parse(ip));
            t = f12.ToString().ToCharArray();
            Array.Reverse(t);
            int f34 = int.Parse(new string(t));
            string tot = ((f34 + f12) * 40).ToString();
            for (int i = 0; i < tot.Length; i++) Console.Write(origin.Substring(int.Parse(tot.Substring(i, 1)), 1));
            Console.WriteLine();
        }
    }
}