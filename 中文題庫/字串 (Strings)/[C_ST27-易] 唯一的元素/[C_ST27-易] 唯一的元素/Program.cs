using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST27_易__唯一的元素
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] S = new string[n];
            S = Console.ReadLine().Split(' ');
            string str = "";
            for(int i =0;i<n; i++)
            {
                for(int j =0;j<n; j++)
                {
                    if (i == j) continue;
                    if (S[i] == S[j]) S[j] = null;
                }
            }
            for(int i =0;i<n; i++)if (S[i] != null)  str+=S[i]+" ";
            Console.WriteLine(str.TrimEnd(' '));
        }
    }
}
