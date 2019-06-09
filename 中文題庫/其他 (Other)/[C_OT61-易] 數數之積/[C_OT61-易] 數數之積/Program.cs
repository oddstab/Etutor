using System;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            decimal sum = 1;
            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < input.Length; i++)
                sum *= decimal.Parse(input[i]);
            Console.WriteLine(sum);
        }
    }
}