using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {        
        try
        {
            string[] input = Console.ReadLine().Split();
            List<string> element = new List<string>();
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int c0 = 0;
            string[,] data = new string[m, n];
            for (int i = 0; i < n; i++)
            {
                string[] temp = Console.ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    if (temp[j] == "0") c0++;
                    else element.Add(j + " " + i + " " + temp[j]);
                    data[j, i] = temp[j];
                }
            }
            if (c0 >= m * n / 3 * 2)
            {
                Console.WriteLine(m + " " + n + " " + (m * n - c0));
                for (int i = 0; i < element.Count; i++)
                    Console.WriteLine(element[i]);
            }
            else
            {
                Console.WriteLine(m + " " + n + " " + (m * n - c0) + " -1");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                        Console.Write(data[j, i] + (j != m - 1 ? " " : ""));
                    Console.WriteLine();
                }
            }
        }
        catch
        {
            System.Threading.Thread.Sleep(1800);
        }
    }
}