using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _C_AR025_易__計算ASCII字元
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string IP = Console.ReadLine();
                int len = 0;
                List<string> Data = new List<string>();
                for (int i = 0; len != IP.Length; i++)
                {
                    int sub = Convert.ToChar(IP.Substring(i, 1));
                    int Test = Regex.Matches(IP, sub.ToString()).Count;
                    if (Data.Contains(sub + " " + Test))continue;
                    len += Regex.Matches(IP, sub.ToString()).Count;
                    Data.Add(sub + " " + Test);
                }
                //bubble sort
                //654 2
                for (int i = 0; i < Data.Count; i++)
                {
                    for (int j = 1; j < Data.Count - i; j++)
                    {
                        int j1 = int.Parse(Data[j].Substring(0, Data[j].IndexOf(" ")));
                        int j2 = int.Parse(Data[j - 1].Substring(0, Data[j - 1].IndexOf(" ")));
                        string temp;
                        if (j1 > j2)
                        {
                            temp = Data[j];
                            Data[j] = Data[j - 1];
                            Data[j - 1] = temp;
                        }
                    }
                }
                foreach(string s in Data)
                {
                    Console.Write(s + "\n");
                }
            }
        }
    }
}
