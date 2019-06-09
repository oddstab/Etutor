using System;

namespace _C_ST63_易__尋找單字中的母音字母數量
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string ip = Console.ReadLine();
                char[] x = { 'a', 'e', 'i', 'o', 'u' };
                string[] s = ip.Split(x);
                Console.WriteLine(ip + " " + (s.Length - 1));
            }
        }
    }
}