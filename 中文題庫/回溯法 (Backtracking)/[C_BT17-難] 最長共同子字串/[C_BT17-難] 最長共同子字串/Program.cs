using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<string> substr = new List<string>();
        string Max = "";
        string str1 = "agcat";
        string str2 = "gac";
        for (int i = 0; i < str1.Length; i++)
        {
            string temp1 = str1.Substring(i);
            for (int j = temp1.Length - 1; j >= 0; j--)
            {
                string temp2 = temp1.Substring(0, j);
                Console.WriteLine(temp2);
                if (str2.IndexOf(temp2) != -1 && temp2.Length >= Max.Length)
                {
                    Max = temp2;
                    substr.Add(Max);
                }
            }
        }
        Console.WriteLine(Max);
    }
}