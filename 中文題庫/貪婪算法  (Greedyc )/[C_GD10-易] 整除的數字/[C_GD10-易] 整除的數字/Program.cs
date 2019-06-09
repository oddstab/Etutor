using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> data = new List<string>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 10000; i < 100000; i++)
        {
            for (int j = 1000; j < 100000; j++)
                if (i / j == n) data.Add(i + " / " + j.ToString().PadLeft(5, '0') + " = " + n);
        }
        for (int i = 0; i < data.Count; i++)
            Console.WriteLine(data[i]);
    }
}