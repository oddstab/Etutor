using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Game_選擇性別
{
    class Program
    {
        static void Main(string[] args)
        {
            string sex = Console.ReadLine();
            if (sex=="E")
            {
                Console.WriteLine("ByeBye");
            }
            else if (sex=="M")
            {
                Console.WriteLine("Male");
            }
            else if (sex=="F")
            {
                Console.WriteLine("Female");
            }
            Console.ReadKey();
        }
    }
}
