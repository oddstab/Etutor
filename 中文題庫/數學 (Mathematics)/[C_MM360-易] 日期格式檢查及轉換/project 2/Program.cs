using System;
class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 5; i++)
        {
            string[] s = Console.ReadLine().Split('/');
            int d = int.Parse(s[0]);
            if (s[0].Length != 4) Console.WriteLine("false");
            else
            {
                if ((d % 4 == 0 && d % 100 != 0 || d % 400 == 0))
                {

                }
            }
            
        }

    }
}