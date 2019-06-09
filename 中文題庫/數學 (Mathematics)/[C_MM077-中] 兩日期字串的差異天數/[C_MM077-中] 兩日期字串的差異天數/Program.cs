using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Math.Abs((DateTime.Parse(Console.ReadLine()) - DateTime.Parse(Console.ReadLine())).Days));
    }
}