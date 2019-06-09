using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST52_中__Distance_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] data = new string[n];
            for (int g = 0; g < n; g++)
            {
                data[g] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < n - i; j++)
                {
                    int a = int.Parse(data[j - 1].Substring(data[j - 1].LastIndexOf(" ")));
                    int b = int.Parse(data[j].Substring(data[j].LastIndexOf(" ")));
                    if (a > b)
                    {
                        string temp = data[j - 1];
                        data[j - 1] = data[j];
                        data[j] = temp;
                    }
                }
            }
            foreach (string s in data) Console.WriteLine(s);
        }
    }
}