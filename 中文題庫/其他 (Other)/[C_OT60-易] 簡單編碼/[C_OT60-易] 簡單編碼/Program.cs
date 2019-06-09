using System;
class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        Console.WriteLine("{0} {1} Transmit OK", int.Parse(input[0]) ^ int.Parse(input[1]), input[1]);
    }
}