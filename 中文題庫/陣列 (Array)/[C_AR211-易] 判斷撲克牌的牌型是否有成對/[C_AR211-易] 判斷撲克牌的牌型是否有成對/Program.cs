using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _C_AR211_易__判斷撲克牌的牌型是否有成對
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] S = Console.ReadLine().Split();
                Console.WriteLine(JQK(S));
            }         
        }
        static int JQK(string[] m)
        {
            int len = 0;
            int[] tot = new int[5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (m[i].Substring(0, 1) == m[j].Substring(0, 1)) tot[i]++;
                }
                if (tot[i] == 4) return 2;
                if (tot[i] == 3) return 1;
            }
            for (int i = 0; i < 5; i++)
            {
                if (tot[i] == 2) len++;
                if (len >= 4) return 2;
            }
            if (len == 2) return 1;
            return 0;
        }
    }
}