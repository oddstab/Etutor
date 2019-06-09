using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        string str = "", ip;
        while (true)
        {
            ip = Console.ReadLine();
            if (ip == null) break;
            str += " " + ip;
        }
        List<string> word = new List<string>(),w2 = new List<string>();
        string[] s = str.Trim().Split();
        foreach (string d in s)
        {
            int sum = 0;
            foreach (string e in s)
                if (d == e) sum++;
            if (!word.Contains(d + " " + sum))
                word.Add(d + " " + sum);
        }
        for (int i = 0; i < word.Count; i++)
            for (int j = 1; j < word.Count - i; j++)
            {
                int a =int.Parse(word[j-1].Substring(word[j - 1].IndexOf(" ")));
                int b = int.Parse(word[j].Substring(word[j].IndexOf(" ")));
                if (a > b)
                {
                    string temp = word[j - 1];
                    word[j - 1] = word[j];
                    word[j] = temp;
                }
                else if (a==b&& string.Compare(word[j - 1], word[j]) > 0)
                {
                    string temp = word[j - 1];
                    word[j - 1] = word[j];
                    word[j] = temp;
                }
            }
                
                
        for (int i = 0; i < word.Count; i++)
            if (!char.IsLower(word[i][0]))
                w2.Add(word[i]);
        for (int i = 0; i < word.Count; i++)
            if (char.IsLower(word[i][0]))
                w2.Add(word[i]);
        for (int i = 0; i < w2.Count; i++)
            Console.WriteLine((i+1)+":"+w2[i]);
    }
}