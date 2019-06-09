using System;
using System.Collections.Generic;
using System.Linq;

namespace _AR20_中__Palindorme
{
    class Program
    {
        static void Main(string[] args)
        {
            string origin = Console.ReadLine(),New = "";
            Stack<char> pa = new Stack<char>(origin.ToArray());
            for (int i = 0; i < origin.Length; i++) New += pa.Pop();
            if (New == origin) Console.WriteLine("yes");
            else Console.WriteLine("no");
        }
    }
}