using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ip = "";
            int sum = 0;

            int len = 0;
            ip = Console.ReadLine();
            string n11 = Console.ReadLine();
            for (int i = 0; i < ip.Length; i++)
            {
                if (ip.Substring(i, 1) == "," || ip.Substring(i, 1) == "!") len++;
            }
            ip = ip.Replace(",", " ");
            ip = ip.Replace("!", " ");
            for (int i = ip.IndexOf("  "); i != -1; i = ip.IndexOf("  "))
            {
                ip = ip.Replace("  ", " ");
            }
            ip = ip.TrimEnd(' ').TrimStart(' ');
            sum += ip.Split(' ').Length + len;

            Console.WriteLine(sum);
        }
    }
}