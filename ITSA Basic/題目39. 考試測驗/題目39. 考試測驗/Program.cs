using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 題目39.考試測驗
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int g = 0; g < n; g++)
            {
                string[] Score = Console.ReadLine().Split(' ');
                int a = int.Parse(Score[0]);
                int b = int.Parse(Score[1]);
                int c = int.Parse(Score[2]);

                bool abc = a + b + c >= 220;
                bool ccc = (a >= 60 && b >= 60 && c <= 60) || (a >= 60 && c >= 60 && b <= 60) || (b >= 60 && c >= 60 && a <= 60);
                bool c80 = (a < 60 && b < 60 && c >= 80) || (a < 60 && c < 60 && b >= 80) || (b < 60 && c < 60 && a >= 80);

                if (a >= 60 && b >= 60 && c >= 60) Console.WriteLine("P");//方式1
                else if (a + b + c >= 220) Console.WriteLine("P");//方式2
                else if (ccc && !abc) Console.WriteLine("M");//方式3
                else if (c80) Console.WriteLine("M");//方式4
                else Console.WriteLine("F");
            }
            Console.ReadKey();
        }
    }
}
