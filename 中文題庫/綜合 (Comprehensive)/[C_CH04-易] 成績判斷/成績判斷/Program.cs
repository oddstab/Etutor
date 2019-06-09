using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 成績判斷
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int grade = int.Parse(Console.ReadLine());
                if (grade >= 90 && grade <= 100) Console.WriteLine("A");
                else if (grade <= 89 && grade >= 80) Console.WriteLine("B");
                else if (grade <= 79 && grade >= 70) Console.WriteLine("C");
                else if (grade <= 69 && grade >= 60) Console.WriteLine("D");
                else if (grade > 100) Console.WriteLine("error");
                else if (grade < 60) Console.WriteLine("E");
                Console.ReadKey();
            }
            
        }
    }
}
