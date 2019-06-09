using System;
class Program
{
    static void Main(string[] args)
    {
        string[][] O = new string[10][];
        O[0] = new string[] { "****", "*  *", "*  *", "*  *", "****" };
        O[1] = new string[] { "   *", "   *", "   *", "   *", "   *" };
        O[2] = new string[] { "****", "   *", "****", "*   ", "****" };
        O[3] = new string[] { "****", "   *", "****", "   *", "****" };
        O[4] = new string[] { "*  *", "*  *", "****", "   *", "   *" };
        O[5] = new string[] { "****", "*   ", "****", "   *", "****" };
        O[6] = new string[] { "****", "*   ", "****", "*  *", "****" };
        O[7] = new string[] { "****", "   *", "   *", "   *", "   *" };
        O[8] = new string[] { "****", "*  *", "****", "*  *", "****" };
        O[9] = new string[] { "****", "*  *", "****", "   *", "   *" };
        string x = Console.ReadLine(), dis = "";
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 4; j++)
                if (O[int.Parse(x)][i][j] == '*')
                    dis += string.Format("({0},{1}) ", i, j);
            dis = dis.TrimEnd() + (i != 4 ? "\n" : "");
        }
        Console.WriteLine(dis);
    }
}