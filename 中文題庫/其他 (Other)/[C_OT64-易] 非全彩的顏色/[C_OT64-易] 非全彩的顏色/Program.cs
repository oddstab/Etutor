using System;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            int input = int.Parse(Console.ReadLine());
            string RGB = Convert.ToString(input, 2).PadLeft(8, '0');
            int R = Convert.ToInt32(RGB.Substring(0, 3), 2);
            int G = Convert.ToInt32(RGB.Substring(3, 3), 2);
            int B = Convert.ToInt32(RGB.Substring(6, 2), 2);
            Console.WriteLine(R + " " + G + " " + B);
        }       
    }
}