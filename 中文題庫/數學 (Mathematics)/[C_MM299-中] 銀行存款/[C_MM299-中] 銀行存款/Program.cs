using System;
class Program
{
    static string display = "", input;
    static void Main(string[] args)
    {
        double a = 0, b = 0;
        while (true)
        {
            input = Console.ReadLine();
            string[] cash = input.Split();
            switch (input[0])
            {
                case 'v':
                    display += string.Format("A : {0}, B : {1}\n", a, b);
                    break;
                case 'p':
                    double tpa = a < 0 ? 0 : a;
                    double tpb = b < 0 ? 0 : b;
                    double pa = tpa + tpb == 0 ? 0 : tpa / (tpa + tpb);
                    double pb = tpa + tpb == 0 ? 0 : tpb / (tpa + tpb);
                    display += string.Format("A : {0:0.0%}, B : {1:0.0%}\n", pa, pb);
                    break;
                case 's':
                    if (cash[1] == "a") a += int.Parse(cash[2]);
                    else b += int.Parse(cash[2]);
                    break;
                case 'w':
                    if (cash[1] == "a") a -= int.Parse(cash[2]);
                    else b -= int.Parse(cash[2]);
                    break;
                case '-':
                    Console.Write(display);
                    return;
            }
        }
    }
}