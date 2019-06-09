using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST36_易___列舉迴文數
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string SP = Console.ReadLine();
                if (Palindrome(SP)) Console.WriteLine(SP);
                else
                {
                    for (decimal i = 0; i < 50; i++)
                    {
                        decimal a = decimal.Parse(SP);
                        decimal b = decimal.Parse(Resolve(SP));
                        decimal c = a + b;
                        if (Palindrome((a + b).ToString()))
                        {
                            Console.WriteLine(a + "+" + b + "=" + (a + b));
                            break;
                        }
                        else
                        {
                            Console.WriteLine(a + "+" + b + "=" + (a + b));
                            SP = c.ToString();
                        }
                    }
                }
            }
        }
        static bool Palindrome(string x)
        {
            char[] condtional = x.ToCharArray();
            Array.Reverse(condtional);
            if (new string(condtional) == x) return true;
            else return false;
        }
        static string Resolve(string m)
        {
            char[] p = m.ToCharArray();
            Array.Reverse(p);
            return new string(p);
        }
    }
}
