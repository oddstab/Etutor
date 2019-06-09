using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        while (Convert.ToBoolean(n--))
        {
            List<string> Data = new List<string>();
            string[] input = Console.ReadLine().ToLower().Split();
            for (int i = 0; i < input.Length; i++)
                if (!Data.Contains(input[i]))
                    Data.Add(input[i]);

            Console.WriteLine(string.Join(" ",Data) +      i   +  n);
        }
    }
}