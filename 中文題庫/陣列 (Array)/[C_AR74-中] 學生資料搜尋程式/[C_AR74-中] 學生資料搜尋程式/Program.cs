using System;
class Program
{
    static void Main(string[] args)
    {
        string[,] students = new string[5, 3]
        {
            {"123","Tom","DTGD" },
            {"456","Cat","CSIE" },
            {"789","Nana","ASIE" },
            {"321","Lim","DBA" },
            {"654","Won","FDD" },
        };
        int n = int.Parse(Console.ReadLine());
        while (Convert.ToBoolean(n--))
        {
            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 3; j++)
                    if (input[1] == students[i, j])
                    {
                        for (int k = 0; k < 3; k++)
                            Console.Write(students[i, k] + (k == 2 ? "\n" : " "));
                        break;
                    }
        }
    }
}