using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR207_中__怪姓名成績排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] str = new string[n];
            for (int s = 0; s < n; s++)
            {
                str[s] = Console.ReadLine();
            }
            Sort(str);
            for (int i = 0; i < n; i++) Console.WriteLine(i+1+" "+str[i]);
        }
        static void Sort(string[] m)
        {
            for (int i = 0; i < m.Length; i++)
            {
                for (int j = 1; j < m.Length - i; j++)
                {
                    int a = int.Parse(m[j - 1].Substring(m[j - 1].IndexOf(" ")));
                    int b = int.Parse(m[j].Substring(m[j].IndexOf(" ")));
                    if (a < b)
                    {
                        string temp = m[j];
                        m[j] = m[j - 1];
                        m[j - 1] = temp;
                    }
                    else if (a == b)
                    {
                        string sub1 = m[j - 1].Substring(0,m[j-1].IndexOf(" "));
                        string sub2 = m[j].Substring(0, m[j].IndexOf(" "));
                        if (string.Compare(sub1, sub2) > 0)
                        {
                            string temp = m[j];
                            m[j] = m[j - 1];
                            m[j - 1] = temp;
                        }
                    }

                }
            }
        }
    }
}