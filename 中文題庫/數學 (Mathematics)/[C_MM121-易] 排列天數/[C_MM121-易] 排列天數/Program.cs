using System;
class Program
{
    static void Main(string[] args)
    {
        string[] ip = Console.ReadLine().Split();
        int day = int.Parse(ip[0]);
        int start = int.Parse(ip[1]);
        for (int i = 1, d = 1, c = 1; i <= day; d++, c++)
        {
            if (c < start) Console.Write("\t");
            else
            {
                Console.Write(i + (d != 7 ? "\t" : ""));
                i++;
            }
            if (d == 7)
            {
                d = 0;
                Console.WriteLine();
            }
        }
        Console.WriteLine();
    }
}