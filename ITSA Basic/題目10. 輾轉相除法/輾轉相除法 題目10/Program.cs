using System;

namespace XXOO
{
    class Program
    {
        static void Main()
        {
            char[] n = Console.ReadLine().ToCharArray();
            for (int i = n.Length - 1; i >= 0; i--)
            {
                Console.Write(PII(n[i]));
            }
            Console.WriteLine();
        }
        static char PII(char n)
        {
            if (n <= 57 && n >= 48) return n;
            for (int a = 65, b = 97; ; a++, b++)
            {
                if (n == a) return n = (char)b;
                if (n == b) return n = (char)a;
            }
        }
    }
}
