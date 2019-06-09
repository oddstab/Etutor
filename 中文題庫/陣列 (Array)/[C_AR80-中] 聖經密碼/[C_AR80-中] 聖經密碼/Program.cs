using System;
using System.Linq;

namespace _C_AR80_中__聖經密碼
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] index ="ddaazadassdchnrmloqzfhkujqwfvxhf,l.f124sae355d9fgd121cz6aefgb2366b6hhcqr75z8i9hb rstyuvwxsjlvakmn0op".ToArray();
            string[] ip = Console.ReadLine().Split(',');
            for (int i = 0; i < ip.Length; i+=2)
            {
                int a = int.Parse(ip[i])*10;
                int b = int.Parse(ip[i+1]);
                Console.Write(index[a + b]);
            }
            Console.WriteLine();
        }
    }
}