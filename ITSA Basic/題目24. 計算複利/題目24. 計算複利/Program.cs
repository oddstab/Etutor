using System;
class Program
{
    static void Main(string[] args)
    {
        decimal r = decimal.Parse(Console.ReadLine()), n = decimal.Parse(Console.ReadLine()), p = decimal.Parse(Console.ReadLine()), sum = 0;
        for (decimal i = 0; i < n; i++)
            sum += p + (sum + p) * r;
        Console.WriteLine((ulong)sum);
    }
}