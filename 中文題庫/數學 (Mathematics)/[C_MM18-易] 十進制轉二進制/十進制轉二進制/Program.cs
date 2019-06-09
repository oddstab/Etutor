using System;

namespace 位元計數器
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int q = 0; bool negint = false;
                string tot2 = "";
                int n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    n = Math.Abs(n) - 1;
                    negint = true;
                }
                while (tot2.Length != 8)
                {
                    q = n % 2;
                    tot2 += q = negint ? (q == 0 ? 1 : 0) : q;
                    n = n / 2;
                }
                char[] strres = tot2.ToCharArray();
                Array.Reverse(strres);
                tot2 = new string(strres);
                Console.WriteLine(tot2);
            }           
        }
    }
}