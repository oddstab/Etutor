using System;
class Program
{
    static Random rn = new Random();
    static void Main(string[] args)
    {
        Console.WriteLine(rn.Next(2));
        Console.ReadKey();
    }
}