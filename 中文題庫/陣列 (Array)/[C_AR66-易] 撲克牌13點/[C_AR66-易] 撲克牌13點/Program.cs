using System;
class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        string[] input = Console.ReadLine().Split();
        for (int i = 0;i<input.Length; i++)
        {
            if (input[i] == "A") sum += 14;
            else if (input[i] == "J") sum += 11;
            else if (input[i] == "Q") sum += 12;
            else if (input[i] == "K") sum += 13;
            else sum += int.Parse(input[i]);
        }
        Console.WriteLine(sum);
    }
}