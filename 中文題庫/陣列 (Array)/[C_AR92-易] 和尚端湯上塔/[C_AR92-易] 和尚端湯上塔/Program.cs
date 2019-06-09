using System;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            int walk = 0;
            string[] s = Console.ReadLine().Split();
            for (int i = 1; i <= 10; i++)
                if (int.Parse(s[i - 1]) % i != 0)
                    walk++;
            if (walk > 3) Console.WriteLine("no");
            else Console.WriteLine("yes");
        }        
    }
}