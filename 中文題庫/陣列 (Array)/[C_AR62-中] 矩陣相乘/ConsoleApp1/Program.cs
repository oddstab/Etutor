using System;
class Program
{
    static void Main(string[] args)
    {
        string[] s = Console.ReadLine().Split();
        int a = int.Parse(s[0]);
        int b = int.Parse(s[1]);
        int[,] arr = new int[a, b], ary, ans;
        for (int i = 0; i < a; i++)
        {
            s = Console.ReadLine().Split();
            for (int j = 0; j < b; j++)
                arr[i, j] = int.Parse(s[j]);
        }
        s = Console.ReadLine().Split();
        int x = int.Parse(s[0]);
        int y = int.Parse(s[1]);
        ary = new int[x, y];
        for (int i = 0; i < x; i++)
        {
            s = Console.ReadLine().Split();
            for (int j = 0; j < y; j++)
                ary[i, j] = int.Parse(s[j]);
        }
        ans = new int[a, y];
        for (int i = 0; i < a; i++)
        {//控制列(第一個陣列)
            for (int j = 0; j < y; j++)
            {//控制行(第二個陣列)
                int num = 0;
                for (int k = 0; k < b; k++)
                {//每個元素(第一個陣列的左到右,第二個陣列上到下)
                    num += arr[i, k] * ary[k, j];
                }
                ans[i, j] = num;
            }
        }
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < y; j++)
            {
                if (j != 0)
                    Console.Write(" ");
                Console.Write(ans[i, j]);
            }
            Console.WriteLine();
        }
    }
}