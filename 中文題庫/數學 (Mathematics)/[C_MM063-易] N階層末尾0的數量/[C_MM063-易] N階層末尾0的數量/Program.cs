using System;

namespace _C_MM063_易__N階層末尾0的數量
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine()), temp = num, five = 0;
            while (temp != 0)
            {
                five += temp / 5;
                temp /= 5;
            }
            Console.WriteLine(five);
        }
    }
}