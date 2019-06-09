using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Node Key Name");
        string d = "";
        for (int i = 1; ; i++)
        {
            string[] s = Console.ReadLine().Split();
            if (s[0] == "-1") break;
            d += i + " " + string.Join(" ", s) + "\n";
        }
        Console.Write(d);
    }
}