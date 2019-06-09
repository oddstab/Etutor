using System;
using System.Linq;

namespace _C_AR022_易__字母出現的頻率
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Q = new int[26];
            char[] abc = Console.ReadLine().ToLower().ToArray();
            for (int i = 0; i < abc.Length; i++) if (char.IsLower(abc[i])) Q[abc[i] - 97]++;
            for (int i = 0; i < 26; i++) Console.Write(Q[i] + (i != 25 ? " " : "\n"));
        }
    }
}