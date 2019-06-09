using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR202_易__五行生剋
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int g = 0; g < n; g++)
            {
                string[] ip = Console.ReadLine().Split();
                string str ="";
                if(ip[1]== "Generating")
                {
                    if (ip[0] == "Metal") str = "Water";
                    else if (ip[0] == "Wood") str = "Fire";
                    else if (ip[0] == "Water") str = "Wood";
                    else if (ip[0] == "Fire") str = "Earth";
                    else if (ip[0] == "Earth") str = "Metal";
                }
                else
                {
                    if (ip[0] == "Metal") str = "Wood";
                    else if (ip[0] == "Wood") str = "Earth";
                    else if (ip[0] == "Water") str = "Fire";
                    else if (ip[0] == "Fire") str = "Metal";
                    else if (ip[0] == "Earth") str = "Water";
                }
                Console.WriteLine(str);
            }
        }
    }
}