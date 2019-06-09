using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR029_難__文字編碼
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int m = (int)Math.Sqrt(str.Length);
            if (m * m < str.Length) m++;
            string[,] MXM = new string[m, m];
            string sub = "", Display = "";
            for (int i = 0, len = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++, len++)
                {
                    if (!(len >= str.Length)) sub = str.Substring(len, 1);
                    MXM[i, j] = len < str.Length ? sub : " ";
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++) Display += MXM[j, i];
            }
            Console.WriteLine(Display);
			Console.ReadKey();
        }
    }
}