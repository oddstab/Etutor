using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 平閏年
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            //int year = int.Parse(Console.ReadLine());
            //Random oo = new Random();
            if((input%4==0&&input%100!=0)||input%400==0)
            {
                Console.WriteLine("Bissextile Year");
            }
            else
            {
                Console.WriteLine("Common Year");
            }
            
            Console.ReadKey();
        }
    }
}
