using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            char[] s = new char[111];
            s = Console.ReadLine().ToCharArray();
            Stack<string> L = new Stack<string>(), R = new Stack<string>();
            string input = Console.ReadLine();
            if (input == "end") break;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(') L.Push(input[i].ToString());
                else
                {
                    R.Push(")");
                    if (L.Count != 0) { L.Pop(); R.Pop(); }
                }
            }
            if (L.Count == 0 && R.Count == 0) Console.WriteLine(1);
            else Console.WriteLine(-1);
        }
    }
}