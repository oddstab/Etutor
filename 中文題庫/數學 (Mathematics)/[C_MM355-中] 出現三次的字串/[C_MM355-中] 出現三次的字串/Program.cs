using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] d = new string[n];
        for (int i = 0; i < n; i++)
            d[i] = Console.ReadLine();
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = 0; j < n; j++)
                if (d[i] == d[j])
                    sum++;
            if (sum == 3)
            {
                Console.WriteLine(d[i]);
                break;
            }
        }
    }
}