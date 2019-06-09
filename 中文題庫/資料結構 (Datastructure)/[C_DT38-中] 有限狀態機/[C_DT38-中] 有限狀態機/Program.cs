using System;
class Program
{
    static void Main(string[] args)
    {
        string[] s = Console.ReadLine().Replace("  "," ").Split();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ".") break;
            try
            {
                int.Parse(s[i]);
                Console.WriteLine(s[i]+" - number");
            }
            catch
            {
                Console.WriteLine(s[i] + " - identifier");
            }
        }
    }
}