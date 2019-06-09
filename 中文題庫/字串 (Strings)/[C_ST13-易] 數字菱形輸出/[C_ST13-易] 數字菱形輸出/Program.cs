using System;
class P
{
    static void Main()
    {
        Console.WriteLine(8900^123414);
        int n = 3;//int.Parse(Console.ReadLine());
        for (int i = 1,c=n; i <= n; i++)
        {
            
            for (int j = 1,a=1;a<n*2 ;a++)
            {
                if (a >= c)
                {
                    Console.Write(j);
                    j++;
                }
                else Console.Write("X");
            }
            c--;
            Console.WriteLine();
        }
    }
}