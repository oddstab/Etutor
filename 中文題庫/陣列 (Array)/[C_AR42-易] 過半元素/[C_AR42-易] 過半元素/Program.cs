using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR42_易__過半元素
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                bool A = false;
                string[] ip = Console.ReadLine().Split(' ');
                for (int i = 0; i < ip.Length; i++)
                {
                    A = Q(ip, i);
                    if (A)
                    {
                        Console.WriteLine(ip[i]);
                        break;
                    }
                }
                if (!A) Console.WriteLine("NO");
            }
        }
        static bool Q(string[] str, int i)
        {
            int c = 0;
            for (int j = 0; j < str.Length; j++)
            {
                if (str[i] == str[j]) c++;
            }
            if (c > str.Length / 2) return true;
            else return false;
        }
    }
}
