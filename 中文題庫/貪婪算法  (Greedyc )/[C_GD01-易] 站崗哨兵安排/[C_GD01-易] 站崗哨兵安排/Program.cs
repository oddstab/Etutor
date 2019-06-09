using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        while (Convert.ToBoolean(n--))
        {
            //string soldier = Console.ReadLine().Replace("#", ""), Temp = "";
            string soldier = "xxxxxxxxxx";
            for (int i = 0; i < soldier.Length; i++)
            {
                if ((i + 1) % 3 == 0) Console.Write("O");
                else Console.Write("x");
            }


        }
    }
}