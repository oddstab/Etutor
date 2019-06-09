using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Game_選擇角色
{
    class Program
    {
        static void Main(string[] args)
        {
            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Console.WriteLine("Person");
                    break;
                case 2:
                    Console.WriteLine("Fairy");
                    break;
                case 3:
                    Console.WriteLine("Dwarf");
                    break;
            }
            Console.ReadKey();
        }
    }
}
