using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST51_難__文章資訊統計
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Data = new List<string>();
            char[] Cs = Console.ReadLine().Trim('"').ToCharArray();
            string Str = Console.ReadLine().ToLower();
            string[] Spip = Str.Split(Cs);
            int len = 0;
            for (int i = 0; len != Spip.Length; i++)
            {
                int temp = 0;
                if (Spip[i] == "" || Spip[i] == " ") { len++; continue; }
                string t = Spip[i];
                for (int j = 0; j < Spip.Length; j++)
                {
                    if (t == Spip[j])
                    {
                        temp++;
                        Spip[j] = "";
                    }
                }
                Data.Add(t + " = " + temp);
                len += temp;
            }

            string[] Total = Data.ToArray();
            for (int i = 0; i < Total.Length; i++)
            {
                for (int j = 1; j < Total.Length - i; j++)
                {
                    int a = int.Parse(Total[j - 1].Substring(Total[j - 1].IndexOf(" = ") + 2));
                    int b = int.Parse(Total[j].Substring(Total[j].IndexOf(" = ") + 2));
                    if (a < b) Swap(Total, j - 1, j);
                    else if (a == b)
                    {
                        string A = Total[j - 1].Substring(0, Total[j - 1].IndexOf(" = "));
                        string B = Total[j].Substring(0, Total[j].IndexOf(" = "));
                        if (string.Compare(A, B) > 0) Swap(Total, j - 1, j);
                    }
                }
            }
            for (int i = 0; i < 3; i++) Console.WriteLine(Total[i]);
            Console.Read();
        }
        static void Swap(string[] T, int a, int b)
        {
            string S = T[a];
            T[a] = T[b];
            T[b] = S;
        }
    }
}