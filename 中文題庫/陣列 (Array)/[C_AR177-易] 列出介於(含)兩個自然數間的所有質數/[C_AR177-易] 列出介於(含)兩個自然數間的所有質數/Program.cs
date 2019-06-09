using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int g = 0; g < n; g++)
        {
            bool y = true;
            string str = "";
            string[] input = Console.ReadLine().Split();
            for (int i = int.Parse(input[0]); i <= int.Parse(input[1]); i++, y = true)
            {
                for (int a = 2; a < i; a++)
                    if (i % a == 0)
                    {
                        y = false;
                        break;
                    }
                if (y) str += i + ",";
            }
            if (str.Length == 0) Console.WriteLine("none");
            else Console.WriteLine(str.TrimEnd(','));
        }
    }
}