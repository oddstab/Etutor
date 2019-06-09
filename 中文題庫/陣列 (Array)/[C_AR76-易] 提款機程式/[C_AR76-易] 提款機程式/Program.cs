using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR76_易__提款機程式
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] ATM = { { 123, 456, 9000 }, { 456, 789, 5000 }, { 789, 888, 6000 }, { 336, 558, 10000 }, { 775, 666, 12000 }, { 566, 221, 7000 } };
            int n = int.Parse(Console.ReadLine());
            for (int w = 0; w < n; w++)
            {
                bool What = true;
                string[] Ans = Console.ReadLine().Split(' ');
                int a = int.Parse(Ans[0]);
                int b = int.Parse(Ans[1]);
                for (int j = 0; j < ATM.GetLength(0); j++)
                {
                    if (a == ATM[j, 0] && b == ATM[j, 1])
                    {
                        Console.WriteLine(ATM[j, 2]);
                        What = false;
                        break;
                    }
                }
                if (What) Console.WriteLine("error");
            }
        }
    }
}