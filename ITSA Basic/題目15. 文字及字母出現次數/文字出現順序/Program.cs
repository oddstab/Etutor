using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace 文字出現順序
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string IP = Console.ReadLine();
                List<string> Eng_str = new List<string>();
                List<int> Eng_count = new List<int>();
                int len = 0;
                for (int i = 0; ; i++)
                {
                    if (len == IP.Length) break;
                    string sub = IP.Substring(i, 1);
                    int abc_count = Regex.Matches(IP, sub).Count;
                    char Csub = Convert.ToChar(sub);
                    
                    if (!((Csub>=65 && Csub<=90)||(Csub >= 61 && Csub<=122)))
                    {
                        len++;
                        continue;
                    }
                    if (Eng_str.Contains(sub)) continue;
                    len += abc_count;
                    Eng_str.Add(sub);
                    Eng_count.Add(abc_count);
                    
                }

                //Bubble Sort
                int temp;
                string tempn;
                for (int i = 1; i < Eng_str.Count; i++)//sorting
                {
                    for (int j = 1; j <= Eng_str.Count - i; j++)
                    {
                        if (string.Compare(Eng_str[j - 1], Eng_str[j]) > 0)
                        {
                            temp = Eng_count[j];
                            Eng_count[j] = Eng_count[j - 1];
                            Eng_count[j - 1] = temp;

                            tempn = Eng_str[j];
                            Eng_str[j] = Eng_str[j - 1];
                            Eng_str[j - 1] = tempn;
                        }
                    }
                }
                Console.WriteLine(IP.Split(' ').Length);//display 4 

                for (int i =0;i<Eng_str.Count; i++)
                {
                    Console.WriteLine(Eng_str[i] + " : " + Eng_count[i]);
                }
            }
        }

    }
}
