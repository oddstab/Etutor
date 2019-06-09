using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
            Console.WriteLine(Regex.Matches(Convert.ToString(int.Parse(Console.ReadLine()),2),"1").Count);
    }
}