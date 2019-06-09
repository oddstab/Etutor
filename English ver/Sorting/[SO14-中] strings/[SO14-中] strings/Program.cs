using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<string> Udata = new List<string>();
        List<string> Ldata = new List<string>();
        while (true)
        {
            string str = Console.ReadLine();
            if (str == null) break;
            else
            {
                if (char.IsLower(str[0])) Ldata.Add(str);
                else Udata.Add(str);
            }
        }
        Sort(Udata);Sort(Ldata);
        for (int i = 0; i < Udata.Count; i++) Console.WriteLine(Udata[i]);
        for (int i = 0; i < Ldata.Count; i++) Console.WriteLine(Ldata[i]);
    }
    static void Sort(List<string> data)
    {
        for (int i = 0; i < data.Count; i++)
            for (int j = 1; j < data.Count - i; j++)
            {
                if (string.Compare(data[j - 1], data[j]) > 0)
                {
                    string temp = data[j - 1];
                    data[j - 1] = data[j];
                    data[j] = temp;
                }
            }
    }
}