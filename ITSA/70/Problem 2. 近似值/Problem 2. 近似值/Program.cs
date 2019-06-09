using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.近似值
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                for (int a = 0; a < n; a++)
                {
                    int L = int.Parse(Console.ReadLine());
                    string[] G = Console.ReadLine().Split();
                    for (int i = 0; i < L; i++) Console.WriteLine(papa(G[i]));
                }
            }
            catch
            {
                return;
            }           
        }
        static string papa(string m)
        {
            string pi = "14159265358979323846";
            return pi.Substring(int.Parse(m)-1, 1);
        }
    }
}