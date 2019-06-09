using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string input = Console.ReadLine(), temp = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ' && input[i] != ',' && input[i] != '.')
                {
                    if (char.IsLower(input[i]))
                        temp += char.ToUpper(input[i]);
                    else
                        temp += char.ToLower(input[i]);
                }
                else
                {
                    char[] x = temp.ToArray();
                    Array.Reverse(x);
                    Console.Write(new string(x));
                    temp = "";
                }
                if (input[i] == ' ' || input[i] == ',' || input[i] == '.')
                    Console.Write(input[i]);
            }
            Console.WriteLine();
        }
    }
}