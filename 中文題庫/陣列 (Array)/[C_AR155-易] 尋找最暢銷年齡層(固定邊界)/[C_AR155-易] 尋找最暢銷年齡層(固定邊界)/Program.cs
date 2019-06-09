using System;

namespace _C_AR155_易__尋找最暢銷年齡層_固定邊界_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tot = new int[10];
            while (true)
            {
                string str = Console.ReadLine();
                if (str == "EOF") break;
                tot[int.Parse(str.Substring(0, 1)) - 1]++;
            }
            int t1 = tot[0];
            for (int i = 0; i < 9; i++)
                if (t1 < tot[i]) t1 = tot[i];
            Console.WriteLine("{0}0-{0}9", Array.IndexOf(tot, t1) + 1);
        }
    }
}