using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()),max = 0;
        int[] date = new int[25];
        string[] input = Console.ReadLine().Split();
        for (int i = 0,a=0; i < n; i++,a+=2)
            for (int j = int.Parse(input[a]);j<int.Parse(input[a+1]) ;j++)
                date[j]++;
        for (int i = 0; i < 25; i++)
            max = Math.Max(max, date[i]);
        Console.WriteLine(max);
    }
}