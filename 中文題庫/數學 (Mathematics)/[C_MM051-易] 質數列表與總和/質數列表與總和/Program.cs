using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 質數列表與總和
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int io = 0;
                int iN = 2;
                int sum = 0;
                int ip = int.Parse(Console.ReadLine());
                while (io < ip)
                {
                    if (Pnum(iN) == true)
                    {
                        io++;
                        Console.Write(iN + ",");
                        sum += iN;
                    }
                    iN++;
                }
                Console.WriteLine("\n"+sum);
            }
        }
        static bool Pnum(int x)
        {
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
    }
}
