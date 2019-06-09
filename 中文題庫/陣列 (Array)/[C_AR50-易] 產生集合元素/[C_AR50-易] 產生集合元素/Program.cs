using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<int> data = new List<int>();
        data.Add(1);
        for (int i = 0;i<n*2; i++)
        {
            if (!data.Contains(data[i] * 2 + 1))
                data.Add(data[i]*2+1);
            if (!data.Contains(data[i] * 3 + 1))
                data.Add(data[i] * 3 + 1);
        }
        data.Sort();
        for (int i = 0; i < n; i++)
            Console.WriteLine(data[i]);
    }
}