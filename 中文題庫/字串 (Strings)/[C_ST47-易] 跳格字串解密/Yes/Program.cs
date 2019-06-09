using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yes
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] Cstr = Console.ReadLine().ToCharArray(); 
            for(int i =0;i<Cstr.Length; i++)
            {
                if (i == 0) Console.Write(Cstr[i]);
                else if (i % 3 == 0) Console.Write(Cstr[i]);
            }
            Console.WriteLine();
        }
    }
}
