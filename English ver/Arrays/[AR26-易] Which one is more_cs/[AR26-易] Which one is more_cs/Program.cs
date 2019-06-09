using System;
class Program
{
    static void Main(string[] args)
    {
        string[] ip = Console.ReadLine().Split();
        int[] c = { 0, 0, 0 };
        for (int i = 0; i < int.Parse(ip[0]); i++)
        {
            string[] temp = Console.ReadLine().Split();
            for (int j = 0; j < temp.Length; j++)
            {
                if (temp[j] == "0") c[0]++;
                else if (temp[j] == "1") c[1]++;
                else c[2]++;
            }
        }
        Console.WriteLine(c[0] > c[1] && c[0] > c[2] ? 0 : c[1] > c[0] && c[1] > c[2] ? 1 : 2);
    }
}