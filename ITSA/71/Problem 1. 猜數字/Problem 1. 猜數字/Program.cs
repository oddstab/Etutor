using System;
class Program
{
    static void Main(string[] args)
    {      
        string ans = Console.ReadLine();
        while (true)
        {
            int A = 0, B = 0;
            string temp = Console.ReadLine();
            if (temp == "0000") break;
            for (int i = 0; i < 4; i++)
            {
                if (ans.IndexOf(temp[i]) != -1)
                {
                    if (temp.IndexOf(temp[i]) == ans.IndexOf(temp[i]))
                        A++;
                    else B++;
                }
            }
            Console.WriteLine("{0}A{1}B", A, B);
        }
    }
}