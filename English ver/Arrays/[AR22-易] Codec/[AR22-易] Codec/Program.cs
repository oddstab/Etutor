using System;
class Program
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        for (int i = 0; i < str.Length; i++)
            Console.Write((char)( str[i] - 3 ));
        Console.WriteLine();
    }
}