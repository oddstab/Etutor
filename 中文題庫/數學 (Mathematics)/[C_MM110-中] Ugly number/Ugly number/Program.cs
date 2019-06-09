using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ugly_number
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int i = 1;
                int ugunm = int.Parse(Console.ReadLine());
                for (int nth = 1; nth <= ugunm; i++)
                {
                    if (Isug(i)) nth++;
                }
                Console.WriteLine(i - 1);
            }
        }
        static bool Isug(int ug)
        {
            if (ug <= 0) return false;
            while (true)
            {
                if (ug == 1) return true;
                if (ug % 2 == 0) { ug /= 2; continue; }
                else if (ug % 3 == 0) { ug /= 3; continue; }
                else if (ug % 5 == 0) { ug /= 5; continue; }
                else return false;
            }
        }
    }
}
