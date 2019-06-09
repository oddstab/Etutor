using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 選擇排序法
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                List<int> Future = new List<int>();
                List<string> dis = new List<string>();
                while (true)
                {
                    string ip = Console.ReadLine();
                    if (ip == ",") break;
                    else Future.Add(int.Parse(ip));
                }
                int[] A = Future.ToArray();
                for()
            }
        }
    }
}
