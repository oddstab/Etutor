using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR96_易__換位加密
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int m = int.Parse(Console.ReadLine());
            string[,] PW = new string[m, m];
            string str = Console.ReadLine();
            string sub = "", display = "";
            if (a == "0")
            {
                for (int i = 0, len = 0; i < m; i++)
                {
                    for (int j = 0; j < m; j++, len++)
                    {
                        if (!(len >= str.Length)) sub = str.Substring(len, 1);
                        PW[i, j] = len < str.Length ? sub : " ";
                    }
                }
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        display += PW[j, i];
                    }
                }
                Console.WriteLine(display.Trim());
            }
            else
            {
                for (int i = 0, len = 0; i < m; i++)
                {
                    for (int j = 0; j < m; j++, len++)
                    {
                        if (len < str.Length) sub = str.Substring(len, 1);
                        PW[j, i] = len < str.Length ? sub : " ";
                    }
                }
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        display += PW[i, j];
                    }
                }
                Console.WriteLine(display.Trim());
            }
        }
    }
}