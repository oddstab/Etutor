using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR157_易__簡易替代加密
{
    class Program
    {
        static void Main(string[] args)
        {
            string origin = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string New = Console.ReadLine();
            string ip = Console.ReadLine().ToUpper();
            string str = "";
            for (int i = 0, a = 0; i < ip.Length; i++)
            {
                string sub = ip.Substring(i, 1);
                if (Convert.ToChar(sub) >= 'A' && Convert.ToChar(sub) <= 'Z')
                {
                    int index = origin.IndexOf(sub);
                    str+=New.Substring(index, 1);
                    a++;
                }
                if (a == 5)
                {
                    str+=" ";
                    a = 0;
                }
            }
            int len = str.Replace(" ", "").Length;
            while (len % 5 != 0)
            {
                str += "-";
                len++;
            }
            Console.WriteLine(str.TrimEnd());
            Console.ReadKey();
        }
    }
}