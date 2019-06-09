using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR209_中__兵聖
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> keys = new Dictionary<string, string>() { {"14", "General" },{"13","Staff" },{"24","Soldier" },{"23","execute by shooting" } };
            int n = int.Parse(Console.ReadLine());
            for (int a = 0; a < n; a++)
            {
                string ip = Console.ReadLine().Replace(" ","");
                Console.WriteLine(ip.Substring(0,ip.Length-2)+" "+keys[ip.Substring(ip.Length-2,2)]);
            }
        }
    }
}