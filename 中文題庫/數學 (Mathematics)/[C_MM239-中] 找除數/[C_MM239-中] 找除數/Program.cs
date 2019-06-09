using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        List<string> data = new List<string>();
        string[] input = Console.ReadLine().Split();
        decimal start = decimal.Parse(input[0]), end = decimal.Parse(input[1]);

        for (decimal i = start; i <= end; i++)
        {
            decimal index = 0;
            Console.Write(i+". ");
            for (decimal j = 1; j <= i / 2; j++)
            {
                if (i % j == 0) Console.Write(j + " ");
            }
            Console.WriteLine(i);
        }
    }
}