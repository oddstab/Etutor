using System;
class Program
{
    static void Main(string[] args)
    {
        double n = double.Parse(Console.ReadLine()), NS = 0, S = 0;
        if (n > 700) { S += (n - 700) * 5.63; NS += (n - 700) * 4.50; n = 700; }
        if (n > 500) { S += (n - 500) * 4.97; NS += (n - 500) * 4.01; n = 500; }
        if (n > 330) { S += (n - 330) * 4.39; NS += (n - 330) * 3.61; n = 330; }
        if (n > 120) { S += (n - 120) * 3.02; NS += (n - 120) * 2.68; n = 120; }
        if (n > 0) { S += n * 2.10; NS += n * 2.10; }
        Console.WriteLine("Summer months:{0:0.00}\nNon-Summer months:{1:0.00}", S, NS);
    }
}