using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        List<string> data = new List<string>();
        string temp =str[0].ToString();
        for (int i = 1; i < str.Length; i++)
        {
            if (str[i]==temp[0])
            {
                temp += str[i].ToString();
            }
            else
            {
                data.Add(temp);
                Console.WriteLine(temp);
                temp = str[i].ToString();
            }
        }
    }
}