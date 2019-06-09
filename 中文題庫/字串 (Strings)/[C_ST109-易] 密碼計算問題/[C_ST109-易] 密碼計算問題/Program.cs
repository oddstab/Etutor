using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        char[] ip = Console.ReadLine().ToArray();
        for (int i = 0; i < ip.Length - 1; i++)
        {
            string max = ip[i] > ip[i + 1] ? ip[i] - ip[i + 1] + "" : ip[i + 1] - ip[i] + "";
            Console.Write(max.Length > 1 ? max[1].ToString() : max);
        }
        Console.WriteLine();
    }
}