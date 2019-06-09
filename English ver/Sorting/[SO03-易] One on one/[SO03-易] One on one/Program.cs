using System;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            if (n != 0)
            {
                int final = 0;
                string[] p1 = Console.ReadLine().Split();
                string[] temp = Console.ReadLine().Split();
                int[] p2 = new int[n];
                for (int i = 0; i < n; i++)
                    p2[i] = int.Parse(temp[i]);
                Array.Sort(p2);
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                    {
                        if (p2[i] > int.Parse(p1[j]) && p1[j] != "-1")
                        {
                            p1[j] = "-1";
                            final++;
                        }
                    }
                Console.WriteLine(final);
            }
            else break;
        }
    }
}