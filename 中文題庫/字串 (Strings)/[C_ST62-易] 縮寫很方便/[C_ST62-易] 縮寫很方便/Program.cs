using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST62_易__縮寫很方便
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] ip = Console.ReadLine().Split();
                if (ip[0] == "") break;
                for (int i = 0; i < ip.Length; i++)
                {
                    char sub = Convert.ToChar(ip[i].Substring(0, 1));
                    if (sub >= 'A' && sub <= 'Z')
                    {
                        Console.Write(sub);
                    }
                }
                Console.WriteLine();
            }           
        }
    }
}