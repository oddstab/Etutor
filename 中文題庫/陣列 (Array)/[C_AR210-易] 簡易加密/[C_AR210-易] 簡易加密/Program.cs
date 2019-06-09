using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            char t = Console.ReadLine()[0];
            Console.WriteLine((char)(t + 2));
        }
    }
}
