using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 判斷是否為迴文
{
    class Program
    {
        static void aMain(string[] args)
        {
            while (true)
            {
                string n = Console.ReadLine(), temp;
                char[] Nsplit = n.ToCharArray();
                Array.Reverse(Nsplit);
                temp = new string(Nsplit);
                if (string.Compare(temp, n) == 0) Console.WriteLine("YES");
                else Console.WriteLine("NO");
            }
        }
        static void Main()
        {
            while (true)
            {
                int N = int.Parse(Console.ReadLine());
                if (SOS(N)) Console.WriteLine("YES");
                else Console.WriteLine("NO");
            }
        }
        static bool SOS(int n)
        {
            int p = n;
            int k = 0;
            while (p != 0)
            {
                k = k * 10 + p % 10;
                p = (p - (p % 10))/10;
            }
            if (k == n) return true;
            else return false;
        }
    }
}
