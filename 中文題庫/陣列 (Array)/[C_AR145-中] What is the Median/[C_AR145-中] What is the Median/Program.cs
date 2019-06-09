using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR145_中__What_is_the_Median
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] x = new double[10];
            int i = 0;
            for (string str = Console.ReadLine(); i < 10; i++)
            {
                x[i] = double.Parse(str.Split()[i]);
            }
            Array.Sort(x);
            for (i = 0; i < 10; i++)
            {
                Console.Write(x[i] + (i == 9 ? "" : " "));
            }
            string dis = Math.Round(((x[4]+x[5])/2),2).ToString("f2");
            Console.WriteLine("\n"+"Median:"+dis);
        }
    }
}