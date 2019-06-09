using System;
class Program
{
    static void Main(string[] args)
    {
        int[] d = new int[4];
        for (int i = 0; i < 4; i++)
            d[i] = int.Parse(Console.ReadLine());
        if (d[0] == d[1] && d[0] == d[2] && d[0] == d[3])
            Console.WriteLine("WIN");
        else if (d[0] != d[1] && d[0] != d[2] && d[0] != d[3])
            Console.WriteLine("R");
        else
        {
            Array.Sort(d);
            if (d[0] == d[1] && d[2] == d[3])
            {
                if (d[0] + d[1] > d[2] + d[3]) Console.WriteLine(d[0] + d[1]);
                else Console.WriteLine(d[2] + d[3]);
            }
            else
            {
                if (d[0] == d[1] && d[2] != d[3]) Console.WriteLine(d[2] + d[3]);
                else Console.WriteLine(d[0] + d[1]);
            }
        }
    }
}