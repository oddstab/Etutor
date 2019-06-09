using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR208_中__NEＷ_START重新開始
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> NEW = new Dictionary<string, string>()
            {
                {"N","Nutrition"},{ "E","Exercise"},{"W","Water" },{"S","Sun" },{"T","Temper" },{"A","Air" },
                {"R","Rest" },{"t","trust" }
            };
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                Console.WriteLine(str+": "+NEW[str]);
            }
        }
    }
}