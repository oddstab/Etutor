using System;
class Program
{
    static void Main(string[] args)
    {
        string[] s = Console.ReadLine().Split(',');
        Console.WriteLine(distance(s[0], s[1]));
    }
    static int distance(string w1, string w2)
    {
        int len1 = w1.Length, len2 = w2.Length;
        int[,] dp = new int[len1 + 1, len2 + 1];
        for (int i = 0; i <= len1; i++)
            dp[i, 0] = i;
        for (int i = 0; i <= len2; i++)
            dp[0, i] = i;
        for (int i = 1; i <= len1; i++)
            for (int j = 1; j <= len2; j++)
            {
                int delta = w1[i - 1] == w2[j - 1] ? 0 : 1;
                dp[i, j] = Math.Min(dp[i - 1, j - 1] + delta, Math.Min(dp[i - 1, j] + 1, dp[i, j - 1] + 1));
            }
        return dp[len1, len2];
    }
}