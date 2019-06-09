using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_CH09_易__利用振幅和頻率計算波
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int g = 0; g < n; g++)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                string str = PO(a);
                for (int i = 0; i < b; i++)
                {
                    if (i != b - 1) Console.WriteLine(str);
                    else Console.WriteLine(str.TrimEnd('\n'));                   
                }
                if (g != n - 1) Console.WriteLine();
            }
        }
        static string PO(int a)
        {
            bool sm = true;
            string str = "";
            int len = a + (a - 1);
            for (int i = 1, b = 1; i <= len; i++)
            {
                for (int j = 1; j <= b; j++)
                {
                    str += b;
                }
                str += "\n";
                if (b >= a) sm = false;
                if (sm) b++;
                else b--;
            }
            return str;
        }
    }
}