using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Problem_4__Broken_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                bool A = true;
                string str = Console.ReadLine();
                for (int i = 0; i < str.Length; i++)
                {
                    if (Y(str.Substring(i, 1)))
                    {
                        Console.Write((char)(int.Parse(str.Substring(i, 1)) + 96));
                        A = false;
                    }
                    if (i == str.Length - 1&&!A) Console.WriteLine();
                }
                if (A) Console.WriteLine("No Solution");
            }            
        }
        static bool Y(string sub)
        {
            try
            {
                int.Parse(sub);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
