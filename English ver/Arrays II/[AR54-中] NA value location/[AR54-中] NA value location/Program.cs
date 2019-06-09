using System;
class Program
{
    static void Main(string[] args)
    {
        string[] s = Console.ReadLine().Split();
        int sum = 0;
        string dis = "";
        for (int i = 0; i < s.Length; i++)
            if (s[i] == "NA") {
                dis+=i+"\n";
                sum++;
            }
        Console.WriteLine(sum+"\n"+dis.TrimEnd('\n'));
    }
}