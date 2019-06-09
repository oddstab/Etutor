using System;
class Program
{
    static void Main(string[] args)
    {
        Console.ReadLine();
        string[] input = Console.ReadLine().Split();
        int sum = 0;
        for (int i = 0; i < input.Length; i++)
            sum += int.Parse(input[i]);
        if (sum % 2 == 0) Console.WriteLine("YES");
        else Console.WriteLine("NO");
    }
}