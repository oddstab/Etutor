using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOXX
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int a = 0;
                string[] TXT = new string[9];
                string[] Arr = new string[9];
                for (int i = 0; i < 3; i++)
                {
                    TXT = Console.ReadLine().Split(' ');
                    for (int g = 0; g < 3; g++, a++)
                    {
                        Arr[a] = TXT[g];
                    }
                }
                Console.WriteLine(OOXX(Arr).ToString());
            }
        }
        static bool OOXX(string[] Cond)
        {
            for (int i = 0; i < 3; i++) //直  
            {
                if (Cond[i] + Cond[i + 3] + Cond[i + 6] == "000" || Cond[i] + Cond[i + 3] + Cond[i + 6] == "111") return true;
            }

            for (int i = 0; i < 7; i += 3) //橫  
            {
                if (Cond[i] + Cond[i + 1] + Cond[i + 2] == "000" || Cond[i] + Cond[i + 1] + Cond[i + 2] == "111") return true;
            }

            //斜  
            if (Cond[0] + Cond[4] + Cond[8] == "000" || Cond[0] + Cond[4] + Cond[8] == "111") return true;
            else if (Cond[2] + Cond[4] + Cond[6] == "000" || Cond[2] + Cond[4] + Cond[6] == "111") return true;
            return false;
        }
    }
}