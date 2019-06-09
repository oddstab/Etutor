using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 檢驗學號
{
    class Program
    {
        static void Main(string[] args)
        {
            char abcd = ' ';
            int[] c = new int[12];
            int n = int.Parse(Console.ReadLine());
            for (int o = 0; o < n; o++)
            {
                string str =Console.ReadLine();
                for (int i = 0; i < 12; i++)
                {
                    c[i] = int.Parse(str.Substring(i, 1));
                }
                int v = 26 - (((c[0] + c[2] + c[4] + c[6] + c[8] + c[10]) + 3 * (c[1] + c[3] + c[5] + c[7] + c[9] + c[11])) % 26);
                for (int abc = 1, ascii = 65; abc <= 26; abc++, ascii++)
                {
                    abcd = Convert.ToChar(ascii);
                    if (v == abc)
                    {
                        if (Convert.ToChar(str.Substring(12, 1)) == abcd) Console.WriteLine("valid");
                        else Console.WriteLine("invalid");
                    }
                }
            }
        }
    }
}