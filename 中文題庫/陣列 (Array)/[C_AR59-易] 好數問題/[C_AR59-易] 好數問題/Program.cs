using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR59_易__好數問題
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string IP = Console.ReadLine();
                if (IP.Length > 4 || IP.Length < 4)
                {
                    Console.WriteLine("Failure Input");
                    continue;
                }
                else if (YesORNo(IP)) Console.WriteLine("Yes");
                else Console.WriteLine("No");
            }
        }
        static bool YesORNo(string str)
        {
            int tot = 0;
            int c = 0;
            List<int> Temp = new List<int>();
            for (int i = 0; i < str.Length; i++)
            {
                tot = 0;
                int sub = int.Parse(str.Substring(i, 1));
                if (Temp.Contains(sub)) continue;
                for (int j = 0; j < str.Length; j++)
                {
                    int sub2 = int.Parse(str.Substring(j, 1));
                    if (sub == sub2) tot++;
                    if (tot > 2) return false;
                }
                if (tot == 2)
                {
                    Temp.Add(sub);
                    c++;
                }
            }
            if (c != 1) return false;
            return true;
        }
    }
}
