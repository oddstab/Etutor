using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<string> d = new List<string>();
        int sum = 0;
        while (true)
        {
            string s = Console.ReadLine();
            if (s == "end") break;
            sum += int.Parse(s.Split()[1]);
            d.Add(s);
        }
        for (int i = 0; i < d.Count; i++)
            Console.WriteLine("{0}({1:0.00})", d[i].Split()[0], double.Parse(d[i].Split()[1]) / sum);
    }
}