using System;

namespace Problem_2.近似值
{
    class Program
    {
        static void Main(string[] args)
        {
            string pi = "14159265358979323846";
            int Q = int.Parse(Console.ReadLine());
            string[] ip = Console.ReadLine().Split();
            for (int i = 0; i < Q; i++) Console.WriteLine(pi.Substring(int.Parse(ip[i]) - 1, 1));
        }
    }
}