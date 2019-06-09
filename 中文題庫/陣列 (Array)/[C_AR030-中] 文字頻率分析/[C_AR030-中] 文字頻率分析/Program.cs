using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _C_AR030_中__文字頻率分析
{
    class Program
    {
        static string[] input;
        static void Main(string[] args)
        {
            List<string> word_list = new List<string>();
            List<string> pn_list = new List<string>();
            List<string> sn_list = new List<string>();
            List<string> word_sort = new List<string>();
            List<string> char_sort = new List<string>();
            string Pn = Console.ReadLine();
            string Sn = Console.ReadLine();
            int Cn = int.Parse(Console.ReadLine());
            int Wn = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            input = str.Split();

            //prefix;
            Console.WriteLine("prefix of {0}:", Pn);
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length >= Pn.Length)
                {
                    if (input[i].Substring(0, Pn.Length) == Pn && !pn_list.Contains(input[i]))
                    {
                        pn_list.Add(input[i]);
                        Console.WriteLine(input[i]);
                    }
                }
            }

            //suffix;
            Console.WriteLine("suffix of {0}:", Sn);
            for (int i = 0, cutlen; i < input.Length; i++)
            {
                if (input[i].Length >= Sn.Length)
                {
                    cutlen = input[i].Length - Sn.Length;
                    if (input[i].Substring(cutlen) == Sn && !sn_list.Contains(input[i]))
                    {
                        sn_list.Add(input[i]);
                        Console.WriteLine(input[i]);
                    }
                }
            }

            //character frequency over ; 
            Console.WriteLine("character frequency over {0}:", Cn);
            //lower
            for (int i = 97, c; i < 123; i++)
            {
                c = Regex.Matches(str, ((char)i).ToString()).Count;
                if (c >= Cn) char_sort.Add((char)i + "," + c);
            }
            //upper
            for (int i = 65, c; i < 91; i++)
            {
                c = Regex.Matches(str, ((char)i).ToString()).Count;
                if (c >= Cn) char_sort.Add((char)i + "," + c);
            }
            BubbleSort(char_sort);
            Console.WriteLine("word frequency over {0}:", Wn);
            //word frequency over ;
            for (int i = 0; i < input.Length; i++)
            {
                int c = 0;
                if (!word_list.Contains(input[i]))
                {
                    word_list.Add(input[i]);
                    for (int j = 0; j < input.Length; j++)
                    {
                        if (input[i] == input[j]) c++;
                    }
                }
                if (c >= Wn)
                {
                    word_sort.Add(input[i] + "," + c);
                }
            }
            BubbleSort(word_sort);
        }
        static void BubbleSort (List<string> s)
        {
            for(int i = 0;i<s.Count; i++)
            {
                for(int j = 1;j<s.Count-i; j++)
                {
                    string c1 = s[j - 1].Substring(0, s[j - 1].IndexOf(","));
                    string c2 = s[j].Substring(0, s[j].IndexOf(","));
                    if (string.Compare(c1,c2)>0)
                    {
                        string temp = s[j - 1];
                        s[j - 1] = s[j];
                        s[j] = temp;
                    }
                }
            }
            for(int i = 0;i<s.Count; i++)
            {
                Console.WriteLine(s[i]);
            }
        }
    }
}