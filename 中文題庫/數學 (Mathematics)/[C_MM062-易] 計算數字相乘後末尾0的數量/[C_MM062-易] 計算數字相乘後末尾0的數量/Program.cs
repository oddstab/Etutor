using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_MM062_易__計算數字相乘後末尾0的數量
{
    class Program
    {
        static void Main(string[] args)
        {
            string sum = "1", sub;
            int tot = 0;
            while (true)
            {
                try
                {
                    string n = Console.ReadLine();
                    sum = (decimal.Parse(sum) * decimal.Parse(n)).ToString();
                }
                catch
                {
                    break;
                }
            }
            for (int i = 1; ; i++)
            {
                sub = sum.Substring(sum.Length - i, 1);
                if (sub == "0") tot++;
                else break;
            }
            Console.WriteLine(tot);
        }
    }
}