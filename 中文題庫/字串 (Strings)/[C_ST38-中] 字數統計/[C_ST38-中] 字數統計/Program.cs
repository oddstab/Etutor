using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST38_中__字數統計
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string ip = Console.ReadLine();
                string[] Split = new string[ip.Length];
                string str = ""; char sub = ' ';
                List<string> Q = new List<string>();
                for (int i = 0, a = 0; i < ip.Length; i++)
                {
                    sub = Convert.ToChar(ip.Substring(i, 1));
                    if ((sub >= 65 && sub <= 90) || (sub >= 97 && sub <= 122) || (sub >= 48 && sub <= 57))
                    {
                        str += sub.ToString();
                        if (i != ip.Length - 1) continue;
                    }
                    if (str == "") continue;
                    Split[a] = str;
                    str = "";
                    a++;
                }
                int TotalQ = 0;
                for (int i = 0; i < Split.Length; i++)
                {
                    if (Split[i] == null) break;
                    if (Q.Contains(Split[i].ToUpper())) continue;
                    Q.Add(Split[i].ToUpper());
                    for (int j = 0; j < Split.Length; j++)
                    {
                        if (Split[j] == null) break;
                        if (Split[i].ToUpper() == Split[j].ToUpper()) TotalQ++;
                    }
                    Console.WriteLine(Split[i] + " : " + TotalQ);
                    TotalQ = 0;
                }
            }           
        }
    }
}