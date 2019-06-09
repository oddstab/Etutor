using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 計算1_N內能被2跟3整除_但不能被12整除的整數總和
{
    class Program
    {
        static void Main(string[] args)
        {
            int ip = int.Parse(Console.ReadLine());
            int sum =0;
            for (int i=1; i<=ip;i++)
            {
                if (i % 2 == 0 && i % 3 == 0&&i%12!=0 )
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
