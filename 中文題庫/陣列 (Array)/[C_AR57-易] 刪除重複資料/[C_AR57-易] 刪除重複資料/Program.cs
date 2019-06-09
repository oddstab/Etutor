using System;
using System.Collections.Generic;
using System.Linq;

namespace _C_AR57_易__刪除重複資料
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int o = 0; o < n; o++)
            {
                string str = Console.ReadLine();
                int totalLength = str.Length;
                int len = 0;
                for (int i = 0; len != totalLength; i++)
                {
                    string sub = str.Substring(i, 1);
                    int A = Q(str, sub);
                    len += A;
                    if (A > 1)
                    {
                        while (A != 1)
                        {
                            str = str.Remove(str.LastIndexOf(sub), 1);
                            A = Q(str, sub);
                        }
                    }
                }
                Console.WriteLine(totalLength + " " + str.Length);
            }
        }
        static int Q(string str, string sub)
        {
            int Q = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str.Substring(i, 1) == sub) Q++;
            }
            return Q;
        }
    }
}
