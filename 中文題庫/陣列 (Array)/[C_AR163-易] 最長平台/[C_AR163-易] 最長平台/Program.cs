using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            List<int> data = new List<int>();
            Console.ReadLine();
            string input = Console.ReadLine().Replace(" ", "");
            for (int i = 1, c = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1]) c++;
                else
                {
                    data.Add(c);
                    c = 1;
                }
            }
            data.Sort(); Console.WriteLine(data[data.Count - 1]);
        }        
    }
}