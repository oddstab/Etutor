using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        while (Convert.ToBoolean(n--))
            Console.WriteLine("Tokens found:\n"+string.Join("\n", Console.ReadLine().Split(';', ',', ':')));
    }
}