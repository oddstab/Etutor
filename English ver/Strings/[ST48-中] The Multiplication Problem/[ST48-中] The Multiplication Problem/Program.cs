using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int h = 0; h < n; h++)
            Console.WriteLine(decimal.Parse(Console.ReadLine()) * decimal.Parse(Console.ReadLine()));
    }
}