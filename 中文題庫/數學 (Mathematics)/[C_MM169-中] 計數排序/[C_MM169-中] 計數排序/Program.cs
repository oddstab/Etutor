using System;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string[] s = Console.ReadLine().Split();
            int[] barrel = new int[10];
            if (string.Join("", s) == "000000") break;
            for (int i = 0; i < 6; i++)
                barrel[int.Parse(s[i])]++;
            Console.WriteLine(string.Join(" ", barrel) + " ");
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < barrel[i]; j++)
                    Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}