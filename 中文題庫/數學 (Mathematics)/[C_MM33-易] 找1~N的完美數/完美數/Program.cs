using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 完美數
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                decimal[] pernum = { 6, 28, 496, 8128, 33550336, 8589869056, 137438691328, 2305843008139952128 };
                int ip = int.Parse(Console.ReadLine());
                int o = 0;
                string display = "";
                for (int i = 0; i <= ip; i += 2)
                {
                    if (i == pernum[o])
                    {
                        o++;
                        display += i + " ";
                    }
                }
                Console.WriteLine(display.TrimEnd(' '));
            }
        }
    }
}
