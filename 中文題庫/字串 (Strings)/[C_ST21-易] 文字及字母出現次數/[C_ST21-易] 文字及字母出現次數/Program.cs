using System;
class Program
{
    static void Main(string[] args)
    {
        int[] abc = new int[26], ABC = new int[26];
        string ip = Console.ReadLine().Replace(", ", " ").Replace(", ", " ");
        Console.WriteLine(ip.Split().Length);
        for (int i = 0; i < ip.Length; i++)
        {
            char x = Convert.ToChar(ip.Substring(i, 1));
            if (char.IsLower(x)) abc[x - 'a']++;
            if (char.IsUpper(x)) ABC[x - 'A']++;
        }
        for (int i = 0; i < 26; i++)
        {
            if (abc[i] != 0) Console.WriteLine(((char)(i + 'a')) + " : " + abc[i]);
            if (ABC[i] != 0) Console.WriteLine(((char)(i + 'A')) + " : " + ABC[i]);
        }
    }
}