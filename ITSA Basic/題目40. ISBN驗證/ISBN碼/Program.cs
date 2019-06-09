using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBN碼
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] S = Console.ReadLine().Split(' ');
                int[] ISBN = new int[S.Length];
                int[] i2 = new int[S.Length];

                for (int i = 0; i < S.Length; i++)
                {
                    if (S[i] == "X")
                    {
                        i2[i] = 10;
                        continue;
                    }
                    i2[i] = int.Parse(S[i]);
                }

                //for (int k = 0; k < 2; k++)
                //{
                //    for (int j = 1; j < 10; j++)
                //    {
                //        i2[j] = i2[j - 1] + i2[j];
                //    }
                //}

                for (int i = 0, o = 0; i < S.Length; o++, i++)
                {
                    ISBN[i] = ISBN[(i - 1 < 0 ? 0 : i - 1)] + i2[i];
                    if (o == 18) break;
                    if (i == 9)
                    {
                        i2 = ISBN;
                        i = 0;
                        continue;
                    }
                }
                if (ISBN[ISBN.Length - 1] % 11 == 0) Console.WriteLine("YES");
                else Console.WriteLine("NO");
            }
        }
    }
}
