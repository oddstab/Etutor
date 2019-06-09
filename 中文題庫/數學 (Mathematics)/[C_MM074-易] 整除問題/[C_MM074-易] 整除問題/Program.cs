using System;
using System.Collections.Generic;

namespace _C_MM074_易__整除問題
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> totq = new List<int>();
            int n = int.Parse(Console.ReadLine());
            string num = "1".PadRight(n + 1, '0');
            for (int i = int.Parse(num.Substring(0, num.Length - 1)); i < int.Parse(num); i++)
                if (i % n == 0)
                    if (!Yesno(i.ToString())) totq.Add(rev(i));
            for (int i = 0; i < totq.Count; i++)
                for (int j = 1; j < totq.Count - i; j++)
                    if (totq[j - 1] > totq[j])
                    {
                        int temp = totq[j - 1];
                        totq[j - 1] = totq[j];
                        totq[j] = temp;
                    }

            for(int i = 0;i<totq.Count; i++)
                Console.WriteLine(rev(totq[i]).ToString().PadRight(n, '0'));
        }
        static bool Yesno(string m)
        {
            char[] ch = m.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
                for (int j = 0; j < ch.Length; j++)
                    if (i == j) continue;
                    else if (ch[i] == ch[j]) return true;
            return false;
        }
        static int rev(int x)
        {
            string temp = "", m = x.ToString();
            for (int i = x.ToString().Length - 1; i >= 0; i--)
                temp += m.Substring(i, 1);
            return int.Parse(temp);
        }
    }
}