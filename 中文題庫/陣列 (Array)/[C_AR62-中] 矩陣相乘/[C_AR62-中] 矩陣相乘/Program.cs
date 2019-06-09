using System;
class program
{
    static string[] mn = Console.ReadLine().Split(), s;
    static void Main(string[] args)
    {
        int[,] first = new int[int.Parse(mn[0]), int.Parse(mn[1])], second, result;
        input_matrix(first,mn[0]);
        int fm = int.Parse(mn[0]);
        mn = Console.ReadLine().Split();//第二個矩陣
        second = new int[int.Parse(mn[0]), int.Parse(mn[1])];
        result = new int[fm, int.Parse(mn[1])];
        input_matrix(second,mn[0]);
        for (int i = 0; i < int.Parse(mn[1]); i++)
            for (int j = 0, tot = 0; j < int.Parse(mn[1]); j++, tot = 0)
            {
                for (int k = 0; k < int.Parse(mn[0]); k++)
                    tot += first[i, k] * second[k, j];
                result[i, j] = tot;
            }
        for (int i = 0; i < int.Parse(mn[1]); i++)
            for (int j = 0; j < int.Parse(mn[1]); j++)
                Console.Write(result[i, j] + (j != int.Parse(mn[1]) - 1 ? " ":"\n"));
    }
    static void input_matrix(int[,] first,string m)
    {
        for (int i = 0; i < int.Parse(m); i++)
        {
            s = Console.ReadLine().Split();
            for (int j = 0; j < s.Length; j++)
                first[i, j] = int.Parse(s[j]);
        }
    }
}