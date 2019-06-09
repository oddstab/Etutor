using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR40_易__螺旋矩陣
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int ip = 17;//int.Parse(Console.ReadLine());
                string[,] ARR = new string[ip, ip];

                int i = 0;
                int j = 0;
                int a = ip;
                int st = 1;
                for(int n = 0; n < ip / 2; n++)
                {
                    for (; j < a - 1; j++) ARR[i, j] = st++.ToString("000");
                    for (; i < a - 1; i++) ARR[i, j] = st++.ToString("000");
                    for (j = a - 1; j > n; j--) ARR[i, j] = st.ToString("000");
                    for (i = a - 1; i > n; i--) ARR[i, j] = st.ToString("000");
                    i++; a--; st -= 1;
                }
                if (ip % 2 != 0) ARR[i, j + 1] = st + 1.ToString("000");
                for (i = 0; i < ip; i++)
                {
                    for (j = 0; j < ip; j++)
                    {
                        Console.Write(ARR[i, j] + ",");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
