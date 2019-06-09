using System;
class Program
{
    static void Main(string[] args)
    {
        for (int i = 0, n = int.Parse(Console.ReadLine()); i < n; i++)
        {
            int sum = 0;
            char[] input = Console.ReadLine().ToCharArray();
            foreach(int item in input)
                sum += item;
            Console.WriteLine(sum);
        }
    }
}