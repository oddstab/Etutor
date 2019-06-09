using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _AR27_易__Who_is_missing
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = int.Parse(Console.ReadLine());
            string[] student = Console.ReadLine().Split();
            for(int i = 1;i<=total ;i++)
                if(Array.IndexOf(student,i.ToString())==-1)
                    Console.WriteLine(i);
        }
    }
}
