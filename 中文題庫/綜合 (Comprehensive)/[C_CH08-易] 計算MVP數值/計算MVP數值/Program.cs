using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 計算MVP數值
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] baseball = Console.ReadLine().Split(' ');
            int avg, ballboard, ass, wow, wrong,total;
            avg = int.Parse(baseball[0]);
            ballboard= int.Parse(baseball[1]);
            ass= int.Parse(baseball[2]);
            wow= int.Parse(baseball[3]);
            wrong=int.Parse(baseball[4]);
            total = (avg*1+ass*2+ballboard*2+wow*2) - (wrong * 2);
            if (total >= 45) Console.WriteLine("A");
            else if (total <= 44 && total >= 35) Console.WriteLine("B");
            else if (total <= 34 && total >= 25) Console.WriteLine("C");
            else Console.WriteLine("D");
            Console.ReadKey();
        }
    }
}
