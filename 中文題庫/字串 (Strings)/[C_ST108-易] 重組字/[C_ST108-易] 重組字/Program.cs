using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string str = Console.ReadLine().ToLower().Replace(" ", "");
            char[] a = str.Split('-')[0].ToArray();
            char[] b = str.Split('-')[1].ToArray();
            Array.Sort(a); Array.Sort(b);
            if (Enumerable.SequenceEqual(a,b)) Console.WriteLine("true");
            else Console.WriteLine("false");
        }
    }
}