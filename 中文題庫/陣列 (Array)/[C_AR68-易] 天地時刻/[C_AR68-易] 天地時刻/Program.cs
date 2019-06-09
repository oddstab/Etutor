using System;
namespace _C_AR68_易__天地時刻
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Q = new string[] { "ox", "tiger", "rabbit", "dragon", "snake", "horse", "goat", "monkey", " rooster", "dog", "pig", "rat" };
            string[] IP = Console.ReadLine().Split(' ');
            int a = int.Parse(IP[0]);
            int b = int.Parse(IP[1]);
            for (int i = 1, t = 0; t < 12; t++, i += 2)
            {
                if ((a == i && b <= 59) || (a == (i + 1 == 24 ? 0 : i + 1) && b <= 59)) Console.WriteLine(Q[t]);
            }
        }
    }
}