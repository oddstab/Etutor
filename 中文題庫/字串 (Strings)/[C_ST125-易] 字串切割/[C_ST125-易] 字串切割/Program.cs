using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int g = 0; g < n; g++)
        {
            string str = Console.ReadLine();
            if (str is null) Console.WriteLine(123);
            string[] ip = str.Split(';', ',', ':');
            Console.WriteLine("Original string: " + str+"\nTokens found:");
            for (int i = 0; i < ip.Length; i++)
                Console.WriteLine(ip[i]);
        }
    }
}