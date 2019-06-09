using System;
class Program
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        if (str.Contains("-") || char.IsNumber(str[0])) Console.WriteLine("illegal");
        else Console.WriteLine("legal");
    }
}