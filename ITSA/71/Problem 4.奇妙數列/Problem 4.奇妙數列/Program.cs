using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_MM115_中__奇妙數列
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    List<int> ST = new List<int>();
                    int n = int.Parse(Console.ReadLine());
                    ST.Add(1);
                    for (int T = 2; ; T++)
                    {
                        if (!ST.Contains(T))
                        {
                            ST.Add(ST[ST.Count - 1] + T);
                        }
                        if (ST.Count == n || n == 1) break;
                    }
                    if (n == 1) Console.WriteLine("1");
                    else Console.WriteLine(ST[ST.Count - 1]);
                }
                catch
                {
                    break;
                }
                
            }           
        }
    }
}