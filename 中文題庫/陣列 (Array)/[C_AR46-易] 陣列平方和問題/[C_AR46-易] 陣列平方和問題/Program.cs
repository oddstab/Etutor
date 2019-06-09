using System;
class Program
{
    // Wrong
    static void Main(string[] args)
    {
        decimal sum = 0;
        string[] input = Console.ReadLine().Trim().Split();
        for (int i = 0; i < input.Length; i++)
            sum += decimal.Parse(input[i]) * decimal.Parse(input[i]);
        Console.WriteLine("{0:0.000000}",sum);
    }
}