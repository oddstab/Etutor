using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<string> data = new List<string>();
        while (true)
        {
            try
            {
                string ip = Console.ReadLine();
                int.Parse(ip[0].ToString());
                data.Add(ip);
            }
            catch
            {
                break;
            }
        }
        string[] copy = data.ToArray();
        for (int i = 0; i < data.Count; i++)
            for (int j = 1; j < data.Count - i; j++)
            {
                int a = int.Parse(data[j - 1].Substring(data[j - 1].LastIndexOf(" ")));
                int b = int.Parse(data[j].Substring(data[j].LastIndexOf(" ")));
                if (a < b)
                {
                    string temp = data[j - 1];
                    data[j - 1] = data[j];
                    data[j] = temp;
                }
            }
        for (int i = 0; i < copy.Length; i++)
            Console.WriteLine(copy[i] + " " + (data.IndexOf(copy[i]) + 1));
    }
}