using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 計算正整數被3整除之數值之總和
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int x = int.Parse(Console.ReadLine());
            for (int i=1; i<=x;i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
