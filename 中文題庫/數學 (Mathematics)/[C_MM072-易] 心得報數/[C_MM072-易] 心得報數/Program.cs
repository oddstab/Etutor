using System;

namespace _C_MM072_易__心得報數
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            for (int g = 0; g < s; g++)
            {
                int N = int.Parse(Console.ReadLine());
                int k = int.Parse(Console.ReadLine()), i, nth = 0, kick = N;
                int[] tot = new int[N];
                for (i = 0; kick != 1; nth++)
                {
                    if (nth == N) nth = 0;
                    if (tot[nth] == 0) i++;
                    if (i == k)
                    {
                        tot[nth] = 1;
                        kick--;
                        i = 0;
                    }
                }
                for (i = 0; i < N; i++)
                    if (tot[i] == 0)
                        Console.WriteLine(i+1);
            }
        }
    }
}