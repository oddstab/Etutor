using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        char[] input = Console.ReadLine().ToArray();
        for (int i = 0; i < input.Length; i++)
            if (!char.IsNumber(input[i])) input[i] = ' ';
        string str = new string(input);
        while (str.IndexOf("  ") != -1)
            str = str.Replace("  ", " ");
        for (int i = 0;i<str.Trim().Split().Length; i++)
            sum += int.Parse(str.Trim().Split()[i]);
        Console.WriteLine(sum);
    }
}