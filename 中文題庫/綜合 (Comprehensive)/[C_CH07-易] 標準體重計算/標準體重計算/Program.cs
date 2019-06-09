using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 標準體重計算
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] sp = Console.ReadLine().Split();
                double x1, x2;
                x1 = double.Parse(sp[0]);
                x2 = int.Parse(sp[1]); 
                if (x2 == 1)//1=男生
                {    
                    Console.WriteLine(((x1 - 80) * 0.7).ToString("#.0"));
                }
                if (x2 == 2)
                {
                    Console.WriteLine(((x1 - 70) * 0.6).ToString("#.0"));
                }
                Console.ReadKey();
            }
            


        }
    }
}
