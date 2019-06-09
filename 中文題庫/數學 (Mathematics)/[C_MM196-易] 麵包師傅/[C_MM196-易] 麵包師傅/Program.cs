using System;
class Program
{
    static void Main(string[] args)
    {
        string[] s = Console.ReadLine().Split();
        Console.WriteLine(Math.Floor(double.Parse(s[0])/double.Parse(s[1])));
    }
}