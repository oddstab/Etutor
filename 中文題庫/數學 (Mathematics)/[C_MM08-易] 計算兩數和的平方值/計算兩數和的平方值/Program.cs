using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 計算兩數和的平方值
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ip = Console.ReadLine().Split(' ');
            int x = int.Parse(ip[0]);
            int y = int.Parse(ip[1]);
            Console.WriteLine((x+y)*(x+y));
            Console.ReadKey();
        }
    }
}
