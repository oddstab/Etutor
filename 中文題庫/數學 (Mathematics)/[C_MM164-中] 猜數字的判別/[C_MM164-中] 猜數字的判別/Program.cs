using System;
class Program
{
    static void Main(string[] args)
    {
        int A = 0, B = 0;
        string ans = Console.ReadLine();
        string temp = Console.ReadLine();
        for (int i = 0; i < 4; i++)
        {
            if (ans.IndexOf(temp[i]) != -1)
            {
                if (temp.IndexOf(temp[i]) == ans.IndexOf(temp[i]))
                    A++;
                else B++;
            }
        }
        Console.WriteLine("{0}a{1}b", A, B);
    }
}