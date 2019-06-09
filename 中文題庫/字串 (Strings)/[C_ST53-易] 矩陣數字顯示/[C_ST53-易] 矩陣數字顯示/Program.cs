using System;
class Program
{
    static void Main(string[] args)
    {
        string[] O = { "*****", "*   *", "*   *", "*   *", "*****" };
        string[] o1 = { "    *", "    *", "    *", "    *", "    *" };
        string[] o2 = { "*****", "    *", "*****", "*    ", "*****" };
        string[] o3 = { "*****", "    *", "*****", "    *", "*****" };
        string[] o4 = { "*   *", "*   *", "*****", "    *", "    *" };
        string[] o5 = { "*****", "*    ", "*****", "    *", "*****" };
        string[] o6 = { "*****", "*    ", "*****", "*   *", "*****" };
        string[] o7 = { "*****", "    *", "    *", "    *", "    *" };
        string[] o8 = { "*****", "*   *", "*****", "*   *", "*****" };
        string[] o9 = { "*****", "*   *", "*****", "    *", "    *" };
        string[][] d = new string[4][];
        for (int i = 0; i < 4; i++)
            d[i] = new string[5];
        string x = Console.ReadLine();
        for (int i = 0;i<4; i++)
        {
            switch (x.Substring(i, 1))
            {
                case "0": d[i] = O; break;
                case "1": d[i] = o1; break;
                case "2": d[i] = o2; break;
                case "3": d[i] = o3; break;
                case "4": d[i] = o4; break;
                case "5": d[i] = o5; break;
                case "6": d[i] = o6; break;
                case "7": d[i] = o7; break;
                case "8": d[i] = o8; break;
                case "9": d[i] = o9; break;
            }
        }
        for (int i = 0; i < 5; i++)
            Console.WriteLine("{0} {1} {2} {3}",d[0][i],d[1][i],d[2][i],d[3][i]);
    }
}