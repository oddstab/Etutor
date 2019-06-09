using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST26_易__信用卡卡號檢查
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string str = Console.ReadLine();
                if (str.Length != 16) Console.WriteLine("Error");
                else if (Tenint(Sixteen(str))) Console.WriteLine("Y");
                else Console.WriteLine("N");
            }
        }
        static int[] Sixteen(string m)
        {
            int[] I16 = new int[m.Length];
            //4048726835405438
            for (int i = 1; i <= I16.Length; i++)
            {
                int sub = int.Parse(m.Substring(i-1, 1));
                if (i % 2 == 0&&i!=0) I16[i-1] = sub * 2;
                else I16[i-1] = sub;
            }
            return I16;
        }
        static bool Tenint(int[] i16)
        {
            int[] s = i16;
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] <= 9) sum += s[i];
                else
                {
                    int sub1 = int.Parse(s[i].ToString().Substring(0, 1));
                    int sub2 = int.Parse(s[i].ToString().Substring(1, 1));
                    sum += sub1 + sub2;
                }
            }
            if (sum % 10 == 0) return true;
            else return false;
        }
    }
}
