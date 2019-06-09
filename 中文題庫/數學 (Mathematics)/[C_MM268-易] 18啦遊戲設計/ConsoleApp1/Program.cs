using System;

class Program
{
    static void Main(string[] args)
    {
        int[] index = new int[4] { 1, 1, 1, 1 };
        int temp = 1, max = 0;
        int[] d = new int[4];
        for (int i = 0; i < 4; i++)
            d[i] = int.Parse(Console.ReadLine());
        Array.Sort(d);
        for (int i = 1; i < 4; i++)
        {
            if (d[i] == d[i - 1])
                temp++;
            else
                temp = 1;
            index[i] = temp;

            if (max < index[i])
                max = index[i];
        }
        bool win = max == 4;
        bool r = max == 3 || max == 1;
        int ans = 0;
        if (max == 2)
        {
            if (index[1] == index[3] && index[1] == max) ans = d[2] * 2;
            else
            {
                for (int i = 0; i < 4; i++)
                    ans += d[i];
                for (int i = 0; i < 4; i++)
                    if (index[i] == max)
                        ans -= d[i] * 2;
            }
        }
        if (win) Console.WriteLine("WIN");
        else if (r) Console.WriteLine("R");
        else Console.WriteLine(ans);
    }
}