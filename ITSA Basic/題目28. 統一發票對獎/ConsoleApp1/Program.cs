using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static string[] reward = new string[4];
        public static int[] rs = { 200000, 40000, 10000, 4000, 1000, 200 };
        static void Main(string[] args)
        {
            while (true)
            {
                for (int i = 0; i < 4; i++)
                {
                    reward[i] = Console.ReadLine();
                }
                int n = int.Parse(Console.ReadLine());
                int[] invoice = new int[n];
                int[] C = new int[7];
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    string ip = Console.ReadLine();
                    int S = Money(ip);
                    if (S == 2000000) { C[0]++; sum += S; }
                    else if (S == 0) continue;
                    else
                    {
                        for (int a = 0; a < 6; a++)
                        {
                            if (S == rs[a]) { C[a+1]++; sum += S; }
                        }
                    }
                }
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}\n{7}", C[0], C[1], C[2], C[3], C[4], C[5], C[6], sum);
            }
        }
        static int Money(string M)
        {
            int sum = 0;
            if (M == reward[0].ToString()) return 2000000;
            else
            {
                for (int i = 1; i < 4; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        string subR = reward[i].Substring(j);
                        string subM = M.Substring(j);
                        if (subM == subR) sum = rs[j] > sum ? rs[j] : sum;
                    }
                }
            }
            return sum;
        }
    }
}