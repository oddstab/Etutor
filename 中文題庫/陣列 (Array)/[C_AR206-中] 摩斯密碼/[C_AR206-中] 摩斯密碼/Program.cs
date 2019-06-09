using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR206_中__摩斯密碼
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> keys = new Dictionary<string, string>()
            {
                {"T","0" },{"M","00" },{"N","01" },{"O","000" },{"G","001" },{"K","010" },{"D","011" },{"CH","0000" },{"Ö","0001" },
                {"Q","0010" },{"Z","0011" },{"Y","0100" },{"C","0101" },{"X","0110" },{"B","0111" },
                {"E","1" },{"A","10" },{"I","11" },{"W","100" },{"R","101" },{"U","110" },{"S","111" },{"J","1000" },{"P","1001" },
                { "Ä","1010" },{"L","1011" },{"Ü","1100" },{"F","1101" },{"V","1110" },{"H","1111" }
            };
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string ip = Console.ReadLine();
                Console.Write(ip + ":");
                for(int j =0;j<ip.Length; j++)
                {
                    Console.Write(" "+keys[ip.Substring(j,1)]);
                }
                Console.WriteLine();
            }
        }
    }
}