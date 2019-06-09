using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 連續1的倍數v2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int x = int.Parse(Console.ReadLine());
                string[] data = new string[x];
                data = Console.ReadLine().Split(' ');
                int temp=1;
                int i;
                for (int j = 0; j < x; j++)
                {
                    for (i = 0; temp % int.Parse(data[j]) != 0; i++)
                    {
                        temp = (temp * 10 + 1) % int.Parse(data[j]);
                    }
                    temp = 1;
                    Console.WriteLine(i + 1);
                } 
            }
        }
    }
}
