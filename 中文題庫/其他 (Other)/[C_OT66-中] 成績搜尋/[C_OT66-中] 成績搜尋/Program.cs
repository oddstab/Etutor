using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> data = new List<int>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
            data.Add(int.Parse(Console.ReadLine()));
        data.Sort(); Console.WriteLine(data[n - 1]);
    }
}