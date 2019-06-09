using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()), f = 1, f1 = 0, fn = 0;
        for (int i = 0; i <= n; i++)
        {
            Console.Write(fn+(i==n?"\n":","));
            fn = f + f1;
            f = f1;
            f1 = fn;
        }
    }
}