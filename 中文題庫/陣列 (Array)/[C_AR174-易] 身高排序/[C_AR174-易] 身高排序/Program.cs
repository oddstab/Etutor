using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR174_易__身高排序
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> vs = new List<int>();
            string ip = Console.ReadLine();
            while (ip != "=====")
            {
                vs.Add(int.Parse(ip));
                ip = Console.ReadLine();
            }
            vs.Sort();
            vs.Reverse();
            ip = "";
            string str = "";
            while (true)
            {
                ip = Console.ReadLine();
                if (ip == "end") break;
                str += vs[int.Parse(ip) - 1] + "\n";
            }
            Console.Write(str);
        }
    }
}