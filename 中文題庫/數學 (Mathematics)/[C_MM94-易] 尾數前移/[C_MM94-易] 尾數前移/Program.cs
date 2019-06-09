using System;
class Program
{
    static void Main(string[] args)
    {
        string[] s = Console.ReadLine().Split(',');
        int q = int.Parse(s[0]) / int.Parse(s[1]), a, r = int.Parse(s[0]) % int.Parse(s[1]);
        Console.Write(q);//頭
        while (r != 0 || q != int.Parse(s[0]))
        {
            a = q + r * 10;
            q = a / int.Parse(s[1]);
            r = a % int.Parse(s[1]);
            Console.Write(q);
        }
        Console.WriteLine();//換行
    }
}