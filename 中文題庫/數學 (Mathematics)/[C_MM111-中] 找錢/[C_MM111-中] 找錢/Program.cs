using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_MM111_中__找錢
{
    class Program
    {
        static void Main(string[] args)
        {
            //表示 . 0 個 50 元、 0 個 10 元、 0 個 5 元、 0 個 1 元
            //       0 0 0 0
            int n = int.Parse(Console.ReadLine());
            int[] MS = new int[4];
            if (n < 5) Console.WriteLine("0 0 0 "+n);
            else
            {
                while (!(n<5))
                {

                    Console.WriteLine("{0} {1} {2} {3}",MS[0],MS[1],MS[2],MS[3]);





                }
            }
        }
    }
}