using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        while (Convert.ToBoolean(n--))
        {
            string[] str = Console.ReadLine().Split();
            if (str[0] == "echo" && str[1][0] == '\"')
                Console.WriteLine(str[1]);
            else

        }
    }
}