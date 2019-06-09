using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string input = Console.ReadLine();
            int max = Regex.Matches(input,"!").Count;
            Console.WriteLine(input.Split(',','!','.').Length);
            if (input == "-1") break;

        }
    }
}