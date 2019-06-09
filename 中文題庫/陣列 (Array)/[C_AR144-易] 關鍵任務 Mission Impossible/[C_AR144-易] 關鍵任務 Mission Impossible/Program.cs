using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR144_易__關鍵任務_Mission_Impossible
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] IP = Console.ReadLine().Split();
            string[] C = new string[IP.Length];
            IP.CopyTo(C,0);
            for(int i =0;i<C.Length; i++)
            {
                for(int j = 1; j < C.Length - i; j++)
                {
                    if (int.Parse(C[j - 1]) < int.Parse(C[j]))
                    {
                        string t = C[j - 1];
                        C[j - 1] = C[j];
                        C[j] = t;
                    }
                }
            }
            int sum = 0;
            int max = int.Parse(C[0]);
            for (int i = 0; i < C.Length; i++) sum += int.Parse(C[i]);
            Console.WriteLine("{0} {1} {2}",C[C.Length-1],Array.IndexOf(IP,max.ToString()),sum);
        }
    }
}