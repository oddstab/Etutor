using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 求Emirp_反向質數
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int ip = int.Parse(Console.ReadLine());
                string rev;
                char[] chrev;
                for (int i = 1,nth=1;nth<=ip ; i++)
                {
                    chrev= i.ToString().ToCharArray();
                    Array.Reverse(chrev);
                    rev = new string(chrev);
                    if (Pnum(i))
                    {
                        if (Pnum(int.Parse(rev)))
                        {
                            Console.WriteLine(i);
                            nth++;
                        }
                    }
                }
            }
        }
        static bool Pnum(decimal x)
        {
            if (x == 1) return false;
            if (x == 2) return true;
            if (x % 2 == 0) return false;
            for (int i = 3; i <= Math.Pow((double)x, 1.0 / 2.0); i += 2)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
    }
}
