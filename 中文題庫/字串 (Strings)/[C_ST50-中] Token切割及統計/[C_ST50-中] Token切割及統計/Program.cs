using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST50_中__Token切割及統計
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                char[] SP = Console.ReadLine().TrimEnd('\"').TrimStart('\"').ToCharArray();
                string str = Console.ReadLine().ToUpper();
                int c = 0;
                string[] Article = Console.ReadLine().ToUpper().Split(SP);
                for (int i = 0; i < Article.Length; i++) if (str == Article[i]) c++;
                Console.WriteLine(c);
            }
        }
    }
}