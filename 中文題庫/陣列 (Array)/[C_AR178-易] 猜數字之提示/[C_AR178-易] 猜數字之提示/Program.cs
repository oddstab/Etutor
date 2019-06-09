using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int k = 0; k < n; k++)
        {
            int A = 0, B = 0;
            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < 4; i++)
            {
                if (input[0].IndexOf(input[1][i]) != -1)
                {
                    if (input[1].IndexOf(input[1][i]) == input[0].IndexOf(input[1][i]))
                        A++;
                    else B++;
                }
            }
            Console.WriteLine("{0}A{1}B", A, B);
        }
    }
}