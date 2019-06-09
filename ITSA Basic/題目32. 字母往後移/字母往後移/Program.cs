using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字母往後移
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string IP = Console.ReadLine();
                int n = int.Parse(Console.ReadLine());
                char[] IPsplit = IP.ToCharArray();

                for (int i = 0; i < IPsplit.Length; i++)
                {
                    Console.Write(ChangeEng(IPsplit[i], n));
                }
                Console.WriteLine();
            }
        }
        static char ChangeEng(char N, int sort)
        {
            if (!(N >= 48 && N <= 57) && !(N >= 65 && N <= 90) && !(N >= 97 && N <= 122)) return N;
            N = (char)(N + sort);
            if (N > 90 && N < 97) N = (char)(N - 90 + 64);
            if (N > 122) N = (char)(N - 122 + 96);
            if (N > 57 && N < 65) N = (char)(N - 57 + 47);
            return N;
        }
    }
}
