using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string str = "";
            int n = int.Parse(Console.ReadLine());
            string[] Usc = new string[n];//NSYSU NC CT NS NM           
            for (int a = 0; a < n; a++) Usc[a] = Console.ReadLine();

            n = int.Parse(Console.ReadLine());
            string[] Search = new string[n];//(BC NS)+(CT HL)
            for (int a = 0; a < n; a++) Search[a] = Console.ReadLine();

            string[] Split_seacrh;
            for (int i = 0; i < Search.Length; i++)
            {
                Split_seacrh = Search[i].Split('+');
                str = "";
                for (int j = 0; j < Usc.Length; j++)
                {
                    if (FanSplit(Split_seacrh, Usc[j])) str += Usc[j].Substring(0, Usc[j].IndexOf(" ")) + " ";
                }
                Console.WriteLine(str.TrimEnd(' '));
            }
        }
    }
    static bool FanSplit(string[] Search, string First)
    {
        string[] SP;
        string[] School = First.Split(' ');
        //School[0] = null;
        int len = 0;
        bool y = true;

        for (int q = 0; q < Search.Length; q++)
        {
            y = true;
            SP = Search[q].Split(' ');
            len = SP.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = 1; j < School.Length; j++)
                {
                    if (School.Contains(SP[i])) break;
                    y = false;
                    if (!y) break;
                }
                if (!y) break;
            }
            if (y) break;
        }
        return y;
    }
}