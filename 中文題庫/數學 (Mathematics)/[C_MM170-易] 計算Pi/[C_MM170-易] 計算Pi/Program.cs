using System;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 0) break;
            double sum = 0;
            for (double i = 0, k = 1; i < n; i++, k += 2)
            {
                if (i % 2 == 0) sum += 4 / k;
                else sum -= 4 / k;
            }
            Console.WriteLine("{0:0.00000}", sum);
        }
    }
}