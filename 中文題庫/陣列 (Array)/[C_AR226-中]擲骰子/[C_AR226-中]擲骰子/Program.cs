using System;
class Program
{
    static void Main(string[] args)
    {
        string[] xy = Console.ReadLine().Split();
        int mult = int.Parse(xy[0]);
        int[] len = new int[6];
        int[,] p = new int[4, 2];

        for (int i = 0, c = 1; i < 4; i++)
            for (int j = 0; j < 2; j++)
                p[i, j] = int.Parse(xy[c++]) * mult;

        for (int i = 0, c = 0; i < 3; i++)
            for (int j = i + 1; j <= 3; j++)
                len[c++] = (int)(Math.Pow(p[i, 0] - p[j, 0], 2) + Math.Pow(p[i, 1] - p[j, 1], 2));

        Array.Sort(len);
        int distance = (int)Math.Sqrt(Math.Pow(p[0, 0] - p[1, 0], 2) + Math.Pow(p[0, 1] - p[1, 1], 2));
        int a = (p[0, 1] - p[2, 1]) * (p[1, 1] - p[3, 1]);
        int b = (p[1, 0] - p[3, 0]) * (p[0, 0] - p[2, 0]);
        if (len[0] == len[1] && len[4] == len[5] && len[4] > len[1])
        {
            if (a == -b)
            {
                Console.WriteLine("菱形");
            }
            else
            {
                Console.WriteLine("Yes " + distance * distance);
            }
            
        }
            
        else Console.WriteLine("No");
    }
}