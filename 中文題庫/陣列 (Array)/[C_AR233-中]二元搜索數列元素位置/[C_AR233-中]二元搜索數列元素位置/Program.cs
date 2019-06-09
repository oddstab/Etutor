using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int g = 0, l = n; g < l; g++)
        {
            n = int.Parse(Console.ReadLine());
            string[] ip = Console.ReadLine().Split();
            int[] data = new int[n];
            for (int i = 0; i < n; i++)
                data[i] = int.Parse(ip[i]);
            Array.Sort(data);
            string t = ip[n - 1];
            for (int i = 0; i < n; i++)
            {
                Console.Write(data[i]);
                if (i != n - 1) Console.Write(" ");
            }
            Console.WriteLine("\n" + t + " " + (Array.IndexOf(data, int.Parse(t)) + 1));
        }
    }
}