using System;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int m = int.Parse(input[0]), n = int.Parse(input[1]);
        int[,] disarr = new int[n, m];
        if (input.Length < 4)
        {
            for (int i = 0; i < int.Parse(input[2]); i++)
            {
                string[] temp = Console.ReadLine().Split();
                disarr[int.Parse(temp[1]), int.Parse(temp[0])] = int.Parse(temp[2]);
            }
            Console.WriteLine(m + " " + n);
            print(disarr);
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                string[] temp = Console.ReadLine().Split();
                for (int j = 0; j < m; j++)
                    disarr[i, j] = int.Parse(temp[j]);
            }
            Console.WriteLine(m + " " + n);
            print(disarr);
        }
    }
    static void print(int[,] mm)
    {
        for (int i = 0; i < mm.GetLength(0); i++)
        {
            for (int j = 0; j < mm.GetLength(1); j++)
                Console.Write(mm[i, j] + (j != mm.GetLength(1) - 1 ? " " : ""));
            Console.WriteLine();
        }
    }
}