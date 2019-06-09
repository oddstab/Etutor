using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int len = int.Parse(Console.ReadLine());
        int[,] key = new int[len, len];
        string str = "";
        for (int i = 0; i < len; i++)
        {
            string[] ip = Console.ReadLine().Split();
            for (int j = 0; j < len; j++)
                key[i, j] = int.Parse(ip[j]);
        }
        int[,] temp = key;
        for (int count = 0; count < n; count++)
        {
            string ABC = Console.ReadLine().Trim();
            for (int j = 0; j < ABC.Length; j++)
            {
                if (ABC[j] == 'A') { Right(ref key); }
                else if (ABC[j] == 'B') { Right(ref key); Right(ref key); }
                else { Right(ref key); Right(ref key); Right(ref key); }
            }
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                    str += key[i, j] +" ";
                str += "\n";
            }
            str += (count != n - 1 ? "\n" : "");
            key = temp;
        }
        Console.Write(str);
    }
    static void Right(ref int[,] m)
    {
        int[,] copy = m;
        int len = m.GetLength(0);
        m = new int[len, len];
        for (int i = 0; i < len; i++)
            for (int j = 0; j < len; j++)
                m[i, j] = copy[len - 1 - j, i];
        return;
    }
}