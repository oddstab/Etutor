using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_MM153_易__非十進位加法
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            string str = "";
            int C10 = seven(A.ToString()) + seven(B.ToString());
            while (C10 != 0)
            {
                str+=C10%7;
                C10 /= 7;
            }
            char[] C = str.ToCharArray();
            Array.Reverse(C);
            Console.WriteLine(new string(C));
        }
        static int seven(string x)
        {
            int sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                int sub = int.Parse(x.Substring(x.Length - 1 - i, 1));
                sum += (int)Math.Pow(7, i) * sub;
            }
            return sum;
        }
    }
}