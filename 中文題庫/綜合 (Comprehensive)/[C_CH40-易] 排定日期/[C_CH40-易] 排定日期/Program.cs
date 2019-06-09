using System;
class Program
{
    static void Main(string[] args)
    {
        bool yes = false;
        for (int i = 0; i < 2; i++) Console.ReadLine();
        int days_int = int.Parse(Console.ReadLine());
        int person = int.Parse(Console.ReadLine());
        string[] ox = new string[person];
        for (int i = 0; i < person; i++)
            ox[i] = Console.ReadLine();
        for (int i = 0, q = 1; i < days_int*2; i += 2,q++)
        {
            for (int j = 1; j < person; j++)
            {
                if (ox[0][i] != ox[j][i])
                {
                    yes = false;
                    break;
                }
                yes = true;
            }
            if (yes) Console.WriteLine(q);
        }
    }
}